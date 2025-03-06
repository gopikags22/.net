using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asgm1.net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value: ");
            string userInput = Console.ReadLine();

            
            if (int.TryParse(userInput, out int intValue))
                Console.WriteLine("Integer: " + intValue);
            else
                Console.WriteLine("Cannot convert to Integer");

            
            if (double.TryParse(userInput, out double doubleValue))
                Console.WriteLine("Double: " + doubleValue);
            else
                Console.WriteLine("Cannot convert to Double");

            
            if (bool.TryParse(userInput, out bool boolValue))
                Console.WriteLine("Boolean: " + boolValue);
            else
                Console.WriteLine("Cannot convert to Boolean");

            
            if (decimal.TryParse(userInput, out decimal decimalValue))
                Console.WriteLine("Decimal: " + decimalValue);
            else
                Console.WriteLine("Cannot convert to Decimal");

            
            if (DateTime.TryParse(userInput, out DateTime dateValue))
                Console.WriteLine("Date & Time: " + dateValue);
            else
                Console.WriteLine("Cannot convert to Date & Time");
        }
    }
}



Q2 
    using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string userInput = Console.ReadLine();
        string upperCase = userInput.ToUpper();
        string lowerCase = userInput.ToLower();
        string reversedString = new string(userInput.ToCharArray().Reverse().ToArray());
        string titleCase = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(userInput);
        Console.WriteLine("Upper Case: " + upperCase);
        Console.WriteLine("Lower Case: " + lowerCase);
        Console.WriteLine("Reversed String: " + reversedString);
        Console.WriteLine("Title Case: " + titleCase);

        char charToFind = 'l';
        int countL = 0;
        string positions = "";

        for (int i = 0; i < userInput.Length; i++)
        {
            if (userInput[i] == charToFind)
            {
                countL++;
                positions += i + " ";
            }
        }

        Console.WriteLine($"Occurrences of '{charToFind}': " + countL);
        Console.WriteLine($"Positions of '{charToFind}': " + positions.Trim());
        string formattedOutput = "*" + string.Join("*", userInput.ToCharArray()) + "*";
        Console.WriteLine("Formatted Output: " + formattedOutput);
    }
}

Q3 
    using System;
using System.IO;

class Program
{
    static void Main()
    {
        string fileName = "output.txt";
        Console.Write("Enter text to append to file: ");
        string userInput = Console.ReadLine();
        File.AppendAllText(fileName, userInput + Environment.NewLine);
        Console.WriteLine("Text appended successfully to " + fileName);
    }
}
