using System;
using System.Collections.Generic;
using System.Text;

namespace Contract.Attributes
{
    public class SignAttribute : Attribute
    {
        public string Name { get; private set; }

        public SignAttribute(string name)
        {
            this.Name = name;
        }
    }
}
