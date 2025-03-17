using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose a conversion type:");
        Console.WriteLine("1. Convert to Number (int)");
        Console.WriteLine("2. Convert to Boolean (true/t/false/f)");
        Console.WriteLine("3. Convert to DateTime");
        Console.WriteLine("4. Convert to Double");
        Console.WriteLine("5. Convert to Decimal");
        Console.WriteLine("6. Perform Basic Decimal Calculation");
        Console.Write("Enter your choice (1-6): ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                ConvertToInt();
                break;
            case "2":
                ConvertToBoolean();
                break;
            case "3":
                ConvertToDateTime();
                break;
            case "4":
                ConvertToDouble();
                break;
            case "5":
                ConvertToDecimal();
                break;
            case "6":
                PerformDecimalCalculation();
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }

    static void ConvertToInt()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        try
        {
            int intValue = Convert.ToInt32(input);
            Console.WriteLine($"Converted Integer: {intValue}");
        }
        catch
        {
            Console.WriteLine("Invalid Integer!");
        }
    }

    static void ConvertToBoolean()
    {
        Console.Write("Enter 'true', 'false', 't', or 'f': ");
        string input = Console.ReadLine().ToLower();
        try
        {
            bool boolValue = input switch
            {
                "true" or "t" => true,
                "false" or "f" => false,
                _ => throw new Exception()
            };
            Console.WriteLine($"Converted Boolean: {boolValue}");
        }
        catch
        {
            Console.WriteLine("Invalid Boolean!");
        }
    }

    static void ConvertToDateTime()
    {
        Console.Write("Enter a date (YYYY-MM-DD): ");
        string input = Console.ReadLine();
        try
        {
            DateTime dateValue = Convert.ToDateTime(input);
            Console.WriteLine($"Converted DateTime: {dateValue}");
        }
        catch
        {
            Console.WriteLine("Invalid DateTime!");
        }
    }

    static void ConvertToDouble()
    {
        Console.Write("Enter a double value: ");
        string input = Console.ReadLine();
        try
        {
            double doubleValue = Convert.ToDouble(input);
            Console.WriteLine($"Converted Double: {doubleValue}");
        }
        catch
        {
            Console.WriteLine("Invalid Double!");
        }
    }

    static void ConvertToDecimal()
    {
        Console.Write("Enter a decimal value: ");
        string input = Console.ReadLine();
        try
        {
            decimal decimalValue = Convert.ToDecimal(input);
            Console.WriteLine($"Converted Decimal: {decimalValue}");
        }
        catch
        {
            Console.WriteLine("Invalid Decimal!");
        }
    }

    static void PerformDecimalCalculation()
    {
        Console.Write("Enter first decimal: ");
        string firstInput = Console.ReadLine();
        Console.Write("Enter second decimal: ");
        string secondInput = Console.ReadLine();

        try
        {
            decimal firstDecimal = Convert.ToDecimal(firstInput);
            decimal secondDecimal = Convert.ToDecimal(secondInput);

            Console.WriteLine($"Addition: {firstDecimal + secondDecimal}");
            Console.WriteLine($"Subtraction: {firstDecimal - secondDecimal}");
            Console.WriteLine($"Multiplication: {firstDecimal * secondDecimal}");
            Console.WriteLine($"Division: {(secondDecimal != 0 ? firstDecimal / secondDecimal : "Cannot divide by zero")}");
        }
        catch
        {
            Console.WriteLine("Invalid Decimal Inputs for Calculation!");
        }
    }
}
