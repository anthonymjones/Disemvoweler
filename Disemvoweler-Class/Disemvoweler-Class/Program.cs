using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nDISEMVOWELER");
            //call the disemvoweler
            Disemvoweler("Nickelback is Logan's favorite band. Their songwriting cannot be beat! Dark Horse is his favorite album.");

            //get a string to disemvowel from the user
            Console.WriteLine("Enter a sentence to disemvowel.");
            //place the users input into a string variable
            string input = Console.ReadLine();
            Disemvoweler(input);

            //get user input inline with Disemvoweler()
            Console.WriteLine("\n\nEnter a sentence to disemvowel.");
            Disemvoweler(Console.ReadLine());


            //keep the console window open
            Console.ReadKey();
        }
        
        /// <summary>
        /// Takes out the vowels and spaces of a string, and prints out the original then the disemvoweled string
        /// </summary>
        /// <param name="input">string to disemvowel</param>
        static void Disemvoweler(string input)
        {
            //declare output variable
            string output = string.Empty;
            //declare a variable to hold the vowels
            string vowels = string.Empty;

            //loop over each letter of the string
            for (int i = 0; i < input.Length; i++)
            {
                //put the current letter into a variable
                string letter = input[i].ToString();
                //determine if the letter is a vowel
                if ("aeiou".Contains(letter.ToLower()))
                {
                    //its a vowel
                    vowels += letter;
                }
                else if (letter == " ")
                {
                    //its a space, do nothing
                }
                else
                {
                    //not a vowel or space, add it to the output
                    output += letter;
                }
            }
            //looped through all the letters, time to print the output
            Console.WriteLine("Original: " + input);
            Console.WriteLine("Disemvoweled: " + output);
            Console.WriteLine("Vowels: " + vowels);
        }
    }
}
