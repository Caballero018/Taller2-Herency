namespace GeometricFigures.Backend
{
    public class Rhombus : Square
    {
        private double _d1, _d2;
        public double D1 { get => _d1; set => _d1 = ValidateD1(value); }
        public double D2 { get => _d2; set => _d2 = ValidateD2(value); }

        public Rhombus(string name, double a, double d1, double d2) : base(name, a)
        {
            D1 = d1;
            D2 = d2;
        }

        public override double GetArea() => (D1 * D2) / 2;
        private double ValidateD1(double d) => d < 0 ? 0 : d;
        private double ValidateD2(double d) => d < 0 ? 0 : d;
    }
}