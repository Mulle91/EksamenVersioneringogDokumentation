using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Question_game
{

    /// <summary>
    /// Her har jeg valgt at kalde min class for program
    /// </summary>

    class Program
    {
       
        // Dette er et Quiz spil
        static void Main(string[] args)

        // Her er alle de spørgsmål som jeg har lavet til spillet
        {
            Question firstQuestion = new Question();
            firstQuestion.questionText = "What is the color of your car?";
            firstQuestion.questionBox = "Write your answer here: ";
            firstQuestion.answerText = "blue";
            firstQuestion.rightanswer = "That was the right answer!!!!";
            firstQuestion.wronganswer = "That was wrong. Are you that stupid????";

            
            Question secondQuestion = new Question();
            secondQuestion.questionText = "Who is Ezio Auditore Da Firenze?";
            secondQuestion.answerText = "An Assassins";


            Question thirdQuestion = new Question();
            thirdQuestion.questionText = "What is the newest Assassins Creed game called?";
            thirdQuestion.answerText = "Assassins Creed Origens";


           
            // Her tjekker den om det jeg har svaret er rigtigt

            bool game = true;
            while (game)
            {
                Console.WriteLine(firstQuestion.questionText);
                Console.Write(firstQuestion.questionBox);

                // Den her funktion gør at du skal skrive svareret med småt

                string input = Console.ReadLine().ToLower().Trim();
                if (input == firstQuestion.questionBox)
                {
                    Console.WriteLine(firstQuestion.rightanswer);
                    Thread.Sleep(1000);
                    return;
                }
                else

                {

                    // Her skulle være hvad programmet skulle have gjort hvis spilleren svarede forkert

                    Console.WriteLine(firstQuestion.wronganswer);
                }
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Her er de classes jeg har valgt at bruge 
        /// </summary>
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
