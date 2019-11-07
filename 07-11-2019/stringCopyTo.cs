using System;    
    public class StringCopyTo    
    {    
        public static void Main(string[] args)    
        {    
             string s1 = "Hello C#, How Are You?";    
             char[] ch = new char[15];  
             s1.CopyTo(10,ch,0,12);  // s1.CopyTo(index of s1 from which is to print, ch, starting index of ch, ending index of ch)
             Console.WriteLine(ch);  
        }    
    }    