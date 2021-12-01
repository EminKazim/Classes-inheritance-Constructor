using System;
using System.Collections.Generic;
using System.Text;

namespace Class__Constructor__Inheritance
{
    class forMen:Product
    {
        string men;

        public forMen(string productCategory, int size, string productColour, string men): base( productCategory, size , productColour)
        {
            this.men = men;
        }

        public string ForMan()
        {
            return $"{Shoes()} " +
                $"    Gender: {this.men}";
        } 

    }
}
