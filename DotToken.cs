using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathLang
{
    class DotToken
    {
        ITree tree;
        int level;
        Dictionary<int, List<Table>> usingTables;
        List<Field> field = new List<Field>();
        Table fromResult = new Table();
        Table selectResult = new Table();

        public List<Field> DotField { get => field; set => field = value; }

        public DotToken(ITree tree, int level, Dictionary<int, List<Table>> usingTables, Table fromResult, Table selectResult)
        {
            this.tree = tree;
            this.level = level;
            this.usingTables = new Dictionary<int, List<Table>>();
            foreach (var t in usingTables)
            {
                this.usingTables.Add(t.Key, new List<Table>(t.Value));
            }
            this.fromResult = fromResult;
            this.selectResult = selectResult;
        }

        public void SemanticAnalyze(ref string errStr)
        {
            if (IsTableDeclared(tree.GetChild(0)))
            {
                if (!IsFieldExist(tree.GetChild(1)))
                {
                    errStr += "Ошибка: поля \"" +
                              tree.GetChild(1).Text +
                              "\" нет в таблице" +
                              tree.GetChild(0).Text
                              + "\n";
                    return;
                }
                if (tree.Parent.Text.Equals("FIELDS"))
                {
                    AddField(tree.GetChild(1).Text, tree.GetChild(0).Text);
                }
            }
            else
            {
                errStr += "Ошибка: таблица \"" +
                          tree.GetChild(0).Text +
                          "\" не существует в данном контексте \n";
            }
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
                for (int i = 0; i < fromResult.Data.Count; i++)
                {
                    if (fromResult.Data[i].Name == node.Text)
                    {
                        DotField.Add(fromResult.Data[i]);
                        return true;
                    }
                }

            }
            else
            {
                string tableName = node.Parent.GetChild(0).Text;
                DotField.AddRange(fromResult.Data.FindAll(o => o.StoredTableName.Equals(tableName)));
                return true;
            }
            return false;
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
                List<Field> list = fromResult.Data.FindAll(o => o.StoredTableName.Equals(tableName));
                foreach (Field field in list)
                {
                    if (!selectResult.Data.Contains(field))
                    {
                        selectResult.Data.Add(field);
                    }
                }
            }
        }
    }
}
