using System;
using System.Collections.Generic;
using System.Text;

namespace Class__Constructor__Inheritance
{
    class Product
    {
        string produtctCategory;
        int size;
        string productColour;

        public Product(string productCategory, int size, string productColour)
        {
            this.produtctCategory = productCategory;
            this.size = size;
            this.productColour = productColour;
        }
        public string Shoes()
        {
            return $"    Product: {this.produtctCategory}" +
                $"       Size:  {this.size} " +
                $"       Colour: {this.productColour} ";
        } 
           
    }


}
