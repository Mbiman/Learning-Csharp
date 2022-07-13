using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    internal class Class1
    {
        public string CheckBomb()
        {
            Console.WriteLine("Enter a sentence");
            String Sentence = Console.ReadLine();
            Console.WriteLine();

            string[] allSentence = Sentence.Split(' ', ',', '.', '-', '\n', '\t', '?', '!');


        for (int i = 0; i < allSentence.Length; i++)
        {



            //Console.WriteLine(allSentence[i]);
            if (allSentence[i] == "bomb")
            {
                Console.WriteLine("Duck!!!");
                break;

            }
            else
            {
                Console.WriteLine("There is no bomb, relax");
                break;
            }


        }


        return Sentence;

        }
    }


