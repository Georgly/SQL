using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathLang
{
    public class Field
    {
        private string name;
        private string type;
        private string storedTableName;

        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public string StoredTableName { get => storedTableName; set => storedTableName = value; }

        public Field()
        {
            Name = "";
            Type = "";
            //_value = new object();
            //_storedTableName = "";
        }
    }
}
