using System;    
    public class StringEquals    
    {    
        public static void Main(string[] args)    
        {    
             string s1 = "Hello";    
             string s2 = "Hello";  
             string s3 = "Bye";  
			 string s4 = "Bey";
             Console.WriteLine(s1.Equals(s2));  
             Console.WriteLine(s1.Equals(s3)); 
			Console.WriteLine(s3.Equals(s4)); 
        }    
    }    