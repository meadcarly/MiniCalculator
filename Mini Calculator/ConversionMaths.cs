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

    public decimal AreaOfTriangle(decimal baseLength, decimal height)
    {
        return 0.5m * (baseLength * height);
    }

    public decimal AreaOfCircle(double radius)
    {
            var area = Math.PI * Math.Pow(radius, 2);
            var areaCircle = (decimal)area;
            return Math.Round(areaCircle, 2);
    }
}