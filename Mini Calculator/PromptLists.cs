namespace Mini_Calculator;

public class PromptLists
{
    public static void UserMenu()
    {
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Calculate square footage");
        Console.WriteLine("4. Convert to Metric");
    }
    
    public static void ConversionMenu()
    {
        Console.WriteLine("1. Inches to centimeters");
        Console.WriteLine("2. Inches to meters");
        Console.WriteLine("3. Feet to centimeters");
        Console.WriteLine("4. Feet to meters");
    }

    public static void ChooseShape()
    {
        Console.WriteLine("1. Rectangle");
        Console.WriteLine("2. Square");
        Console.WriteLine("3. Triangle");
        Console.WriteLine("4. Circle");
    }
}