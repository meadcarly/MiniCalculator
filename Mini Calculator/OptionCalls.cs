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
}