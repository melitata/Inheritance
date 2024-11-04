using System;


public class BaseKisi
{
    
    public string FirstName { get; set; }
    public string LastName { get; set; }

   
    public void DisplayFullName()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
    }
}


public class Student : BaseKisi
{
   
    public int StudentNumber { get; set; }

    
    public void DisplayStudentInfo()
    {
        Console.WriteLine($"Student Number: {StudentNumber}");
        DisplayFullName(); 
    }
}


public class Teacher : BaseKisi
{
    
    public decimal Salary { get; set; }

    
    public void DisplayTeacherInfo()
    {
        Console.WriteLine($"Salary: {Salary:C}");
        DisplayFullName(); 
    }
}

class Program
{
    static void Main()
    {
        
        Student student = new Student
        {
            FirstName = "Metin",
            LastName = "Kılıç",
            StudentNumber = 12345
        };

        
        student.DisplayStudentInfo();

        Console.WriteLine(); 
        
        Teacher teacher = new Teacher
        {
            FirstName = "Melike",
            LastName = "Kılıç",
            Salary = 5000.00m
        };

      
        teacher.DisplayTeacherInfo();
    }
}
