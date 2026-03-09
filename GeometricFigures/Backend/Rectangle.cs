namespace GeometricFigures.Backend
{
    public class Rectangle : Square
    {
        private double _b;
        public double B { get => _b; set => _b = ValidateB(value); }

        public Rectangle(string name, double a, double b) : base(name, a)
        {
            B = b;
        }

        public override double GetArea() => A * B;
        public override double GetPerimiter() => 2 * (A + B);
        protected double ValidateB(double b) => b < 0 ? 0 : b;
    }
}