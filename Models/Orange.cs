namespace ConsoleApp37.Models
{
    internal class Orange : Fruit
    {
        public int VitaminC;

        public Orange(int vitaminC, decimal price, string sort) : base(price, sort)
        {
            VitaminC = vitaminC;
        }

        public override void Taste()
        {
            Console.WriteLine("Cox turs olur");
        }
    }
}
