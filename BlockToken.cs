using System;
using System.Collections.Generic;
using Antlr.Runtime.Tree;
using System.Linq;
using System.Text;

namespace MathLang
{
    class BlockToken
    {
        ITree tree;
        int level = 0;
        Dictionary<string, Table> tables;
        Dictionary<int, List<Table>> usingTables;
        Queue<BlockToken> subquery = new Queue<BlockToken>();
        Table fromResult = new Table();
        Table selectResult = new Table();

        public Table SelectResult { get => selectResult; set => selectResult = value; }
        public Table FromResult { get => fromResult; set => fromResult = value; }

        public BlockToken(ITree tree, int level, Dictionary<string, Table> tables, Dictionary<int, List<Table>> usingTables)
        {
            this.tree = tree;
            this.level = level;
            this.tables = tables;
            this.usingTables = new Dictionary<int, List<Table>>();
            foreach (var t in usingTables)
            {
                this.usingTables.Add(t.Key, new List<Table>(t.Value));
            }
        }

        public void SemanticAnalization()
        {
            string errStr = "";
            SwapTreeNode();
            for (int i = 0; i < tree.ChildCount; i++)
            {
                AnalyzeNode(tree.GetChild(i), ref errStr);
            }
            Console.WriteLine(errStr);
        }

        string AnalyzeNode(ITree node, ref string errStr)
        {
            switch (node.Text)
            {
                case "BLOCK":
                    {
                        AnalyzeBlock(node, ref errStr);
                        break;
                    }
                case "from":
                    {
                        AnalyzeFrom(node, ref errStr);
                        break;
                    }
                case "select":
                    {
                        for (int i = 0; i < node.ChildCount; i++)
                        {
                            AnalyzeNode(node.GetChild(i), ref errStr);
                        }
                        break;
                    }
                case "TABLES":
                case "FIELDS":
                    {
                        for (int i = 0; i < node.ChildCount; i++)
                        {
                            AnalyzeNode(node.GetChild(i), ref errStr);
                        }
                        break;
                    }
                case "where":
                    {
                        for (int i = 0; i < node.ChildCount; i++)
                        {
                            AnalyzeNode(node.GetChild(i), ref errStr);
                        }
                        break;
                    }
                case "order by":
                    {
                        AnalyzeOrderBy(node, ref errStr);
                        break;
                    }
                case ".":
                    {
                        AnalyzeDot(node, ref errStr);
                        //DotToken dot = new DotToken(node, level, usingTables, FromResult, SelectResult);
                        //dot.SemanticAnalyze(ref errStr);
                        break;
                    }
                case "<":
                case ">":
                case "==":
                case ">=":
                case "<=":
                case "<>":
                    {
                        AnalyzeCompare(node, ref errStr);
                        break;
                    }
                default:
                    {
                        if (node.Parent.Text == "TABLES")
                        {
                            AddUsingTable(node.Text);
                        }
                        if (node.Parent.Text == "FIELDS")
                        {
                            if (!IsFieldExist(node))
                            {
                                errStr += "Ошибка: поле \"" +
                                      node.Text +
                                      "\" не существует в данном контексте \n";
                                break;
                            }
                            AddFieldByName(node.Text);
                        }
                        break;
                    }
            }
            return errStr;
        }

        bool IsTableDeclared(ITree node)
        {
            for (int i = 0; i < usingTables[level].Count; i++)
            {
                if (usingTables[level][i]._name == node.Text)
                {
                    return true;
                }
            }

            return false;
        }

        bool IsFieldExist(ITree node)
        {
            if (node.Text != "*")
            {
                for (int i = 0; i < FromResult.Data.Count; i++)
                {
                    if (FromResult.Data[i].Name == node.Text)
                    {
                        return true;
                    }
                }

            }
            else
            {
                return true;
            }
            return false;
        }

        void AddUsingTable(string tableName)
        {
            if (!usingTables.ContainsKey(level))
            {
                usingTables.Add(level, new List<Table>());
            }
            usingTables[level].Add(tables[tableName]);
        }

        void SwapTreeNode()
        {
            ITree tmp = tree.GetChild(0);
            tree.SetChild(0, tree.GetChild(1));
            tree.SetChild(1, tmp);
            try
            {
                tree.SetChild(1, tree.GetChild(2));
                tree.SetChild(2, tmp);
            }
            catch (Exception)
            { }
        }

        void GenerateFromResult()
        {
            foreach (Table t in usingTables[level])
            {
                FromResult = Table.Mult(FromResult, t);
            }
        }

        void AddFieldByName(string fieldName)
        {
            if (fieldName != "*")
            {
                Field field = fromResult.Data.Find(o => o.Name == fieldName);
                if (!selectResult.Data.Contains(field))
                {
                    selectResult.Data.Add(field);
                }
            }
            else
            {
                List<Field> list = FromResult.Data;
                foreach (Field field in list)
                {
                    if (!selectResult.Data.Contains(field))
                    {
                        selectResult.Data.Add(field);
                    }
                }
            }
        }

