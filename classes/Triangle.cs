namespace Classes
{
    class Triangle
    {
        private int _base;
        private int _height;

        public Triangle(int triangleBase, int height)
        {
            this._base = triangleBase;
            _height = height;
        }


        public float CalculateArea()
        {
            var area = ((_base * _height) / 2);
            return area;
        }

        public string AsString() => $"Base is {_base}, height is {_height}";
        public override string ToString() => $"Base is {_base}, height is {_height}";
    }
}