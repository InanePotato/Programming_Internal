using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Internal
{
    internal class Get_LiveVars
    {
        //creates a Constructor with 3 overloads | name, type, value
        public Get_LiveVars(string name, string type, string value)
        {
            Name = name;
            Type = type;
            Value = value;
        }

        //set properties so we can access the name, type, and value values
        public string Name { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
    }
}