        void AddField(string fieldName, string tableName)
        {
            if (fieldName != "*")
            {
                Field field = fromResult.Data.Find(o => o.Name == fieldName
                                                     && o.StoredTableName == tableName);
                if (!selectResult.Data.Contains(field))
                {
                    selectResult.Data.Add(field);
                }
            }
            else
            {
                List<Field> list = FromResult.Data.FindAll(o => o.StoredTableName.Equals(tableName));
                foreach (Field field in list)
                {
                    if (!selectResult.Data.Contains(field))
                    {
                        selectResult.Data.Add(field);
                    }
                }
            }
        }

        void AnalyzeBlock(ITree node, ref string errStr)
        {
            level++;
            BlockToken block = new BlockToken(node, level, tables, usingTables);
            block.SemanticAnalization();
            subquery.Enqueue(block);
            level--;
        }

        void AnalyzeFrom(ITree node, ref string errStr)
        {
            for (int i = 0; i < node.ChildCount; i++)
            {
                AnalyzeNode(node.GetChild(i), ref errStr);
            }
            if (errStr == "")
            {
                GenerateFromResult();
            }
        }

        void AnalyzeOrderBy(ITree node, ref string errStr)
        {
            if (Convert.ToInt32(node.GetChild(0).Text) < 1 ||
                                Convert.ToInt32(node.GetChild(0).Text) > SelectResult.GetAttributeCount())
            {
                errStr += "Ошибка 'order by': значение числа должно быть между 1 и " + SelectResult.GetAttributeCount();
            }
        }

        void AnalyzeDot(ITree node, ref string errStr)
        {
            if (IsTableDeclared(node.GetChild(0)))
            {
                if (!IsFieldExist(node.GetChild(1)))
                {
                    errStr += "Ошибка: поля \"" +
                              node.GetChild(1).Text +
                              "\" нет в таблице" +
                              node.GetChild(0).Text
                              + "\n";
                    return;
                }
                if (node.Parent.Text.Equals("FIELDS"))
                {
                    AddField(node.GetChild(1).Text, node.GetChild(0).Text);
                }
            }
            else
            {
                errStr += "Ошибка: таблица \"" +
                          node.GetChild(0).Text +
                          "\" не существует в данном контексте \n";
            }
        }

        void AnalyzeCompare(ITree node, ref string errStr)
        {
            ITree leftOp = node.GetChild(0);
            ITree rightOp = node.GetChild(1);
            string localErrStr = "";
            string leftType = GetOperandType(leftOp, ref localErrStr);
            string rightType = GetOperandType(rightOp, ref localErrStr);
            if (localErrStr == "" && !leftType.Equals(rightType))
            {
                errStr += "Ошибка 'where': несовпадение типов данных \n";
            }
            errStr += localErrStr;
        }

        string GetOperandType(ITree node, ref string errStr)
        {
            string type = "";
            switch (node.Text)
            {
                case "BLOCK":
                    {
                        AnalyzeBlock(node, ref errStr);
                        BlockToken b = subquery.Last();
                        if (b.SelectResult.GetAttributeCount() != 1)
                        {
                            errStr += "Ошибка 'where' 'select': выборка содержит более одного столбца \n";
                            break;
                        }
                        if (b.SelectResult.GetTablePower() >= 1)
                        {
                            errStr += "Ошибка 'where': выборка содержит более одного кортежа \n";
                            break;
                        }
                        type = b.SelectResult.Data[0].Type;
                        break;
                    }
                case ".":
                    {
                        if (IsTableDeclared(node.GetChild(0)))
                        {
                            if (!IsFieldExist(node.GetChild(1)))
                            {
                                errStr += "Ошибка: поля \"" +
                                          node.GetChild(1).Text +
                                          "\" нет в таблице" +
                                          node.GetChild(0).Text
                                          + "\n";
                                break;
                            }
                            if (node.GetChild(1).Text.Equals("*"))
                            {
                                errStr += "Ошибка 'where': выборка содержит более одного столбца \n";
                                break;
                            }
                            Field f = FromResult.Data.Find(o => o.Name.Equals(node.GetChild(1).Text)
                                                             && o.StoredTableName.Equals(node.GetChild(0).Text));
                            type = f.Type;
                        }
                        else
                        {
                            errStr += "Ошибка: таблица \"" +
                                      node.GetChild(0).Text +
                                      "\" не существует в данном контексте \n";
                        }
                        break;
                    }
                default:
                    switch (node.Type)
                    {
                        case 16://NUMBER
                            {
                                type = "NUMBER";
                                break;
                            }
                        case 17://FIELD
                            {
                                if (!IsFieldExist(node))
                                {
                                    errStr += "Ошибка 'where': поле \"" +
                                              node.Text +
                                              "\" не существует в данном контексте" + "\n";
                                    break;
                                }
                                type = FromResult.Data.Find(o => o.Name.Equals(node.Text)).Type;
                                break;
                            }
                        case 18://TEXT
                            {
                                type = "TEXT";
                                break;
                            }
                        default:
                            break;
                    }
                    break;
            }
            return type;
        }
    }
}
