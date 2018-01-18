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
        public string errStr = "";
        bool interpret = false;

        public Table SelectResult { get => selectResult; set => selectResult = value; }
        public Table FromResult { get => fromResult; set => fromResult = value; }

        public BlockToken(ITree tree, int level,
                          Dictionary<string, Table> tables,
                          Dictionary<int, List<Table>> usingTables)
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



        #region Semantic analization
        public void SemanticAnalization()
        {
            SwapTreeNode();
            for (int i = 0; i < tree.ChildCount; i++)
            {
                AnalyzeNode(tree.GetChild(i), ref errStr);
            }
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
                case "and":
                case "or":
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
                        break;
                    }
                case "as":
                    {
                        AnalyzeAS(node, ref errStr);
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

        bool IsFieldExist(ITree field, ITree tabel)
        {
            if (field.Text != "*")
            {
                for (int i = 0; i < FromResult.Data.Count; i++)
                {
                    if (FromResult.Data[i].Name == field.Text
                        && FromResult.Data[i].StoredTableName == tabel.Text)
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
                if (tree.GetChild(2).Text == "where")
                {
                    tree.SetChild(1, tree.GetChild(2));
                    tree.SetChild(2, tmp);
                }
            }
            catch (Exception)
            { }
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
                FromResultFields();
            }
        }

        void FromResultFields()
        {
            foreach (Table t in usingTables[level])
            {
                FromResult.Data.AddRange(t.Data);
            }
        }

        void AnalyzeAS(ITree node, ref string errStr)
        {
            AnalyzeBlock(node.GetChild(0), ref errStr);
            BlockToken block = subquery.Last();
            SetTableAlias(node.GetChild(1).Text, block);
            tables.Add(block.SelectResult._name, block.SelectResult);
            AddUsingTable(block.SelectResult._name);
        }

        void SetTableAlias(string name, BlockToken block)
        {
            block.SelectResult._name = name;
            block.FromResult._name = name;
            for (int i = 0; i < block.SelectResult.GetAttributeCount(); i++)
            {
                block.SelectResult.Data[i].StoredTableName = name;
            }
            for (int i = 0; i < block.FromResult.GetAttributeCount(); i++)
            {
                block.FromResult.Data[i].StoredTableName = name;
            }
        }

        void AnalyzeOrderBy(ITree node, ref string errStr)
        {
            for (int i = 0; i < node.GetChild(0).ChildCount; i++)
            {
                if (Convert.ToInt32(node.GetChild(0).GetChild(i).Text) < 1 ||
                                Convert.ToInt32(node.GetChild(0).GetChild(i).Text) > SelectResult.GetAttributeCount())
                {
                    errStr += "Ошибка 'order by': значение числа должно быть между 1 и " + SelectResult.GetAttributeCount() + "\n";
                }
            }
        }

        void AnalyzeDot(ITree node, ref string errStr)
        {
            if (IsTableDeclared(node.GetChild(0)))
            {
                if (!IsFieldExist(node.GetChild(1), node.GetChild(0)))
                {
                    errStr += "Ошибка: поля \"" +
                              node.GetChild(1).Text +
                              "\" нет в таблице \"" +
                              node.GetChild(0).Text
                              + "\"\n";
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
                                          "\" нет в таблице \"" +
                                          node.GetChild(0).Text
                                          + "\"\n";
                                break;
                            }
                            if (node.GetChild(1).Text.Equals("*"))
                            {
                                errStr += "Ошибка 'where': выборка содержит более одного столбца \n";
                                break;
                            }
                            Field f = FromResult.Data.Find(o => o.Name.Equals(node.GetChild(1).Text)
                                                             && o.StoredTableName.Equals(node.GetChild(0).Text));
                            if (f == null)
                            {
                                errStr += "Ошибка: поле \"" +
                                          node.GetChild(1).Text +
                                          "\" из таблицы \"" +
                                          node.GetChild(0).Text
                                          + "\" не существует в данном контексте\n";
                                break;
                            }
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
                        case 20://NUMBER
                            {
                                type = "NUMBER";
                                break;
                            }
                        case 21://FIELD
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
                        case 22://TEXT
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
        #endregion









        #region Interpreter

        internal void StartInterpret()
        {
            if (!interpret)
            {
                FromResult = new Table();
                for (int i = 0; i < tree.ChildCount; i++)
                {
                    InterpretNode(tree.GetChild(i));
                }
            }
            interpret = true;
        }

        void InterpretNode(ITree node)
        {
            switch (node.Text)
            {
                case "from":
                case "TABLES":
                    {
                        for (int i = 0; i < node.ChildCount; i++)
                        {
                            InterpretNode(node.GetChild(i));
                        }
                        break;
                    }
                case "as":
                    {
                        InterpretAs(node);
                        break;
                    }
                case "BLOCK":
                    {
                        BlockToken blockToken = subquery.Dequeue();
                        blockToken.StartInterpret();
                        FromResult = Table.Mult(FromResult, blockToken.SelectResult);

                        break;
                    }
                case "where":
                    {
                        InterpretWhere(node.GetChild(0));
                        break;
                    }
                case "select":
                    {
                        InterpretSelect();
                        break;
                    }
                case "order by":
                    {
                        InterpretOrderBy(node.GetChild(0));
                        break;
                    }
                default:
                    if (node.Parent.Text == "TABLES")
                    {
                        InterpretTable(node);
                    }

                    break;
            }
        }

        void InterpretFrom(ITree node, ref string errStr)////
        {
            Table table = new Table();
            for (int i = 0; i < node.ChildCount; i++)
            {
                //table = Table.Mult(table, );
            }
        }

        void InterpretTable(ITree node)
        {
            FromResult = Table.Mult(FromResult, usingTables[level].Find(o => o._name == node.Text));
        }

        void InterpretAs(ITree node)
        {
            InterpretNode(node.GetChild(0));
        }

        void InterpretSelect()
        {
            for (int i = 0; i < FromResult.GetTablePower(); i++)
            {
                List<Field_Value> cortege = new List<Field_Value>();
                for (int j = 0; j < SelectResult.Data.Count; j++)
                {
                    Field_Value f_v = FromResult.FieldsValues[i]
                        .Find(o => o.field == SelectResult.Data[j]);
                    cortege.Add(f_v);
                }
                SelectResult.FieldsValues.Add(cortege);
            }
        }

        void InterpretOrderBy(ITree node)
        {
            List<int> sortColumn = new List<int>();
            for (int i = 0; i < node.ChildCount; i++)
            {
                sortColumn.Add(Convert.ToInt32(node.GetChild(i).Text) - 1);
            }

            SelectResult.FieldsValues.Sort(
                            delegate (List<Field_Value> l1, List<Field_Value> l2)
                        {

                            for (int i = 0; i < sortColumn.Count; i++)
                            {
                                if (l1[sortColumn[i]].field.Type == "TEXT")
                                {
                                    string left = l1[sortColumn[i]].value.ToString();
                                    string right = l2[sortColumn[i]].value.ToString();
                                    if (left == null
                                        && right == null) return 0;
                                    else if (left == null) return -1;
                                    else if (right == null) return 1;
                                    else
                                    {
                                        int comp = left.CompareTo(right);
                                        if (comp != 0) return comp;

                                    }
                                }
                                else
                                {
                                    double left = Convert.ToDouble(l1[sortColumn[i]].value);
                                    double right = Convert.ToDouble(l2[sortColumn[i]].value);
                                    int comp = left.CompareTo(right);
                                    if (comp != 0) return comp;
                                }
                            }
                            return 0;
                        });


        }

        void InterpretWhere(ITree node)
        {
            for (int i = 0; i < FromResult.GetTablePower(); i++)
            {
                if (!Condition(node, FromResult.FieldsValues[i]))
                {
                    FromResult.FieldsValues.RemoveAt(i);
                    i--;
                }
            }
        }
        bool Condition(ITree node, List<Field_Value> f)
        {

            switch (node.Text)
            {
                case "and":
                    {
                        return And(node, f);
                    }
                case "or":
                    {
                        return Or(node, f);
                    }
                default:
                    {
                        return Compare(node, f);
                    }
            }
        }

        bool And(ITree node, List<Field_Value> f)
        {
            for (int i = 0; i < node.ChildCount; i++)
            {
                if (!Condition(node.GetChild(i), f))
                {
                    return false;
                }
            }
            return true;
        }

        bool Or(ITree node, List<Field_Value> f)
        {
            for (int i = 0; i < node.ChildCount; i++)
            {
                if (Condition(node.GetChild(i), f))
                {
                    return true;
                }
            }
            return false;
        }

        bool Compare(ITree node, List<Field_Value> f)
        {
            bool flag = true;
            object[] operands = new object[2];

            operands[0] = GetOperand(f, node.GetChild(0));
            operands[1] = GetOperand(f, node.GetChild(1));
            
            switch (node.Text)
            {
                case "<":
                    {
                        if (operands[0] is Double)
                        {
                            if (Convert.ToDouble(operands[0]).CompareTo(Convert.ToDouble(operands[1])) != -1)
                            {
                                flag = false;
                            }
                        }
                        else
                        {
                            if (Convert.ToString(operands[0]).CompareTo(Convert.ToString(operands[1])) != -1)
                            {
                                flag = false;
                            }
                        }
                        break;
                    }
                case ">":
                    {
                        if (operands[0] is Double)
                        {
                            if (Convert.ToDouble(operands[0]).CompareTo(Convert.ToDouble(operands[1])) != 1)
                            {
                                flag = false;
                            }
                        }
                        else
                        {
                            if (Convert.ToString(operands[0]).CompareTo(Convert.ToString(operands[1])) != 1)
                            {
                                flag = false;
                            }
                        }
                        break;
                    }
                case "==":
                    {
                        if (operands[0] is Double)
                        {
                            if (Convert.ToDouble(operands[0]).CompareTo(Convert.ToDouble(operands[1])) != 0)
                            {
                                flag = false;
                            }
                        }
                        else
                        {
                            if (Convert.ToString(operands[0]).CompareTo(Convert.ToString(operands[1])) != 0)
                            {
                                flag = false;
                            }
                        }
                        break;
                    }
                case ">=":
                    {
                        if (operands[0] is Double)
                        {
                            if (Convert.ToDouble(operands[0]).CompareTo(Convert.ToDouble(operands[1])) < 0)
                            {
                                flag = false;
                            }
                        }
                        else
                        {
                            if (Convert.ToString(operands[0]).CompareTo(Convert.ToString(operands[1])) < 0)
                            {
                                flag = false;
                            }
                        }
                        break;
                    }
                case "<=":
                    {
                        if (operands[0] is Double)
                        {
                            if (Convert.ToDouble(operands[0]).CompareTo(Convert.ToDouble(operands[1])) > 0)
                            {
                                flag = false;
                            }
                        }
                        else
                        {
                            if (Convert.ToString(operands[0]).CompareTo(Convert.ToString(operands[1])) > 0)
                            {
                                flag = false;
                            }
                        }
                        break;
                    }
                case "<>":
                    {
                        if (operands[0] is Double)
                        {
                            if (Convert.ToDouble(operands[0]).CompareTo(Convert.ToDouble(operands[1])) == 0)
                            {
                                flag = false;
                            }
                        }
                        else
                        {
                            if (Convert.ToString(operands[0]).CompareTo(Convert.ToString(operands[1])) == 0)
                            {
                                flag = false;
                            }
                        }
                        break;
                    }
                default:
                    break;
            }

            return flag;
        }

        object GetOperand(ITree node)
        {
            switch (node.Text)
            {

                default:
                    switch (node.Type)
                    {
                        case 16://NUMBER
                            {
                                return Convert.ToDouble(node.Text);
                            }
                        case 18://TEXT
                            {
                                return Convert.ToString(node.Text);
                            }
                        default:
                            break;
                    }
                    break;
            }
            return null;
        }

        object GetOperand(List<Field_Value> cortege, ITree node)
        {
            Field_Value f = new Field_Value();
            switch (node.Text)
            {
                case "BLOCK":
                    {
                        BlockToken b = subquery.Peek();
                        b.StartInterpret();
                        if (b.SelectResult.GetTablePower() > 1)
                        {
                            errStr += "Ошибка 'where' 'select': выборка содержит более одного кортежа \n";
                            break;
                        }
                        if (b.SelectResult.Data[0].Type == "TEXT")
                        {
                            return Convert.ToString(b.SelectResult.FieldsValues[0][0].value);
                        }
                        else
                        {
                            return Convert.ToDouble(b.SelectResult.FieldsValues[0][0].value);
                        }
                    }
                case ".":
                    {
                        f = cortege.Find(o => o.field.StoredTableName == node.GetChild(0).Text
                                        && o.field.Name == node.GetChild(1).Text);
                        if (f.field.Type == "TEXT")
                        {
                            return Convert.ToString(f.value);
                        }
                        else
                        {
                            return Convert.ToDouble(f.value);
                        }
                    }
                default:
                    {
                        switch (node.Type)
                        {
                            case 20://NUMBER
                                {
                                    return Convert.ToDouble(node.Text);
                                }
                            case 21:
                                {
                                    f = cortege.Find(o => o.field.Name == node.Text);
                                    if (f.field.Type == "TEXT")
                                    {
                                        return Convert.ToString(f.value);
                                    }
                                    else
                                    {
                                        return Convert.ToDouble(f.value);
                                    }
                                }
                            case 22://TEXT
                                {
                                    return Convert.ToString(node.Text.Trim('\"'));
                                }
                            default:
                                break;
                        }
                        break;
                    }
            }
            return null;
        }
        #endregion
    }
}
