using System;    
    public class StringContains    
    {    
        public static void Main(string[] args)    
        {    
             string s1 = "Hello ";    
             string s2 = "He";  
             string s3 = "Hl";  
			string s4 = "ll"; 
             Console.WriteLine(s1.Contains(s2));  
             Console.WriteLine(s1.Contains(s3));  
			Console.WriteLine(s1.Contains(s4));
               
        }    
    }  