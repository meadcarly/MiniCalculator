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
        int option;
        while (!int.TryParse(Console.ReadLine(), out option) || option <= 0)
        {
            Console.WriteLine("I'm sorry, please choose a number from the list...");
            
        }

        return option;
    }

    public double MeasurementInStandard()
    {
        double measurement;
        while (!double.TryParse(Console.ReadLine(), out measurement) || measurement <= 0)
        {
            Console.WriteLine("I'm sorry, please enter a valid number greater than 0.");
        }
        return measurement;
    }
    
    
}