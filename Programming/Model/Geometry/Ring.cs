using System;

namespace Programming.Model
{
    /// <summary>
    /// Представляет кольцо с заданным внутренним и внешним радиусом.
    /// </summary>
    class Ring
    {
        /// <summary>
        /// Центр кольца.
        /// </summary>
        public Point2D Center { get; }
        /// <summary>
        /// Внутренний радиус кольца.
        /// </summary>
        double _internalRadius;
        /// <summary>
        /// Внешний радиус кольца.
        /// </summary>
        double _externalRadius;

        /// <summary>
        /// Возвращает и изменяет внутренний радиус кольца. Внутренний радиус должен быть положителен, и меньше или равен внешнего радиуса.
        /// </summary>
        public double InternalRadius
        {
            get { return _internalRadius; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                if (value > _externalRadius) throw new ArgumentException("The inner radius cannot be larger than the outer radius.");
                _internalRadius = value;
            }
        }
        /// <summary>
        /// Возвращает и изменяет внешний радиус кольца. Внешний радиус должен быть положителен, и больше или равен внутреннего радиуса.
        /// </summary>
        public double ExternalRadius
        {
            get { return _externalRadius; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                if (value < _internalRadius) throw new ArgumentException("The external radius cannot be smaller than the inner radius.");
                _externalRadius = value;
            }
        }
        /// <summary>
        /// Возвращает площадь кольца.
        /// </summary>
        public double Area => Math.PI * Math.Pow(_externalRadius, 2) - Math.PI * Math.Pow(_internalRadius, 2);

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Ring"/>.
        /// </summary>
        /// <param name="internalRadius">Внутренний радиус кольца.</param>
        /// <param name="externalRadius">Внешний радиус кольца.</param>
        public Ring(double internalRadius, double externalRadius)
        {
            InternalRadius = internalRadius;
            ExternalRadius = externalRadius;
            Center = new Point2D(InternalRadius / 2, ExternalRadius / 2);
        }
    }
}