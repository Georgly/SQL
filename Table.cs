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
        private List<Field> data;
        private List<List<Field_Value>> fieldsValues = new List<List<Field_Value>>();

        public List<Field> Data { get => data; set => data = value; }
        public List<List<Field_Value>> FieldsValues { get => fieldsValues; set => fieldsValues = value; }

        public Table()
        {
            _name = "";
            Data = new List<Field>();
        }

        public Table(string name)
        {
            _name = name;
            Data = new List<Field>();
        }

        public void InitializeFields(string[] fields)
        {
            int step = fields.Length / 2;
            for (int i = 0; i < step; i++)
            {
                //SetType(ref fields[i + step]);
                Field field = new Field
                {
                    Name = fields[i],
                    Type = fields[i + step],
                    StoredTableName = _name
                };
                Data.Add(field);
            }
        }

        public void AddValues(string[] fieldValues)
        {
            List<Field_Value> cortege = new List<Field_Value>();
            for (int i = 0; i < Data.Count; i++)
            {
                Field_Value field_value = new Field_Value
                {
                    field = Data[i],
                    value = fieldValues[i]
                };
                cortege.Add(field_value);
            }
            FieldsValues.Add(cortege);
        }

        public void PrintTable()
        {
            string tableStr = "";
            for (int i = 0; i < FieldsValues.Count; i++)
            {
                //tableStr += i;
                for (int j = 0; j < FieldsValues[i].Count; j++)
                {
                    tableStr += FieldsValues[i][j].value.ToString() + " ";
                }
                tableStr += "\n";
            }

            Console.WriteLine(tableStr);
        }

        public int GetAttributeCount()
        {
            return Data.Count;
        }

        public int TablePower()
        {
            return FieldsValues.Count;
        }

        public static Table Mult(Table table1, Table table2)
        {
            Table result = new Table(table1._name + "_" + table2._name);
            result.Data.AddRange(table1.Data);
            result.Data.AddRange(table2.Data);
            for (int i = 0; i < Math.Max(table1.FieldsValues.Count, 1); i++)
            {
                for (int j = 0; j < Math.Max(table2.FieldsValues.Count, 1); j++)
                {
                    List<Field_Value> cortege = new List<Field_Value>();
                    for (int k = 0; k < result.Data.Count; k++)
                    {
                        for (; k < table1.Data.Count; k++)
                        {
                            Field_Value field_value = new Field_Value
                            {
                                field = result.Data[k],
                                value = table1.FieldsValues[i][k].value
                            };
                            cortege.Add(field_value);
                        }
                        for (; k < result.Data.Count; k++)
                        {
                            Field_Value field_value = new Field_Value
                            {
                                field = result.Data[k],
                                value = table2.FieldsValues[j][k - table1.Data.Count].value
                            };
                            cortege.Add(field_value);
                        }
                    }
                    result.FieldsValues.Add(cortege);
                }
            }

            return result;
        }
    }
}
