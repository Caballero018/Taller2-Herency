namespace GeometricFigures.Backend
{
    public class Triangle : Rectangle
    {
        private double _c, _h;
        public double C { get => _c; set => _c = ValidateC(value); }
        public double H { get => _h; set => _h = ValidateH(value); }

        public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
        {
            C = c;
            H = h;
        }

        public override double GetArea() => (B * H) / 2;
        public override double GetPerimiter() => A + B + C;
        private double ValidateC(double c) => c < 0 ? 0 : c;
        private double ValidateH(double h) => h < 0 ? 0 : h;
    }
}