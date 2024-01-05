namespace Classes
{
    class Rectangle
    {
        int Width;
        int Height;

        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public int CalculateArea()
        {
            return Width * Height;
        }

        public void DummyMethod()
        {
            Console.WriteLine($"Width: {Width}, Height: {Height}");
        }
    }
}