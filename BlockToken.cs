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
        Table result = new Table();

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
                        level++;
                        BlockToken block = new BlockToken(node, level, tables, usingTables);
                        block.SemanticAnalization();
                        subquery.Enqueue(block);
                        level--;
                        break;
                    }
                case "from":
                    {
                        for (int i = 0; i < node.ChildCount; i++)
                        {
                            AnalyzeNode(node.GetChild(i), ref errStr);
                        }
                        if (errStr == "")
                        {
                            foreach (Table t in usingTables[level])
                            {
                                result = Table.Mult(result, t);
                            }
                        }
                        break;
                    }
                case "select":
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
                            }
                        }
                        else
                        {
                            errStr += "Ошибка: таблица \"" +
                                      node.GetChild(0).Text +
                                      "\" не существует в данном контексте \n";
                        }
                        break;
                    }
                case "<":
                case ">":
                case "==":
                case ">=":
                case "<=":
                case "<>":
                    {
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
                            }
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
                for (int j = 1; j <= level; j++)
                {
                    for (int i = 0; i < usingTables[j].Count; i++)
                    {
                        for (int k = 0; k < usingTables[j][i]._data.Count; k++)
                        {
                            if (usingTables[j][i]._data[k]._name == node.Text)
                            {
                                return true;
                            }
                        }
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
            tree.SetChild(1, tree.GetChild(2));
            tree.SetChild(2, tmp);
        }



    }
}
