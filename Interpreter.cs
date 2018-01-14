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
            }
            return errStr;
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
