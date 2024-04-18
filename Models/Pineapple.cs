namespace ConsoleApp37.Models
{
    internal class Pineapple : Fruit
    {
        int VitaminE;
        public int VitaminD;

        public Pineapple(int vitaminE, int vitaminD, decimal price, string sort) : base(price, sort)
        {
            VitaminE = vitaminE;
            VitaminD = vitaminD;
        }

        public override void Taste()
        {
            Console.WriteLine("Turs olur");
        }
    }
}
