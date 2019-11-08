using System;  
namespace RefParameter  
{  
   public class Program  
    {  
        
        public void Show(ref int val) // Out parameter  
        {  
            val *= val;
			Console.WriteLine(val);
		
        }  
        public static void Main(string[] args)  
        {  
            int val = 10;  
            Program program = new Program(); // Creating Object  
            Console.WriteLine("Value before passing out variable " + val);  
            program.Show( ref val); 
            Console.WriteLine("Value after recieving the out variable " + val);  
        }  
    }  
} 