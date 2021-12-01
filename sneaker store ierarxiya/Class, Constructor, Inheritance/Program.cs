using System;

namespace Class__Constructor__Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            
            forMen shirt1 = new forMen("Nike", 39, "Black", "For Men");
            Console.WriteLine(shirt1.ForMan());
            ForWomen sweetshir1 = new ForWomen("Adidas", 32 , "Pink", "For Women");
            Console.WriteLine(sweetshir1.ForWoman());

        }
    }
}
