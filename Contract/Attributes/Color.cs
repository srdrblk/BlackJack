using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Contract.Attributes
{
    class ColorAttribute : Attribute
    {
        public string Name { get; private set; }

        public ColorAttribute(string name)
        {
            this.Name = name;
        }
    }
}
