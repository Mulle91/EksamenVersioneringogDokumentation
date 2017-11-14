using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Question_game
{
    class Program
    {

        // Dette er et Quiz spil
        static void Main(string[] args)

        // Her er alle de spørgsmål som jeg har lavet til spillet
        {
            Question firstQuestion = new Question();
            firstQuestion.questionText = "What is the color of your car?";
            firstQuestion.questionBox = "Write your answer here: ";
            firstQuestion.answerText = "Blue";
            firstQuestion.rightanswer = "That was the right answer!!!!";
            firstQuestion.wronganswer = "That was wrong. Are you that stupid????";


            Question secondQuestion = new Question();
            secondQuestion.questionText = "Who is Ezio Auditore Da Firenze?";
            secondQuestion.answerText = "An Assassins";


            Question thirdQuestion = new Question();
            thirdQuestion.questionText = "What is the newest Assassins Creed game called?";
            thirdQuestion.answerText = "Assassins Creed Origens";




            bool game = true;
            while (game)
            {
                Console.WriteLine(firstQuestion.questionText);
                Console.Write(firstQuestion.questionBox);


                string input = Console.ReadLine().ToLower().Trim();
                if (input == firstQuestion.questionBox)
                {
                    Console.WriteLine(firstQuestion.rightanswer);
                    Thread.Sleep(1000);
                    return;
                }
                else
                {
                    Console.WriteLine(firstQuestion.wronganswer);
                }
            }
            Console.ReadKey();
        }

        class Question

        {
            public string questionText;
            public string answerText;
            public string answerBox;
            public string rightanswer;
            public string wronganswer;
            internal string questionBox;
        }
    }
}
