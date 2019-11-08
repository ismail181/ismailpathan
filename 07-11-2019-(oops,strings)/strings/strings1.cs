//Strings
using System;  
public class StringExample  
{  
    public static void Main(string[] args)  
    {  
        string s1 = "hello";  //we can initialise  without new Operator
  
        char[] ch = { 'c', 's', 'h', 'a', 'r', 'p' };  
        string s2 = new string(ch);// by string keyword
		 String s3 = new String(ch); //by using String Class
         
        Console.WriteLine(s1);  
        Console.WriteLine(s2);  
		 Console.WriteLine(s3);  
    }  
}  