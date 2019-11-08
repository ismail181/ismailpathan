  using System;
  public class ProtectedInternal
    {  
        protected internal string name = "ismail";  
        protected void Msg(string msg)  
        {  
            Console.WriteLine("Hello " + msg);  
        }  
    }  
 public   class Program : ProtectedTest  
    {  
      public  static void Main(string[] args)  
        {  
            Program program = new Program();  
            Console.WriteLine("Hello " + program.name);  
            program.Msg("ismail pathan");  
        }  
    }  
    //it can also accsess in derived classes of different package