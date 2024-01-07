namespace Builder
{
    class PizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza;

        private PizzaBuilder()
        {
            _pizza = new Pizza();
        }

        public static PizzaBuilder Configure()
        {
            return new PizzaBuilder();
        }

        public PizzaBuilder AddDough()
        {
            this._pizza.AddDough("Wheat");
            return this;
        }

        public PizzaBuilder AddSauce(string sauceName)
        {
            this._pizza.AddSauce(sauceName);
            return this;
        }

        public PizzaBuilder AddTopping(string toppingName)
        {
            this._pizza.AddTopping(toppingName);
            return this;
        }

        public Pizza Build()
        {
            return this._pizza;
        }

        public Pizza GetValue()
        {
            throw new NotImplementedException();
        }
    }
}