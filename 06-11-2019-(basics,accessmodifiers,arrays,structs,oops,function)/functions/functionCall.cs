using System;
namespace Fuction
{
    class functionCall
    {
        public void functionCall()
        {
            Console.writeLine("hello to all");
        }
        public static void Main(string[] args)
        {
            functionCall fc = new functionCall();
            fc.functionCall();
        }
    }
}