namespace Mini_Calculator;

class Program
{
    static void Main(string[] args)
    {
        var userInput = new UserInput();
        var conversionMath = new ConversionMaths();
        var optionCalls = new OptionCalls();
        var basicMath = new BasicMaths();
        
        Console.WriteLine("Welcome to the Mini Calculator! An app designed to assist you with household math. Do you need a demonstration? (Y/N)");

        var userResponse = userInput.YesOrNo();

        if (userResponse == "Y")
        {
            Console.WriteLine("Ok, great! Here is a demonstration of how the Mini Calculator could be used for household math.");
            Console.WriteLine();
            Console.WriteLine("You need curtains for your new apartment, but the website you are ordering from uses Metric measurements. You can use the Mini Calculator to perform the conversion! Follow along step-by-step.");
            Console.WriteLine("Please enter the width of your window in inches...");

            var inches = userInput.MeasurementInStandard();

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
                    Console.WriteLine("Ok, let's do addition! Please enter the first number.");
                    var firstInteger = userInput.Measurement();
                    Console.WriteLine("Excellent, now the second number...");
                    var secondInteger = userInput.Measurement();
                    var sum = basicMath.Addition(firstInteger, secondInteger);
                    Console.WriteLine($"The sum of {firstInteger} and {secondInteger} is: {sum}");
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    Console.WriteLine("Let's get converting! Which conversion do you need?");
                    PromptLists.ConversionMenu();
                    optionNumber = userInput.UserOption();
                    if (optionNumber == 1)
                    {
                        var convert = optionCalls.ConvertInToCm();
                        
                        Console.WriteLine($"Your measurement is {convert}cm.");
                    }
                    else if (optionNumber == 2)
                    {
                        var convert = optionCalls.ConvertInToMeters();

                        Console.WriteLine($"Your measurement is {convert}meters.");
                    }
                    else if (optionNumber == 3)
                    {
                        var convert = optionCalls.ConvertFtToCm();

                        Console.WriteLine($"Your measurement is {convert}cm.");
                    }
                    else if (optionNumber == 4)
                    {
                        var convert = optionCalls.ConvertFtToMeters();

                        Console.WriteLine($"Your measurement is {convert}meters.");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}