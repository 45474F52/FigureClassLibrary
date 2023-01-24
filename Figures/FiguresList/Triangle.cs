namespace Figures.FiguresList
{
    public class Triangle : FigureBase
    {
        public double[] Sides { get; private set; } = new double[3];

        /// <summary>
        /// Возвращает площадь треугольника
        /// </summary>
        /// <returns>Возвращает площадь треугольника значением типа <see cref="double"/></returns>
        public override double GetArea()
        {
            double p = Sides.Sum() / 2;

            return Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p - Sides[2]));
        }

        /// <summary>
        /// Инициализирует треугольник с переданными сторонами
        /// </summary>
        /// <param name="parameters">Стороны треугольника</param>
        /// <exception cref="ArgumentException"></exception>
        public override void Initialize(object parameters)
        {
            if (parameters is double[] sides)
            {
                if (sides.Length > 0)
                {
                    Sides = sides;

                    CheckExistence();
                }

                base.Initialize(parameters);
            }
            else
                throw new ArgumentException("Нужно передать значение сторон треугольника", nameof(parameters));
        }

        /// <summary>
        /// Проверяет возможность существования треугольника
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        protected void CheckExistence()
        {
            double max = Sides.Max();

            if (Sides.Where(s => s != max).Sum() <= max)
                throw new ArgumentException("Треугольника с такими сторонами не существует", nameof(Sides));
        }

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        /// <returns>Возвращает <see langword="true"/>, если треугольник прямоугольный, иначе <see langword="false"/></returns>
        public bool IsRightAngled()
        {
            double hypotenuse = Sides.Max();

            if (Sides.Where(s => s == hypotenuse).Count() == 1)
            {
                double[] cathets = Sides.Where(s => s != hypotenuse).ToArray();

                return (hypotenuse * hypotenuse) == cathets[0] * cathets[0] + cathets[1] * cathets[1];
            }
            else
                return false;
        }
    }
}