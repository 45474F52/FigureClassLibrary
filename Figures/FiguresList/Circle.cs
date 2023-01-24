namespace Figures.FiguresList
{
    public class Circle : FigureBase
    {
        private double _radius;
        public double Radius
        {
            get => _radius;
            protected set
            {
                if (value > 0)
                {
                    _radius = value;
                }
            }
        }

        /// <summary>
        /// Возвращает площадь круга
        /// </summary>
        /// <returns>Возвращает площадь круга значением типа <see cref="double"/></returns>
        public override double GetArea()
        {
            return Math.PI * (_radius * _radius);
        }

        /// <summary>
        /// Инициализирует круг с переданным радиусом
        /// </summary>
        /// <param name="parameters">Радиус круга</param>
        /// <exception cref="ArgumentException"></exception>
        public override void Initialize(object parameters)
        {
            if (parameters is double radius)
            {
                Radius = radius;

                base.Initialize(parameters);
            }
            else
                throw new ArgumentException("В конструктор передан не радиус круга с типом double", nameof(parameters));
        }
    }
}