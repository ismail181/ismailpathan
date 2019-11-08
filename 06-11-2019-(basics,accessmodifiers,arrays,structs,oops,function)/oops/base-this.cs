//method overriding

using System;

public class Meth
{
    public string name = "ismail";
    public  virtual  void add()
    {
       Console.WriteLine("from method 1");
    }
   
}

public class Meth1: Meth
{
    public string name="pathan";
    public  Meth1()
    {
       Console.WriteLine("constructor :" + base.name +" "+ this.name);
    }
       public  override  void add()
    {
           base.add();
       Console.WriteLine("from method 2");
    }
   
}

public class Moverriding
{
    public static void Main(string[] args)
    {
		Meth1 meth1 = new Meth1();
        meth1.add();
     
    }
}