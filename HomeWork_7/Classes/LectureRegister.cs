namespace HomeWork_7.Classes;

public class LectureRegister
{
    private readonly HashSet<Student> _attendees = new HashSet<Student>();

    public void Register(Student student)
    {
        _attendees.Add(student);
    }
    
    public IEnumerable<Student> GetAttendees()
    {
        return _attendees;
    }
}