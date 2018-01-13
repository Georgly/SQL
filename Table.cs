using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathLang
{
    public struct Field_Value
    {
        public Field field;
        public object value;
    }

    public class Table
    {
        public string _name;
        public List<Field> _data;
        public List<List<Field_Value>> values = new List<List<Field_Value>>();

        public Table()
        {
            _name = "";
            _data = new List<Field>();
        }

        public Table(string name)
        {
            _name = name;
            _data = new List<Field>();
        }

        public void InitializeFields(string[] fields)
        {
            int step = fields.Length / 2;
            for (int i = 0; i < step; i++)
            {
                SetType(ref fields[i + step]);
                Field field = new Field
                {
                    _name = fields[i],
                    _type = fields[i + step],
                    _storedTableName = _name
                };
                _data.Add(field);
            }
        }
        void SetType(ref string dataBaseType)
        {
            switch (dataBaseType)
            {
                case "int":
                    {
                        dataBaseType = "System.Int32";
                        break;
                    }
                case "double":
                    {
                        dataBaseType = "System.Double";
                        break;
                    }
                case "string":
                    {
                        dataBaseType = "System.String";
                        break;
                    }
                case "char":
                    {
                        dataBaseType = "System.Char";
                        break;
                    }
                default:
                    break;
            }
        }

        public void AddValues(string[] fieldValues)
        {
            List<Field_Value> cortege = new List<Field_Value>();
            for (int i = 0; i < _data.Count; i++)
            {
                Field_Value field_value = new Field_Value
                {
                    field = _data[i],
                    value = fieldValues[i]
                };
                cortege.Add(field_value);
            }
            values.Add(cortege);
        }

        public void PrintTable()
        {
            string tableStr = "";
            for (int i = 0; i < values.Count; i++)
            {
                //tableStr += i;
                for (int j = 0; j < values[i].Count; j++)
                {
                    tableStr += values[i][j].value.ToString() + " ";
                }
                tableStr += "\n";
            }

            Console.WriteLine(tableStr);
        }

        public int GetRang()
        {
            return _data.Count;
        }

        public static Table Mult(Table table1, Table table2)
        {
            Table result = new Table(table1._name + "_" + table2._name);
            result._data.AddRange(table1._data);
            result._data.AddRange(table2._data);
            for (int i = 0; i < Math.Max(table1.values.Count, 1); i++)
            {
                for (int j = 0; j < Math.Max(table2.values.Count, 1); j++)
                {
                    List<Field_Value> cortege = new List<Field_Value>();
                    for (int k = 0; k < result._data.Count; k++)
                    {
                        for (; k < table1._data.Count; k++)
                        {
                            Field_Value field_value = new Field_Value
                            {
                                field = result._data[k],
                                value = table1.values[i][k].value
                            };
                            cortege.Add(field_value);
                        }
                        for (; k < result._data.Count; k++)
                        {
                            Field_Value field_value = new Field_Value
                            {
                                field = result._data[k],
                                value = table2.values[j][k - table1._data.Count].value
                            };
                            cortege.Add(field_value);
                        }
                    }
                    result.values.Add(cortege);
                }
            }

            return result;
        }
    }
}
