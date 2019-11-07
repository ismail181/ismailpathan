using System;  
public struct Rectangle  
{  
    public int width, height;  
  
    public Rectangle(int x, int y)  
    {  
        this.width = x;  
        this.height = y;  
    }  
    public void areaOfRectangle() {   
     Console.WriteLine("Area of Rectangle is: "+(width*height)); }  
    }  
public class TestStructs  
{  
    public static void Main()  
    {  
        Rectangle r = new Rectangle(5, 6);  
        r.areaOfRectangle();  
    }  
}  