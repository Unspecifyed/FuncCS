namespace  FuncCS
{
    using static System.Math;

    public record Circle(double Radius)
    {
        public double Circumference
            => PI * 2 * Radius;

        public double Area
        {
            get
            {
                static double Square(double d)
                    => Pow(d, 2);

                return PI * Square(Radius);
            }
        }
    }
}