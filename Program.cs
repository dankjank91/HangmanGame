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
            HideWords hiddenword = new HideWords();
            GameWords gamewords = new GameWords();
            Randomizer randomizer= new Randomizer();
            int r = 0;
            r = randomizer.selector(r);
            Console.WriteLine("Hello World!");
            Console.WriteLine("Let's make Hangman!");
            string p = string.Empty;
            hiddenword.hide_word(gamewords.words(r, p));


        }
    }
    class GameWords
    {
        private string[] gwords { get; set; }
        private int selected { get; set; }

        public string words(int selected,string p)
        {

            string[] gwords = {"Pumpkin","Candy","Skeleton"};
            return p = gwords[selected].ToString();
        }
    }
    class Randomizer
    {
        GameWords G = new GameWords();
        private int r { get; set; }
        Random random = new Random();
        public int selector(int r)
        {
          r = random.Next(0,3);
          return r;
            
        }
    }
    class HideWords
    {
        private string hiddenword { get; set; }
        public void hide_word(string hiddenword)
        {
            char[] letters = hiddenword.ToCharArray();
            for (int i = 0; i < hiddenword.Length; i++)
            {
                hiddenword.Replace(hiddenword[i], '*');

                Console.Write(letters[i].ToString().Replace(letters[i], '*'));

            }

        }
    }

}
