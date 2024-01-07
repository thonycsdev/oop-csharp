namespace Factory
{
    abstract class Pasta
    {
        protected List<string> _dough = new List<string>();
        protected List<string> _sauce = new List<string>();
        protected List<string> _topping = new List<string>();
        protected int _timeInTheOven;

        public void AddDough(string dough)
        {
            this._dough.Add(dough);
        }

        public void AddSauce(string sauce)
        {
            this._sauce.Add(sauce);
        }

        public void AddTopping(string topping)
        {
            this._topping.Add(topping);
        }

        public virtual void SetTimeInTheOven()
        {
            this._timeInTheOven = 0;
        }

        public virtual string Describe()
        {
            string sauces = this._sauce.Select(sauce => sauce).Aggregate((s1, s2) => s1 + " and " + s2);
            string doughs = this._dough.Select(dough => dough).Aggregate((d1, d2) => d1 + " and " + d2);
            string toppings = this._topping.Select(topping => topping).Aggregate((t1, t2) => t1 + " and " + t2);
            return "Pizza with " + doughs + " dough, " + sauces + " sauce and " + toppings + " topping.";
        }
    }
}