using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "output.txt";

        while (true)
        {
            Console.Write("\nEnter text to append to the file (or type 'exit' to quit): ");
            string userInput = Console.ReadLine()?.Trim();

            // Validation: Check if input is empty
            if (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine(" Input cannot be empty. Please enter valid text.");
                continue;
            }

            // Exit condition
            if (userInput.ToLower() == "exit")
            {
                Console.WriteLine(" Program exited.");
                break;
            }

            try
            {
                // Append the text to the file
                File.AppendAllText(filePath, userInput + Environment.NewLine);
                Console.WriteLine(" Text successfully appended to 'output.txt'!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($" Error writing to file: {ex.Message}");
            }
        }
    }
}

