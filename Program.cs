using System;
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
            string beforeWord = words[randomNumber];
            string afterWord = beforeWord;
            string inputWord = afterWord;
            char hider = '*';
            bool unmatched = true;
            bool play = false;

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
                Console.WriteLine("y or n");
                char yesNo = char.Parse(Console.ReadLine());
                if (yesNo == 'y') { play = true; Console.Beep(); } else if (yesNo == 'n') { play = false; Console.Beep(); }
            }
            while (!play);
            do
            {
                Console.WriteLine("<>{0}<>", afterWord);

                Console.WriteLine("See if you can guess the word, enter a letter now");
                char guess = char.Parse(Console.ReadLine()); Console.Clear(); 
                for (int i = 0; i < afterWord.Length; i++)
                {
                    if (beforeWord[i] == guess) 
                    { 
                        afterWord= afterWord.Remove(i,1); 
                        afterWord = afterWord.Insert(i, guess.ToString());
                        Console.Beep();
                    }
                   if (!afterWord.Contains('*')) { unmatched = false; play = false; }

                }
            } while (unmatched);

            if (!unmatched) { Console.WriteLine("You got it, the word was {0}", afterWord); }
            else { Console.WriteLine("See ya later"); }
            

        }
    
    }

}
