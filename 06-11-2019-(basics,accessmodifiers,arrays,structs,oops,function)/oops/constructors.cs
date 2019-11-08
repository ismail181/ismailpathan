using System;
public class Constructors
{
    public static string name;
    public static int val;
      public Constructors()
    {
          this.name = "ismail";
    }
      public Constructors(string nam)
    {
          this.name = nam;
    }
    public Constructors(string nam, int value)
    {
        this.name = nam;
        this.val = value;
    }
    public static void Main(string[] args)
    {
           Constructors c1 = new Constructors(); 
           Constructors c2 = new Constructors("pathan"); 
           Constructors c3 = new Constructors("pathan", 20);
           Console.WriteLine(c1.name + " " + c2.name +" "+ c3.name +" "+ c3.val);
    }
}
// these are mainly to initialization.
//same constructors  can't exist in same method bcz console will confuse to which it has to choose so it gives error.
//we can't write return types before constructors.
//constructors aren't  inherit to another class .(static)