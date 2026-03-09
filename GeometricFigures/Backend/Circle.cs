namespace GeometricFigures.Backend
{
    public class Circle : GeometricFigure
    {
        private double _r;
        public double R { get => _r; set => _r = ValidateR(value); }

        public Circle(string name, double r)
        {
            Name = name;
            R = r;
        }

        public override double GetArea() => Math.PI * Math.Pow(R, 2);
        public override double GetPerimiter() => 2 * Math.PI * R;
        private double ValidateR(double r) => r < 0 ? 0 : r;
    }
}
