using System;
public class EnumExample
{
    public enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

    public static void Main()
    {
        foreach (int s in Enum.GetValues(typeof(Days)))
        {
            Console.WriteLine(s);
        }
        int i = (int)Days.Fri;

        Console.WriteLine(i);
    }
}