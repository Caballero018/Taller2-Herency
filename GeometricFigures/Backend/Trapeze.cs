namespace GeometricFigures.Backend
{
    public class Trapeze : Triangle
    {
        private double _d;
        public double D { get => _d; set => _d = ValidateD(value); }

        public Trapeze(string name, double a, double b, double c, double d, double h) : base(name, a, b, c, h)
        {
            D = d;
        }

        public override double GetArea() => ((B + D) * H) / 2;
        public override double GetPerimiter() => A + B + C + D;
        private double ValidateD(double d) => d < 0 ? 0 : d;
    }
}
