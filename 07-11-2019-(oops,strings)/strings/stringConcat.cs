using System;    
    public class StringConcat    
    {    
        public static void Main(string[] args)    
        {    
             string s1 = "Hello ";    
             string s2 = "C#"; 
			string s3 = string.Concat(s1,s2);//string.Concate(object)
			Console.WriteLine(s3);  
        }    
    }    