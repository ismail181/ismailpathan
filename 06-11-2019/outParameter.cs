using System;  
namespace OutParameter  
{  
   public class Program  
    {  
        
        public void Show(out int val) // Out parameter  
        {  
			
		   val = 5;
            val *= val;
			Console.WriteLine(val);
		
        }  
        public static void Main(string[] args)  
        {  
            int val = 0;  
            Program program = new Program(); // Creating Object  
            Console.WriteLine("Value before passing out variable " + val);  
            program.Show( out val); // Passing out argument  
            Console.WriteLine("Value after recieving the out variable " + val);  
        }  
    }  
} 