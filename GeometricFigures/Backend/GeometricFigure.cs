using System;

namespace GeometricFigures.Backend
{
    public abstract class GeometricFigure
    {
        public string Name { get; set; } = string.Empty;

        public abstract double GetArea();
        public abstract double GetPerimiter();

        public override string ToString()
        {
            return string.Format("{0, -15} => Area.....: {1, 15:N5}      Perimiter: {2, 15:N5}", 
                Name, 
                GetArea(), 
                GetPerimiter());
        }
    }
}
