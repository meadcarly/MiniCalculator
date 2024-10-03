namespace Mini_Calculator;

public class UserInput
{
    public string YesOrNo()
    {
        string YesOrNo = "";
        YesOrNo = Console.ReadLine().ToUpper();
        while (YesOrNo != "Y" && YesOrNo != "N")
        {
            Console.WriteLine("Please enter 'Y' for yes or 'N' for no.");
            YesOrNo = Console.ReadLine().ToUpper();
        }

        return YesOrNo;
    }

    public int UserOption()
    {
        var option = 0;
        int.TryParse(Console.ReadLine(), out option);
        while (option == null || option == 0)
        {
            Console.WriteLine("I'm sorry, please choose a number from the list...");
            int.TryParse(Console.ReadLine(), out option);
        }

        return option;
    }

    public double MeasurementInInches()
    {
        double.TryParse(Console.ReadLine(), out double measurement);
        return measurement;
    }
    
    
}