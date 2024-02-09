using Programming.Model;
using System;

class Discipline
{
    string _disciplineName;
    int _grade;
    int _semester;
    string _instructor;

    public string DisciplineName
    {
        get { return _disciplineName; }
        set
        {
            if (value.Length == 0) throw new ArgumentException();
            _disciplineName = value;
        }
    }
    public int Grade
    {
        get { return _grade; }
        set
        {
            Validator.AssertValueInRange(value, 0, 6);
            _grade = value;
        }
    }
    public int Semester
    {
        get { return _semester; }
        set
        {
            Validator.AssertValueInRange(value, 0, 9);
            _semester = value;
        }
    }
    public string Instructor
    {
        get { return _instructor; }
        set
        {
            if (value.Length == 0) throw new ArgumentException();
            _instructor = value;
        }
    }

    public Discipline ()
    {
        DisciplineName = "Programming";
        Grade = 5;
        Semester = 2;
        Instructor = "^_^";
    }
    
    public Discipline(string disciplineName, int grade, int semester, string instructor)
    {
        DisciplineName = disciplineName;
        Grade = grade;
        Semester = semester;
        Instructor = instructor;
    }
}