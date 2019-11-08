//method overloading

using System;

public class Meth
{
    public static int add(int a, int b)
    {
        return a+b;
    }
    public static int add(int a, int b, int c)
    {
        return a+b+c;
    }
}
public class Moverloading
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Meth.add(10, 20));
        Console.WriteLine(Meth.add(10, 20,30));
    }
}