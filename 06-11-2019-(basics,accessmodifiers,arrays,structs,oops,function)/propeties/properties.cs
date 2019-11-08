using System;

public class Test
{
    private  int cnt =10;
  
    public   int counter//read-only if use get & constructor to initilise without set
    {
        get
        {
            return cnt;
        }
        set 
        {
            cnt = value; 
        }
    }
}
public class Student
{
    public static void Main(string[] args)
    {
        Test t1 = new Test();
         t1.counter = 20;
        Console.WriteLine(t1.counter);
    
    }
}