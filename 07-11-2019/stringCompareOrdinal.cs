//The C# CompareOrdinal() method compares two specified String objects by evaluating the numeric values of the corresponding Char objects in each string.
//s1==s2 returns 0  
//s1>s2 returns positive number in difference  
//s1<s2 returns negative number in difference  
using System;    
    public class StringCompareOrdinal   
    {    
        public static void Main(string[] args)    
        {
			string s = "hleol"; 
            string s1 = "hello";    
            string s2 = "hleol"; 
            string s3 = "csharp";  
            string s4 = "mello";  
        
			Console.WriteLine(string.CompareOrdinal(s,s2));
            Console.WriteLine(string.CompareOrdinal(s1,s2));   
            Console.WriteLine(string.CompareOrdinal(s2,s3));   
            Console.WriteLine(string.CompareOrdinal(s3,s4));   
        }    
    } 