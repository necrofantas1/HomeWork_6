namespace HomeWork_6.Classes;

public class ProfileDataBase
{
    Dictionary<int, Student> _students = new();
    
    public void AddStudent(Student student)
    {
        _students[student.Id] = student;
    }

    public string GetStudentById(int id)
    {
        return _students[id].FullName; // List перебирає кожен елемент, а словник використовує хеш для швидкого доступу до елементів за ключем.
    }
}