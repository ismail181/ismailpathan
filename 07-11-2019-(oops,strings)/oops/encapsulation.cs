using System;  
namespace ToAccess  
{  
  public  class Student  
    {  
        // Creating setter and getter for each property  
        public int ID; 
        public string Name ;
        public string Email ;
    }  
   public class Program  
    {  
       public  static void Main(string[] args)  
        {  
            Student student = new Student();  
            // Setting values to the properties  
            student.ID = 101;  
            student.Name = "Mohan ";  
            student.Email = "mohan@example.com";  
            // getting values  
            Console.WriteLine("ID = "+ student.ID);  
            Console.WriteLine("Name = "+student.Name);  
            Console.WriteLine("Email = "+student.Email);  
        }  
    }  
}
//it is wrapping data into single unit, it avoid accessing data from ousiders.And to access 