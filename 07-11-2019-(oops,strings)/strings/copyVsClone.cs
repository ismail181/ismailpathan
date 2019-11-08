using System;
public class CopyVsClone
{
    public static void Main(string[] args)
    {
       string s = "ismail";
       string s1 = string.Copy(s);//same object is refering
       string s2 = string.Clone(s);//shallow copy of object
        Console.WriteLine(s1);
        Console.WriteLine(s2);

    }
}