using System;  
namespace First {  
public class Hello  
{  
    public static int i = 10;
    public void sayHello() { Console.WriteLine("Hello First Namespace"); }  
}  
	public class Hello1  
{  
    public static int i = 20;
    public void sayHello() { Console.WriteLine("Hello First Namespace"); }  
}  
}  
namespace Second  
{  
    public class Hello  
    {  
        public void sayHello() { Console.WriteLine("Hello Second Namespace"); }  
    }  
}  
public class TestNamespace  
{  
    public static void Main()  
    {  
        First.Hello h1 = new First.Hello();  
		First.Hello1 h3 = new First.Hello1();  
        Second.Hello h2 = new Second.Hello();  
        h1.sayHello();  
        h2.sayHello();  
		 h3.sayHello();
        Console.WriteLine(First.Hello.i);
        Console.WriteLine(First.Hello1.i);
  
    }  
}  
// namespace is mainly used to hold group of classes and through namespace we can access class