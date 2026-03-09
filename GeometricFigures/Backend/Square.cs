namespace GeometricFigures.Backend
{
    public class Square : GeometricFigure
    {
        private double _a;
        public double A { get => _a; set => _a = ValidateA(value); }

        public Square(string name, double a)
        {
            Name = name;
            A = a;
        }

        public override double GetArea() => Math.Pow(A, 2);
        public override double GetPerimiter() => 4 * A;
        protected double ValidateA(double a) => a < 0 ? 0 : a;
    }
}