using Contract.Attributes;
using Contract.Enums;
using Models.Extensions;
using System;
using System.Collections.Generic;
namespace Models.Entities
{
    public class Card
    {
        public int Id { get; set; }
        public SymboEnum Symbol { get; set; }

        public ValueEnum Value { get; set; }
        public string Class
        {
            get
            {
                return Value.GetAttribute<DescriptionAttribute>().Name + " " + Symbol.GetAttribute<DescriptionAttribute>().Name;
            }
        }
        public string Title
        {
            get
            {
                return Value.GetAttribute<DescriptionAttribute>().Name.ToUpper();
            }
        }
        public List<int> Point { get; set; }

        public string Sign
        {
            get
            {
                return Symbol.GetAttribute<SignAttribute>().Name;
            }

        }

    }


}
