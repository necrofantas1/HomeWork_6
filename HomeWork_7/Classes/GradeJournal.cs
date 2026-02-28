namespace HomeWork_7.Classes;

public class GradeJournal
{
    private readonly SortedDictionary<DateTime, int> _dictionary = new();

    public void AddGrade(DateTime date, int grade)
    {
        _dictionary[date] = grade;
    }

    public void ShowGrades()
    {
        foreach (var key in _dictionary)
        {
            Console.WriteLine($"{key.Key} {key.Value}");
        }
    }
}