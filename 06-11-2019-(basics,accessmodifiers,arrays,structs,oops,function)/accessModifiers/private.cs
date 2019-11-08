using System;  
namespace AccessSpecifiers  
{  
   public class Private  
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
            private internalTest = new Internal();  
         
            Console.WriteLine("Hello " + internalTest.name);  
  
            internalTest.Msg("ismail pathan");  
        }  
    }  
}  
//it is access in same class 