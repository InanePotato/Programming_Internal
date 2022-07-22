using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Internal
{
    internal class Get_LiveVars
    {
        public Get_LiveVars(string name, string type, string value)
        {
            Name = name;
            Type = type;
            Value = value;
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
    }
}
