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

    public decimal AreaOfRectangle(decimal length, decimal width)
    {
        return length * width;
    }

    public decimal AreaOfSquare(decimal length)
    {
        return length * length;
    }

    public decimal AreaOfTriangle()
    {
        throw new NotImplementedException();
    }

    public decimal AreaOfCircle()
    {
        throw new NotImplementedException();
    }
}