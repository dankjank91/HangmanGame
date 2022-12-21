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
            string[] words = { "Nintendo","Sony","Sega","Microsoft" };
            int randomNumber = random.Next(words.Length);
            string beforeWord = words[randomNumber];
            string afterWord = beforeWord;
            char hider = '*';

            for (int i = 0; i < afterWord.Length; i++)
            {
                afterWord = afterWord.Replace(afterWord[i], hider);

            }
            Console.WriteLine("Before the word was encrypted it was {0}. Then, after it was encrypted it was {1}.",beforeWord,afterWord);
            Console.WriteLine("Before the word was encrypted it was {0} letters. Then, after it was encrypted it was {1} letters.",beforeWord.Length,afterWord.Length);
        }
    
    }

}
