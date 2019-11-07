using System;    
    public class StringCompareTo   
    {    
        public static void Main(string[] args)    
        {
			string s = "hleol"; 
            string s1 = "hello1";    
            string s2 = "hleoll"; 
            string s3 = "csharp";  
            string s4 = "mello";  
        
			Console.WriteLine(s.CompareTo(s2));
            Console.WriteLine(s1.CompareTo(s2));  
            Console.WriteLine(s2.CompareTo(s3));
            Console.WriteLine(s3.CompareTo(s4));   
        }    
    } 

    /*
   -1
   -1
    1
   -1
    */