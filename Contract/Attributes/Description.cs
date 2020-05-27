using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Contract.Attributes
{
    public class DescriptionAttribute : Attribute
    {
        public string Name { get; private set; }

        public DescriptionAttribute(string name)
        {
            this.Name = name;
        }
    }
}
