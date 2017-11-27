using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTask
{
    class English
    {
        public int words(String word)
        {
            return word.Split(' ').Length;
        }

        public int find(String message, String findWhat)
        {
            int count =0;

            for (int i = 0; i <= message.Length -findWhat.Length; i++)
            {
                if (message.Substring(i, findWhat.Length) == findWhat) 
                {
                    count++;
                }
            }
            return count;
        }

        public void verticalSentence(String message)
        {
            String tempString = "";
            int word_counter = 0;

            for(int i=0; i < message.Length; i++)
            {
                if(message[i] == ' ')
                {
                    word_counter++;
                }
            }

            string[] words = new string[word_counter];
            int currentWordNo = 0;
            for(int i = 0; i < message.Length; i++)
            {
                if (message[i] != ' ')
                {
                    tempString = tempString + message[i];
                    continue;
                }1
            }
            words[currentWordNo++] = tempString;
            tempString = "";
            words[currentWordNo++] = tempString;

            foreach(var item in words)
            {
                Console.WriteLine(item.ToString());
            }
           
    }
    class Program
    {
        static void Main(string[] args)
        {
            English e;
            e = new English();
            int sentence;

            sentence = e.words("I am in QA");
            //Console.Write(sentence);
            //Console.WriteLine(e.find("I am in going to London, so I am", "am"));
            e.verticalSentence("I am going to London");
            Console.Read();
        }
    }
}
