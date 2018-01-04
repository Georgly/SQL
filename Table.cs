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
        int id = 0;

        public string _name;
        public List<Field> _data;
        public Dictionary<int, List<Field_Value>> values = new Dictionary<int, List<Field_Value>>();
        //Dictionary<Field, object> field_value = new Dictionary<Field, object>();

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

        public void AddFields(string[] fields)
        {
            int step = fields.Length / 2;
            for (int i = 0; i < step; i++)//fields.Length; )
            {
                Field field = new Field
                {
                    _name = fields[i],
                    _type = fields[i + step],
                    _storedTableName = _name
                };
                //i += step;
                _data.Add(field);
            }
        }
        public void AddValues(string[] fieldValues)
        {
            id++;
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
            values.Add(id, cortege);
        }

        public void PrintTable()
        {
            string tableStr = "";
            for (int i = 0; i < values.Count; i++)
            {
                tableStr += i;
                for (int j = 0; j < values[i].Count; j++)
                {
                    tableStr += values[i][j].value.ToString();
                }
                tableStr += "\n";
            }

            Console.WriteLine(tableStr);
        }
    }
}
