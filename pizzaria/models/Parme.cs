namespace Pizzaria
{
    class Parme : Pizza
    {
        public override int TimeInTheOven { get; set; }

        public Parme()
        {
            _Sauces = new List<string>() { "Ketchup", "Mustard" };
            _Toppings = new List<string>() { "Calabria", "Cheese" };
            _Dough = "Parme Slim Dough";
            TimeInTheOven = 10;
        }
    }
}