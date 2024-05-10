using System;

/// <summary>
/// Представление полёта.
/// </summary>
class Flight
{
    /// <summary>
    /// Пункт отправления.
    /// </summary>
    string _departurePoint;

    /// <summary>
    /// Пункт назначения.
    /// </summary>
    string _destination;

    /// <summary>
    /// Время полёта в минутах.
    /// </summary>
    int _flightTimeMinutes;

    /// <summary>
    /// Возвращает и изменяет пункт отправления. Количество символов больше нуля.
    /// </summary>
    public string DeparturePoint
    {
        get { return _departurePoint; }
        set
        {
            if (value.Length == 0) throw new ArgumentException();
            _departurePoint = value;
        }
    }
    /// <summary>
    /// Возвращает и изменяет пункт назначения. Количество символов больше нуля.
    /// </summary>
    public string Destination
    {
        get { return _destination; }
        set
        {
            if (value.Length == 0) throw new ArgumentException();
            _destination = value;
        }
    }
    /// <summary>
    /// Возвращает и изменяет время полёта в минутах. Значение не меньше единицы.
    /// </summary>
    public int FlightTimeMinutes
    {
        get { return _flightTimeMinutes; }
        set
        {
            if (value < 1) throw new ArgumentException();
            _flightTimeMinutes = value;
        }
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Flight"/>.
    /// </summary>
    public Flight()
    {
        DeparturePoint = "Tomsk";
        Destination = "Moscow";
        FlightTimeMinutes = 265;
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Flight"/>.
    /// </summary>
    /// <param name="departurePoint">Пункт отправления.</param>
    /// <param name="destination">Пункт назначения.</param>
    /// <param name="flightTimeMinutes">Время полёта в минутах.</param>
    public Flight(string departurePoint, string destination, int flightTimeMinutes)
    {
        DeparturePoint = departurePoint;
        Destination = destination;
        FlightTimeMinutes = flightTimeMinutes;
    }
}