using System;  
namespace AccessSpecifiers  
{  
   public class Program  
    {  
        private string name = "ismail ";  
        private void Msg(string msg)  
        {  
            Console.WriteLine("Hello " + msg);  
        }  
    }  
   public class Program  
    {  
       public static void Main(string[] args)  
        {  
            Program internalTest = new Internal();  
         
            Console.WriteLine("Hello " + internalTest.name);  
  
            internalTest.Msg("ismail pathan");  
        }  
    }  
}  
//it is access in same class 