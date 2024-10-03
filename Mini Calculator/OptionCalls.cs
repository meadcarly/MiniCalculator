namespace Mini_Calculator;

public class OptionCalls
{ 
    public UserInput _userInput = new UserInput();
    public ConversionMaths _conversionMath = new ConversionMaths();
    
    public double ConvertInToCm()
    {
        Console.WriteLine("Please enter your measurement(in inches).");
        var inches = _userInput.MeasurementInInches();
        var convert = _conversionMath.InchesToCentimeters(inches);
        return convert;
    }
}