namespace HomeWork_6.Classes;

public class Student
{
    public int Id { get; set; }
    public string FullName { get; init; }
    
    public  Student(int id, string fullName)
    {
        Id = id;
        FullName = fullName;
    }
    
    public override bool Equals(object obj)
    {
        if (obj is Student student)
            return Id == student.Id;
        
        return false;
    }
    
    public override int GetHashCode()
    {
        return HashCode.Combine(Id);
    }
}