namespace Lab1
{
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing shape");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing circle");
        }
    }

    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing rectangle");
        }
    }
}