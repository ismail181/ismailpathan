using System;
public class Strings
{
    public static void Main(string[] args)
    {
        String s1 =  5 + "6" + 5;
        String s2 =  "5" + 6 + 5 ;
        String s3 =  5 + 6 +  "5";
        String s4 =  "this is String name \"vikas\" he is";
        String s5 =  "it\'s string";
        String s6 =  "it is String name \\vikas";
        Console.WriteLine(s1);
        Console.WriteLine(s2);
        Console.WriteLine(s3);
        Console.WriteLine(s4);
        Console.WriteLine(s5);
        Console.WriteLine(s6);


    }
}