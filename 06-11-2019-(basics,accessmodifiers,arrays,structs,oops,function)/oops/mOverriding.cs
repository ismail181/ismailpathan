//method overriding

using System;

public class Meth
{
    public  virtual void add()
    {
       Console.WriteLine("something meth");
    }
    public static void add(int a, int b)
    {
       Console.WriteLine("something");
    }
}

public class Meth1: Meth
{
    public  override void add()
    {
       Console.WriteLine("nothing meth1");
    }
    public static void add(int a, int b)
    {
       Console.WriteLine("nothing");
    }
}

public class Moverriding
{
    public static void Main(string[] args)
    {
		Meth1 meth1 = new Meth1();
        meth1.add();
        Meth1.add(10, 20);
     
    }
}