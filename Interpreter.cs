using System;
using System.Collections.Generic;
using System.IO;
using Antlr.Runtime.Tree;
using System.Linq;
using System.Text;
using System.Globalization;
using Antlr.Runtime;

namespace MathLang
{
    public struct ExistTableStruct
    {
        public Table table;
        public int level;
    }

    public class Interpreter
    {
        ITree tree;
        int level = 0;
        Dictionary<string, Table> tables;
        Dictionary<int, List<Table>> usingTables;
        Queue<BlockToken> query = new Queue<BlockToken>();

        public Interpreter(ITree tree)
        {
            this.tree = tree;
            tables = new Dictionary<string, Table>();
            usingTables = new Dictionary<int, List<Table>>();
        }

        public void StartAnalyze()
        {
            string errStr = "";
            for (int i = 0; i < tree.ChildCount; i++)
            {
                AnalyzeNode(tree.GetChild(i), ref errStr);
            }
            Console.WriteLine(errStr + "Анализ завершён.");
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
                        query.Enqueue(block);
                        level--;
                        break;
                    }

                    //case "from":
                    //case "select":
                    //case "TABLES":
                    //case "FIELDS":
                    //    {
                    //        for (int i = 0; i < node.ChildCount; i++)
                    //        {
                    //            AnalyzeNode(node.GetChild(i), ref errStr);
                    //        }
                    //        break;
                    //    }
                    //case "where":
                    //    {
                    //        for (int i = 0; i < node.ChildCount; i++)
                    //        {
                    //            AnalyzeNode(node.GetChild(i), ref errStr);
                    //        }
                    //        break;
                    //    }
                    //case "order by":
                    //    {
                    //        break;
                    //    }
                    //case ".":
                    //    {
                    //        if (IsTableDeclared(node.GetChild(0)))
                    //        {
                    //            if (!IsFieldExist(node.GetChild(1)))
                    //            {
                    //                errStr += "Ошибка: поля \"" +
                    //                          node.GetChild(1).Text +
                    //                          "\" нет в таблице" +
                    //                          node.GetChild(0).Text
                    //                          + "\n";
                    //            }
                    //        }
                    //        else
                    //        {
                    //            errStr += "Ошибка: таблица \"" +
                    //                      node.GetChild(0).Text +
                    //                      "\" не существует в данном контексте \n";
                    //        }
                    //        break;
                    //    }
                    //case "<":
                    //case ">":
                    //case "==":
                    //case ">=":
                    //case "<=":
                    //case "<>":
                    //    {
                    //        break;
                    //    }
                    //default:
                    //    {
                    //        if (node.Parent.Text == "TABLES")
                    //        {
                    //            AddUsingTable(node.Text);
                    //        }
                    //        if (node.Parent.Text == "FIELDS")
                    //        {
                    //            if (!IsFieldExist(node))
                    //            {
                    //                errStr += "Ошибка: поле \"" +
                    //                      node.Text +
                    //                      "\" не существует в данном контексте \n";
                    //            }
                    //        }
                    //        break;
                    //    }

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

        //----------------------------------------------------
        //____________________________________________________
        public void CreateTable(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);
            try
            {
                string tableNameStr = reader.ReadLine();
                while (tableNameStr != null)
                {
                    Table table = new Table(tableNameStr);
                    FeelTable(tableNameStr, table);
                    tables.Add(tableNameStr, table);
                    tableNameStr = reader.ReadLine();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                reader.Close();
            }
        }

        void FeelTable(string fileName, Table table)
        {
            StreamReader reader = new StreamReader(fileName + ".txt");
            try
            {
                string fileStr = "";
                List<string> arr = new List<string>();
                string[] strArr;
                for (int i = 0; i < 2; i++)
                {
                    fileStr = reader.ReadLine();
                    strArr = fileStr.Split('\t');
                    arr.AddRange(strArr);
                }
                table.InitializeFields(arr.ToArray());
                fileStr = reader.ReadLine();
                while (fileStr != null)
                {
                    arr.Clear();
                    strArr = fileStr.Split('\t');
                    arr.AddRange(strArr);
                    table.AddValues(arr.ToArray());
                    fileStr = reader.ReadLine();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                reader.Close();
            }
        }

    }
}
