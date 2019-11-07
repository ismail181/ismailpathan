using System;  
namespace AccessSpecifiers  
{  
   public class Internal  
    {  
        internal string name = "ismail ";  
        internal void Msg(string msg)  
        {  
            Console.WriteLine("Hello " + msg);  
        }  
    }  
   public class Program  
    {  
       public static void Main(string[] args)  
        {  
            Internal internalTest = new Internal();  
         
            Console.WriteLine("Hello " + internalTest.name);  
  
            internalTest.Msg("ismail pathan");  
        }  
    }  
}  
//it is access in  same package 