// // Problem Statement: Create a program that:

// // Rotates an array to the right by a specified number of positions.

// // Concatenates the rotated array elements into a single string, separated by commas.

// // Reverses the concatenated string.

// // Counts the occurrences of each digit in the reversed string.using System;


// using System.Collections.Generic;
// using System.Linq;

// class Program
// {
//     static void Mainn()
//     {
//         // Take user input for the array
//         Console.WriteLine("");
//         string[] inputArray = Console.ReadLine().Split(' ');
//         int[] array = Array.ConvertAll(inputArray, int.Parse);

//         // Take user input for the number of rotation positions
//         Console.WriteLine("");
//         int rotationPositions = int.Parse(Console.ReadLine());

//         // Rotate the array to the right
//         int[] rotatedArray = RotateArray(array, rotationPositions);

//         // Concatenate the rotated array into a single string
//         string concatenatedString = string.Join(",", rotatedArray);

//         // Reverse the concatenated string
//         string reversedString = new string(concatenatedString.Reverse().ToArray());

//         // Count occurrences of each digit in the reversed string
//         Dictionary<char, int> digitCounts = CountDigits(reversedString);

//         // Display results
//         Console.WriteLine("Rotated Array: [" + string.Join(", ", rotatedArray) + "]");
//         Console.WriteLine("Concatenated String: \"" + concatenatedString + "\"");
//         Console.WriteLine("Reversed String: \"" + reversedString + "\"");
//         Console.Write("Digit Counts: "); // Write your code below 
//         Console.WriteLine(string.Join(", ", digitCounts.Select(kv=> $"{kv.Key}:{kv.Value}"))
//         );
//     }

//     static int[] RotateArray(int[] array, int positions)
//     {
//         // Write your code below 
//         int length = array.Length;
//         positions%=length;
//         int[] rotated = new int[length];
//         for(int i =0; i<length; i++){
//             rotated[(i+positions)%  length]= array[i];
//         }
//         return rotated;
//     }

//     static Dictionary<char, int> CountDigits(string input)
//     {
//         // Write your code below 
//         Dictionary<char,int>digitCounts = new Dictionary<char, int>();
//         foreach(char c in input){
//             if(char.IsDigit(c)){
//                 if(!digitCounts.ContainsKey(c))
//                 digitCounts[c]=0;
//                 digitCounts[c]++;
//             }
//         }
//         return digitCounts;
// }
// }