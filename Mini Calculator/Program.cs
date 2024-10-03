namespace Mini_Calculator;

class Program
{
    static void Main(string[] args)
    {
        var userInput = new UserInput();
        var conversionMath = new ConversionMaths();
        
        Console.WriteLine("Welcome to the Mini Calculator! An app designed to assist you with household math. Do you need a demonstration? (Y/N)");

        var userResponse = userInput.YesOrNo();

        if (userResponse == "Y")
        {
            Console.WriteLine("Ok, great! Here is a demonstration of how the Mini Calculator could be used for household math.");
            Console.WriteLine();
            Console.WriteLine("You need curtains for your new apartment, but the website you are ordering from uses Metric measurements. You can use the Mini Calculator to perform the conversion! Follow along step-by-step.");
            Console.WriteLine("Please enter the width of your window in inches...");

            var inches = userInput.MeasurementInInches();

            var measurementInCentimeters = conversionMath.InchesToCentimeters(inches);

            Console.WriteLine($"The width of your window is {measurementInCentimeters}cm.");
        }
        else
        {
            Console.WriteLine("Okay great! What do you need to do?");
            PromptLists.UserMenu();
            var optionNumber = userInput.UserOption();

            switch (optionNumber)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    break;
            }
        }
    }
}