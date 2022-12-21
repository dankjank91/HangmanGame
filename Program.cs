using System;
using System.Runtime;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] words = { "Program","Code","String","Variable","Integer","Character","Array","Loop","Object","Object-Oriented-Programming" };
            int randomNumber = random.Next(words.Length);
            string beforeWord = words[randomNumber].ToLower();
            string afterWord = beforeWord;
            string inputWord = afterWord;
            char hider = '*';
            bool error = false;
            bool unmatched = true;
            bool play = false;
            int tries = beforeWord.Length;
            int tried = 0;
            char guess;

            for (int i = 0; i < afterWord.Length; i++)
            {
                afterWord = afterWord.Remove(i,1);
                afterWord = afterWord.Insert(i,hider.ToString());
            }

            Console.WriteLine("HANGMAN");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Can you save him from the gallows?");
            
            do
            {
                try
                {
                    Console.WriteLine("y or n");
                    char yesNo = char.Parse(Console.ReadLine());
                    if (yesNo == 'y') { play = true; } else if (yesNo == 'n') { play = false;  }
                }
                catch (FormatException e) { Console.Beep(); Console.WriteLine("Please enter y for Yes or n for No"); }
            }
            while (!play);
            
            do
            {
                Console.WriteLine("<>{0}<>", afterWord);
                Console.WriteLine("<>{0}/{1}<>", tried,tries);
                Console.WriteLine("<>Word length is: {0}<>",beforeWord.Length);

                Console.WriteLine("See if you can guess the word, enter a letter now");

                try
                {

                guess = char.Parse(Console.ReadLine());
                
                Console.Clear(); tried++;
                if(tried > tries) { break; }
                for (int i = 0; i < afterWord.Length; i++)
                {
                    if (beforeWord[i] == guess) 
                    { 
                        afterWord= afterWord.Remove(i,1); 
                        afterWord = afterWord.Insert(i, guess.ToString());
                    }
                   if (!afterWord.Contains('*')) { unmatched = false; play = false; }

                }
                }
                catch (FormatException e)
                {
                    Console.Beep(); Console.WriteLine("Did you try just ONE letter?");
                }
            } while (unmatched);

            if (!unmatched) 
            { 
                Console.WriteLine("You got it, the word was {0}", afterWord); 
            }else { Console.WriteLine("You lost, the man was hung! By the way, the word was {0}",beforeWord); }
            

        }
    
    }

}
