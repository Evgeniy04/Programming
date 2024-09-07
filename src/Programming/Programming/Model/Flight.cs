using System;

/// <summary>
/// ������������� �����.
/// </summary>
class Flight
{
    /// <summary>
    /// ����� �����������.
    /// </summary>
    string _departurePoint;

    /// <summary>
    /// ����� ����������.
    /// </summary>
    string _destination;

    /// <summary>
    /// ����� ����� � �������.
    /// </summary>
    int _flightTimeMinutes;

    /// <summary>
    /// ���������� � �������� ����� �����������. ���������� �������� ������ ����.
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
    /// ���������� � �������� ����� ����������. ���������� �������� ������ ����.
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
    /// ���������� � �������� ����� ����� � �������. �������� �� ������ �������.
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
    /// ������ ��������� ������ <see cref="Flight"/>.
    /// </summary>
    public Flight()
    {
        DeparturePoint = "Tomsk";
        Destination = "Moscow";
        FlightTimeMinutes = 265;
    }

    /// <summary>
    /// ������ ��������� ������ <see cref="Flight"/>.
    /// </summary>
    /// <param name="departurePoint">����� �����������.</param>
    /// <param name="destination">����� ����������.</param>
    /// <param name="flightTimeMinutes">����� ����� � �������.</param>
    public Flight(string departurePoint, string destination, int flightTimeMinutes)
    {
        DeparturePoint = departurePoint;
        Destination = destination;
        FlightTimeMinutes = flightTimeMinutes;
    }
}