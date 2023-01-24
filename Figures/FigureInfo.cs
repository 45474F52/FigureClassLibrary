using Figures.FiguresList;

namespace Figures
{
    /// <summary>
    /// Класс, предоставляющий методы для взаимодействия с фигурами. Этот класс не наследуется
    /// </summary>
    /// <typeparam name="TFigure">Фигура, наследующая класс <see cref="FigureBase"/></typeparam>
    public sealed class FigureInfo<TFigure> where TFigure : FigureBase, new()
    {
        private readonly FigureBase _figure;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="FigureInfo{TFigure}"/> и инициализирует фигуру <typeparamref name="TFigure"/>
        /// </summary>
        /// <param name="parameters">Параметры для инициализации фигуры</param>
        public FigureInfo(object parameters)
        {
            _figure = new TFigure();
            _figure.Initialize(parameters);
        }

        /// <summary>
        /// Возвращает площадь фигуры
        /// </summary>
        /// <returns>Возвращает площадь фигуры путём вызова метода <see cref="FigureBase.GetArea"/></returns>
        public double GetFigureArea() => _figure.GetArea();
    }
}