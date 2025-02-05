using System;

// Define PropertyDemo class
public class PropertyDemo
{
    // Public auto-implemented property
    public string Name { get; set; }

    // Private backing field with a public property
    private int _age = 5;
    public int Age
    {
        get { return _age; }
        set { if (value > 0) _age = value; }
    }

    // Private field with a method to access
    private string privateValue = "Private Value";
    public string GetPrivateValue()
    {
        return privateValue;
    }
}

// Define StaticDemo class
public class StaticDemo
{
    // Static variable
    public static int Counter;

    // Static constructor
    static StaticDemo()
    {
        Console.WriteLine("Static Constructor");
        Counter = 10;
    }

    // Static method
    public static void DisplayMessage()
    {
        Console.WriteLine("Static Method");
    }
}

// Define MathHelper static class
public static class MathHelper
{
    // Static method to add two numbers
    public static int Add(int a, int b)
    {
        return a + b;
    }

    // Static method to subtract two numbers
    public static int Subtract(int a, int b)
    {
        return a - b;
    }
}

public class Program
{
    public static void Main()
    {
        // Demonstrate usage of PropertyDemo
        PropertyDemo demo = new PropertyDemo();
        Console.WriteLine(demo.Age);
        Console.WriteLine(demo.GetPrivateValue());

        // Demonstrate usage of StaticDemo
        StaticDemo display = new StaticDemo();
        Console.WriteLine(StaticDemo.Counter);
        StaticDemo.DisplayMessage();

        // Demonstrate usage of MathHelper
        int sum = MathHelper.Add(10, 5);
        int difference = MathHelper.Subtract(10, 5);
        Console.WriteLine(sum);
        Console.WriteLine(difference);
    }
}