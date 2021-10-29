////////////////////////////////////////////////////////////////////////////////////////////////////////
//Author : Gen Ceredon
//Created On : 10/22/2021
//Description : CSharpMasters Homework#2: Read a string array of 10 items and only display the item if it 
// is a palidrome
////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"[{i}] Enter a string: ");
                string name = Console.ReadLine();

                // remember to check for null
                if (name != null && name.Length > 0)
                {
                    // spaces and punctuation don't count, but include symbols
                    string tempName = System.Text.RegularExpressions.Regex.Replace(name, "[\\s\\p{P}]", "");
                    char[] nameArray = tempName.ToCharArray();
                    Array.Reverse(nameArray);

                    string reverse = new(nameArray);

                    // we could also compare ignoring case
                    if (tempName.Equals(reverse, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"{name} is Palindrome");
                    }
                }
            }
            Console.ReadKey();
            Console.WriteLine("End of program");
        }
    }
}

/* Sample Output
 * [1] Enter a string: Madam, I'm Adam
   Madam, I'm Adam is Palindrome
   [2] Enter a string: Never odd or even
   Never odd or even is Palindrome
   [3] Enter a string: 191
   191 is Palindrome
   [4] Enter a string: Salas
   Salas is Palindrome
   [5] Enter a string: No lemon no Melon
   No lemon no Melon is Palindrome
   [6] Enter a string: Test string
   [7] Enter a string: not palindrome
   [8] Enter a string: Civic
   Civic is Palindrome
   [9] Enter a string: Homework 2
   [10] Enter a string: madam
   madam is Palindrome
End of program
 */
