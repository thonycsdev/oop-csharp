namespace Pizzaria
{
    abstract class Pizza
    {
        public int Id { get; private set; }
        public virtual string _Dough { get; set; }
        public virtual List<string> _Sauces { get; set; }
        public virtual List<string> _Toppings { get; set; }
        public virtual int TimeInTheOven { get; set; }


        public virtual void PackPizza()
        {
            Console.WriteLine($"This Pizza is now Packed");
        }

    }
}