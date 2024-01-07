namespace Builder
{
    class Pizza
    {
        private string _dough = String.Empty;
        private string _sauce = String.Empty;
        private string _topping = String.Empty;

        public void AddDough(string dough)
        {
            this._dough = dough;
        }

        public void AddSauce(string sauce)
        {
            this._sauce = sauce;
        }

        public void AddTopping(string topping)
        {
            this._topping = topping;
        }

        public override string ToString()
        {
            return "Pizza with " + this._dough + " dough, " + this._sauce + " sauce and " + this._topping + " topping.";
        }
    }
}