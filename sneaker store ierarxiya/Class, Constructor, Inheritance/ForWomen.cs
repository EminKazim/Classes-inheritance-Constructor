using System;
using System.Collections.Generic;
using System.Text;

namespace Class__Constructor__Inheritance
{
    class ForWomen:Product
    {
        string women;

        public ForWomen(string productCategory, int size, string productColour, string women) : base(productCategory, size, productColour)
        {
            this.women = women;
        }

        public string ForWoman()
        {
            return $"{Shoes()} " +
                $"   Gender: {this.women}";
        }

    }
}

