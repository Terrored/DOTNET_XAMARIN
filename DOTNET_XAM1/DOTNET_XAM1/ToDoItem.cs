using System;
using System.Collections.Generic;
using System.Text;

namespace DOTNET_XAM1
{
    public class ToDoItem
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public ToDoItem(string name,string description)
        {
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
