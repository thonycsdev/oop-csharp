namespace Factory
{
    class Esfirra : Pasta
    {
        public override void SetTimeInTheOven()
        {
            this._timeInTheOven = 10;
        }
        public override string Describe()
        {
            string sauces = this._sauce.Select(sauce => sauce).Aggregate((s1, s2) => s1 + " and " + s2);
            string doughs = this._dough.Select(dough => dough).Aggregate((d1, d2) => d1 + " and " + d2);
            string toppings = this._topping.Select(topping => topping).Aggregate((t1, t2) => t1 + " and " + t2);
            return "Esfirra with " + doughs + " dough, " + sauces + " sauce and " + toppings + " topping.";
        }
    }
}