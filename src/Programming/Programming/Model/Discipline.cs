using System;

/// <summary>
/// Представление учебной дисциплины.
/// </summary>
class Discipline
{
    /// <summary>
    /// Название дисциплины.
    /// </summary>
    string _disciplineName;
    /// <summary>
    /// Оценка по дисциплине.
    /// </summary>
    int _grade;
    /// <summary>
    /// Семестр, в котором изучается дисциплина.
    /// </summary>
    int _semester;
    /// <summary>
    /// Преподаватель дисциплины.
    /// </summary>
    string _instructor;

    /// <summary>
    /// Возвращает и изменяет название дисциплины. Количество символов больше нуля.
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
    /// Возвращает и изменяет оценку по дисциплине. Значение от нуля до пяти (включительно).
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
    /// Возвращает и изменяет семестр, в котором изучается дисциплина. Значение от нуля до 8 (включительно).
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
    /// Возвращает и изменяет преподавателя дисциплины. Количество символов больше нуля.
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
    /// Создаёт экземпляр класса <see cref="Discipline"/>.
    /// </summary>
    public Discipline()
    {
        DisciplineName = "Programming";
        Grade = 5;
        Semester = 2;
        Instructor = "^_^";
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Discipline"/>.
    /// </summary>
    /// <param name="disciplineName">Название дисциплины.</param>
    /// <param name="grade">Оценка по дисциплине.</param>
    /// <param name="semester">Семестр, в котором изучается дисциплина.</param>
    /// <param name="instructor">Преподаватель дисциплины.</param>
    public Discipline(string disciplineName, int grade, int semester, string instructor)
    {
        DisciplineName = disciplineName;
        Grade = grade;
        Semester = semester;
        Instructor = instructor;
    }
}