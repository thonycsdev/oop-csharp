
namespace Pizzaria
{
    class ParmeBuilder : IBaseBuilder
    {
        private Pizza _Pizza;

        public ParmeBuilder()
        {
            _Pizza = new Parme();
        }
        public Pizza pizza { get { return _Pizza; } }

        public IBaseBuilder AddSauces(List<string> sauces)
        {
            _Pizza._Sauces.AddRange(sauces);
            return this;
        }

        public IBaseBuilder AddToppings(List<string> toppings)
        {
            _Pizza._Toppings.AddRange(toppings);
            return this;
        }

        public IBaseBuilder ChangeDough(string dough)
        {
            _Pizza._Dough = dough;
            return this;
        }

        public IBaseBuilder SetTimer(int ovenTime)
        {
            _Pizza.TimeInTheOven = ovenTime;
            return this;
        }
    }
}