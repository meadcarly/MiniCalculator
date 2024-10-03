namespace Mini_Calculator;

public class ConversionMaths
{
    public double InchesToCentimeters(double inches)
    {
        //throw new NotImplementedException();
        return inches * 2.54;
    }

    public double InchesToMeters(double inches)
    {
        return inches * 0.0254;
    }
    
    public double FeetToCentimeters(double feet)
    {
        return feet * 30.48;
    }

    public double FeetToMeters(double feet)
    {
        return feet * 0.3048;
    }
}