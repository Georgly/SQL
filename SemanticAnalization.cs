using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System.IO;

namespace MathLang
{
    public struct ExistTableStruct
    {
        public Table table;
        public int level;
    }

    public class SemanticAnalyzer
    {
        List<ExistTableStruct> existTables = new List<ExistTableStruct>();
        Dictionary<string, Table> tables = new Dictionary<string, Table>();
        ITree tree;
        int level = 0;

        public SemanticAnalyzer(ITree tree)
        {
            this.tree = tree;
        }

        public void StartAnalyze()
        {
            //Console.WriteLine(tree.Text);
            //Console.WriteLine(tree.GetChild(0).Text);
            //ITree child = tree.GetChild(0);
            //SwapTreeNode(child);
            string errStr = "";
            for (int i = 0; i < tree.ChildCount; i++)
            {
                /*errStr += */AnalyzeNode(tree.GetChild(i), ref errStr);
            }
            Console.WriteLine(errStr);
        }

        string AnalyzeNode(ITree node, ref string errStr)
        {
            switch (node.Text)
            {
                case "BLOCK":
                    {
                        SwapTreeNode(node);
                        level++;
                        for (int i = 0; i < node.ChildCount; i++)
                        {
                            AnalyzeNode(node.GetChild(i), ref errStr);
                        }
                        level--;
                        break;
                    }
                case "from":
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
                        break;
                    }
                case "group by":
                    {
                        break;
                    }
                case "having":
                    {
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
                            ExistTableStruct table = new ExistTableStruct
                            {
                                table = tables[node.Text],
                                level = level
                            };
                            existTables.Add(table);
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
            for (int i = 0; i < existTables.Count; i++)
            {
                if (existTables[i].level >= level &&
                    existTables[i].table._name == node.Text)
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
                for (int i = 0; i < existTables.Count; i++)
                {
                    if (existTables[i].level < level)
                    {
                        for (int j = 0; j < existTables[i].table._data.Count; j++)
                        {
                            if (existTables[i].table._data[j]._name == node.Text)
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
        
        void SwapTreeNode(ITree parent)
        {
            ITree tmp = parent.GetChild(0);
            parent.SetChild(0, parent.GetChild(1));
            parent.SetChild(1, tmp);
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
                table.AddFields(arr.ToArray());
                arr.Clear();
                fileStr = reader.ReadLine();
                while (fileStr != null)
                {
                    strArr = fileStr.Split('\t');
                    arr.AddRange(strArr);
                    fileStr = reader.ReadLine();
                }
                table.AddValues(arr.ToArray());
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
