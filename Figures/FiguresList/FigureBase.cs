namespace Figures.FiguresList
{
    /// <summary>
    /// Представляет собой базовый класс для определения фигур
    /// </summary>
    public abstract class FigureBase
    {
        /// <summary>
        /// Инициализирована ли фигура
        /// </summary>
        protected bool _initialized;

        /// <summary>
        /// Инициализирует фигуру переданными параметрами
        /// </summary>
        /// <param name="parameters">Параметры для фигуры (длины сторон / радиус...)</param>
        public virtual void Initialize(object parameters) => _initialized = true;

        /// <summary>
        /// Возвращает площадь фигуры
        /// </summary>
        /// <returns>Возвращает площадь фигуры значением типа <see cref="double"/></returns>
        public abstract double GetArea();
    }
}