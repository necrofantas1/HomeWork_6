using HomeWork_7.Classes;

    class Program
    {
        static void Main()
        { 
            var lostStudent = new Student (10 , "Lost Student");
            var hashSet = new HashSet<Student>();
            hashSet.Add(lostStudent);
            
            Console.WriteLine(hashSet.Contains(lostStudent)); 
            
            lostStudent.Id = 50;
            
            Console.WriteLine(hashSet.Contains(lostStudent)); // Об'єкт продовжує лежати в комірці з хешем Id=5, але HashSet шукає його по новому хешу Id=99 — і не знаходить 
        }
    }
