using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {
            //call the Disemvoweler function for the 3 statements
            Console.WriteLine("\n\n1st Statement:");
            Disemvoweler("Nickelback is my favorite band. Their songwriting can't be beat!");
            Console.WriteLine("\n\n2nd Statement:");
            Disemvoweler("How many bears would bear grylls grill if bear grylls could grill bears?");
            Console.WriteLine("\n\n3rd Statement:");
            Disemvoweler("I'm a code ninja, baby. I make the functions and I make the calls");

            //keep the console window open
            Console.ReadKey();

        }

        //Create a function called Disemvoweler that takes a string parameter called "input" and prints a disemvoweled string
        static void Disemvoweler(string input)
        {
            //declare outputs for vowels and consonants
            string disVowel = "";
            string vowelsKept = "";

            

            //create a for loop that loops through your input
            for (int i = 0; i < input.Length; i++)
            {
                //get rid of the spaces
                input.Replace(" ", "");
                //create an if else statement that says if it's a vowel, output to vowelsKept, if it's not, output to disVowel
                string letter = input[i].ToString().ToLower();
                
                if ("aeiou".Contains(letter))
                {
                    vowelsKept = vowelsKept + input[i];
                }
                else if (" .,'!?".Contains(letter))
                {
                    disVowel = disVowel + "";
                    vowelsKept = vowelsKept + "";
                }
                else
                {
                    disVowel = disVowel + input[i];
                }
            }
            //print the original and the disemvoweled text
            Console.WriteLine(input);
            Console.WriteLine(disVowel);
            // Console.WriteLine(vowelsKept);
        }
    }
}
