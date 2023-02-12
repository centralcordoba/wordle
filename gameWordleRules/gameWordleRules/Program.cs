using System;
using System.Text.RegularExpressions;

namespace gameWordleRules
{
    class Program
    {
        static int coincidencesLetter = 0;
        static string wordKey = "goles";
        static void Main (string[] args)
        {
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("Enter the text number Number " + "" + i);
                string texto;
                texto = Console.ReadLine();
                if (Validation(texto) && ValidationNumber(texto))
                {
                    Console.WriteLine("The entered text is: " + texto);
                    Console.WriteLine(SearchCoincidenceLetter(texto));
                }
                else
                {
                    Console.WriteLine("The entered text is invalid: " + texto);                   
                }
            }

            if (coincidencesLetter == 5)
            {
                Console.WriteLine("text matches" + "-" + "word is " + "-" + wordKey);
            }
            else
            {
                Console.WriteLine("The text does not match");
            }

        }

        static string SearchCoincidenceLetter(string texto) 
        {
           
            string letter;
            string message = "Not coincidence";
            for (int i = 0; i < 5; i++)
            {
                letter = texto.Substring(i , 1);               
                if (wordKey.Contains(letter))
                {
                    message = "letter coincidence" + "-" + "position" +  "-" + i + "-" + "letter" +  "-" + letter;
                    coincidencesLetter = coincidencesLetter + 1;
                   
                }
            }           

            return message;
        }
        static bool Validation(String texto) 
        {
            if (texto.Length == 5)
            {
                return true;
                
            }
            else
            {
                return false;
            }          
           
        }

        static bool ValidationNumber(String texto)
        {
            if (Regex.IsMatch(texto, @"^[0-9]+$"))
            {
                Console.WriteLine("The Given String is a Number.");
                return false;
            }
            else
            {
                Console.WriteLine("The Given String is Not a Number.");
                return true;
            }
        }
    }
}
