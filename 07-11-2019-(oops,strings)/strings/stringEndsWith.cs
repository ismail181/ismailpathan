//it returns boolean whether it ends with that str or not
using System;    
public class StringEndsWith    
{    
    public static void Main(string[] args)    
    {    
         string s1 = "Hello";    
         string s2 = "llo";  
         string s3 = "C#";  
         Console.WriteLine(s1.EndsWith(s2));  //T
         Console.WriteLine(s1.EndsWith(s3));  //F
    }    
}    