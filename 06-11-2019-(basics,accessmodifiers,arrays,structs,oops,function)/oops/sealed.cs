using System;  
public class child{  
    public virtual void add() { 
        Console.WriteLine("adding...");
        }  
    public virtual void write() { 
        Console.WriteLine("writing...");
        }  
  
}  
public sealed class Dog: child  //sealed class
{  
   public override void add() 
       { 
        Console.WriteLine("barking..."); 
        }  
    public sealed override void write() {
        Console.WriteLine("running..."); 
        }  
  
}  
public class BabyDog : Dog   // we can't inherit sealed Dog class
{  
    public override void add() {
        Console.WriteLine("eating biscuits..."); 
        }  
    public override void write() { Console.WriteLine("running slowly..."); }  // we can't override sealed method and class
}  
public class Seal  
{  
    public static void Main()  
    {  
        BabyDog d = new BabyDog();  
        d.add();  
        d.write();  
    }  
}  
//sealed isn't applicable for fields  it is for only class and methods