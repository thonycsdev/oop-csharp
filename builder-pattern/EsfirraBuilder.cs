using Factory;

namespace Builder
{
    class EsfirraBuilder : IEsfirraBuilder
    {
        private Esfirra _esfirra;

        private EsfirraBuilder()
        {
            _esfirra = new Esfirra();
        }
        public static EsfirraBuilder Configure()
        {
            return new EsfirraBuilder();
        }
        public Esfirra Build()
        {
            return this._esfirra;
        }

        public Esfirra GetValue()
        {
            throw new NotImplementedException();
        }

        public EsfirraBuilder AddDough()
        {
            this._esfirra.AddDough("Wheat for Esfirra");
            return this;
        }

        public EsfirraBuilder AddSauce(string sauceName)
        {
            this._esfirra.AddSauce(sauceName);
            return this;
        }

        public EsfirraBuilder AddTopping(string toppingName)
        {
            this._esfirra.AddTopping(toppingName);
            return this;
        }
    }
}