// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace EnumTest
{
    class Program
    {
        enum Item
        {
            Coffee=1,
            Tea=2,
            IceCream=3,
            Bread=4
        }
        static void Main(string[] args)
        {
            Order(Item.Tea, 3);
        }
        static void Order(Item item, int qty)
        {
            switch(item)
            {
                case Item.Coffee:
                    break;
                case Item.Tea:
                    break;
                case Item.IceCream:
                    break;
                case Item.Bread:
                    break;
            }
        }
    }
}