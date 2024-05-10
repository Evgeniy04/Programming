using System;

/// <summary>
/// ������������� ������� ����������.
/// </summary>
class Discipline
{
    /// <summary>
    /// �������� ����������.
    /// </summary>
    string _disciplineName;
    /// <summary>
    /// ������ �� ����������.
    /// </summary>
    int _grade;
    /// <summary>
    /// �������, � ������� ��������� ����������.
    /// </summary>
    int _semester;
    /// <summary>
    /// ������������� ����������.
    /// </summary>
    string _instructor;

    /// <summary>
    /// ���������� � �������� �������� ����������. ���������� �������� ������ ����.
    /// </summary>
    public string DisciplineName
    {
        get { return _disciplineName; }
        set
        {
            if (value.Length == 0) throw new ArgumentException();
            _disciplineName = value;
        }
    }
    /// <summary>
    /// ���������� � �������� ������ �� ����������. �������� �� ���� �� ���� (������������).
    /// </summary>
    public int Grade
    {
        get { return _grade; }
        set
        {
            Validator.AssertValueInRange(value, 0, 6);
            _grade = value;
        }
    }
    /// <summary>
    /// ���������� � �������� �������, � ������� ��������� ����������. �������� �� ���� �� 8 (������������).
    /// </summary>
    public int Semester
    {
        get { return _semester; }
        set
        {
            Validator.AssertValueInRange(value, 0, 9);
            _semester = value;
        }
    }
    /// <summary>
    /// ���������� � �������� ������������� ����������. ���������� �������� ������ ����.
    /// </summary>
    public string Instructor
    {
        get { return _instructor; }
        set
        {
            if (value.Length == 0) throw new ArgumentException();
            _instructor = value;
        }
    }

    /// <summary>
    /// ������ ��������� ������ <see cref="Discipline"/>.
    /// </summary>
    public Discipline()
    {
        DisciplineName = "Programming";
        Grade = 5;
        Semester = 2;
        Instructor = "^_^";
    }

    /// <summary>
    /// ������ ��������� ������ <see cref="Discipline"/>.
    /// </summary>
    /// <param name="disciplineName">�������� ����������.</param>
    /// <param name="grade">������ �� ����������.</param>
    /// <param name="semester">�������, � ������� ��������� ����������.</param>
    /// <param name="instructor">������������� ����������.</param>
    public Discipline(string disciplineName, int grade, int semester, string instructor)
    {
        DisciplineName = disciplineName;
        Grade = grade;
        Semester = semester;
        Instructor = instructor;
    }
}