namespace GeometricFigures.Backend
{
    public class Parallelogram : Rectangle
    {
        private double _h;
        public double H { get => _h; set => _h = ValidateH(value); }

        public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
        {
            H = h;
        }

        public override double GetArea() => B * H;
        private double ValidateH(double h) => h < 0 ? 0 : h;
    }
}