using ConsoleApp37.Models;

namespace ConsoleApp37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple(10, 15, 1000, "Qizil ehmedi");
            Pineapple pineapple = new Pineapple(10, 15, 1000, "Havai ananasi");
            Orange orange = new Orange(15, 1000, "Lenkaraniski portagal");

            Fruit[] Basket = { apple, pineapple, orange };
            foreach (var item in Basket)
            {
                var type = item.GetType();
                Console.WriteLine(type.Name);

                foreach (var i in type.GetFields())
                {
                    
                    Console.WriteLine(i.GetValue(item));    
                }

                //if(item is Apple)
                //{
                //    Apple apple1 = (Apple)item;
                //    apple1.Taste();
                //}
                //if (item is Pineapple)
                //{
                //    Pineapple pineapple1 = (Pineapple)item;
                //    pineapple1.Taste();
                //}
                //if (item is Orange)
                //{
                //    Orange orange1 = (Orange)item;
                //    orange1.Taste();
                //}

            }

            


        }
    }
}