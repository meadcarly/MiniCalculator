namespace Mini_Calculator;

public class OptionCalls
{ 
    private UserInput _userInput = new UserInput();
    private ConversionMaths _conversionMath = new ConversionMaths();
    
    public double ConvertInToCm()
    {
        Console.WriteLine("Please enter your measurement(in inches).");
        var inches = _userInput.MeasurementInStandard();
        var convert = _conversionMath.InchesToCentimeters(inches);
        return convert;
    }

    public double ConvertInToMeters()
    {
        Console.WriteLine("Please enter your measurement(in inches).");
        var inches = _userInput.MeasurementInStandard();
        return _conversionMath.InchesToMeters(inches);
    }

    public double ConvertFtToCm()
    {
        Console.WriteLine("Please enter your measurement(in feet).");
        var feet = _userInput.MeasurementInStandard();
        return _conversionMath.FeetToCentimeters(feet);
    }

    public double ConvertFtToMeters()
    {
        Console.WriteLine("Please enter your measurement(in feet).");
        var feet = _userInput.MeasurementInStandard();
        return _conversionMath.FeetToMeters(feet);
    }

    public decimal DetermineAreaRectangle()
    {
        Console.WriteLine("Please enter the length of your rectangle in inches.");
        var length = _userInput.Measurement();
        Console.WriteLine("Please enter the width of your rectangle in inches.");
        var width = _userInput.Measurement();
        return _conversionMath.AreaOfRectangle(length, width);
    }
    
    public decimal DetermineAreaSquare()
    {
        Console.WriteLine("Please enter the length of your square in inches.");
        var length = _userInput.Measurement();
        return _conversionMath.AreaOfSquare(length);
    }

    public decimal DetermineAreaTriangle()
    {
        Console.WriteLine("Please enter the length of your triangle base in inches.");
        var baseLength = _userInput.Measurement();
        Console.WriteLine("Please enter the height of your triangle in inches.");
        var height = _userInput.Measurement();
        return _conversionMath.AreaOfRectangle(baseLength, height);
    }
    
    public decimal DetermineAreaCircle()
    {
        Console.WriteLine("Please enter the radius of your circle in inches.");
        var radius = _userInput.Measurement();
        return _conversionMath.AreaOfCircle((double)radius);
    }
}