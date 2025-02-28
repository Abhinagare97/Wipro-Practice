using System;
using System.Collections.Generic;
using System.Linq;

class Programm
{
    static void Mainee()
    {
        // Input: Main String
        string mainString = GetInput("Enter the main string:");

        // Input: Sub String
        string substring = GetInput("Enter the substring:");

        // Input: Character to be replaced
        char charToReplace = GetInput("Enter the character to replace:")[0];

        // Input: Replacement character
        char replacementChar = GetInput("Enter the replacement character:")[0];

        // Check if substring exists
        bool substringExists = CheckSubstringExists(mainString, substring);

        // Replace characters
        string replacedString = ReplaceCharacter(mainString, charToReplace, replacementChar);

        // Swap case
        string caseSwapped = SwapCase(mainString);

        // Remove spaces
        string noSpaces = RemoveWhitespace(mainString);

        // Count letter occurrences
        Dictionary<char, int> letterCount = CountLetters(mainString);

        // Output results
        Console.WriteLine($"Substring Exists: {(substringExists ? "Yes" : "No")}");
        Console.WriteLine($"Replaced: {replacedString}");
        Console.WriteLine($"Case Swapped: {caseSwapped}");
        Console.WriteLine($"No Spaces: {noSpaces}");
        Console.WriteLine($"Letter Count: {string.Join(", ", letterCount.Select(kvp => $"{kvp.Key}: {kvp.Value}"))}");
    }

    static string GetInput(string prompt)
    {
        Console.WriteLine(prompt);
        return Console.ReadLine();
    }

    static bool CheckSubstringExists(string main, string sub)
    {
        return main.Contains(sub);
    }

    static string ReplaceCharacter(string input, char oldChar, char newChar)
    {
        return input.Replace(oldChar, newChar);
    }

    static string SwapCase(string input)
    {
        char[] swapped = input.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)).ToArray();
        return new string(swapped);
    }

    static string RemoveWhitespace(string input)
    {
        return new string(input.Where(c => !char.IsWhiteSpace(c)).ToArray());   

    }

    static Dictionary<char, int> CountLetters(string input)
    {
        Dictionary<char, int> letterCount = new Dictionary<char, int>();
        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                if (letterCount.ContainsKey(c))
                    letterCount[c]++;
                else
                    letterCount[c] = 1;
            }
        }
        return letterCount;
    }
}