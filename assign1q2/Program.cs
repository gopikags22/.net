using System;

class Program
{
    // Function to count characters
    static int CountCharacters(string s)
    {
        return s.Length;
    }

    // Function to count words
    static int CountWords(string s)
    {
        return s.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }

    // Function to count occurrences of a letter
    static int LetterOccurrence(string s, char letter)
    {
        int count = 0;
        foreach (char c in s)
        {
            if (c == letter)
                count++;
        }
        return count;
    }

    // Function to split string into words
    static string[] SplitString(string s)
    {
        return s.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
    }

    // Function to add '*' inside each word (between characters)
    static string AddAsteriskInsideWords(string s)
    {
        string[] words = SplitString(s);
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = string.Join("*", words[i].ToCharArray());
        }
        return string.Join(" ", words);
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        Console.Write("Enter a letter to count occurrences: ");
        char letter = Console.ReadKey().KeyChar;
        Console.WriteLine();

        Console.WriteLine("\nResults:");
        Console.WriteLine("Number of characters: " + CountCharacters(text));
        Console.WriteLine("Number of words: " + CountWords(text));
        Console.WriteLine("Occurrences of '" + letter + "': " + LetterOccurrence(text, letter));
        Console.WriteLine("Split string: " + string.Join(", ", SplitString(text)));
        Console.WriteLine("String with '*' inside words: " + AddAsteriskInsideWords(text));
    }
}
