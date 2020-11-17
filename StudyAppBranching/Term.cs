/*
 * Study Application- Branching
 * By Mohammed Kamal
 * 10/27/2020
 * 
 * I used programmingisfun.com
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StudyApp
{
    class TestTerms
    {

        public int score = 0;
        public int total = 15;

        public void askQuestions()
        {

            string[] terms = new string[15];

            terms[0] = "integer";
            terms[1] = "string";
            terms[2] = "for loop";
            terms[3] = "object";
            terms[4] = "method";
            terms[5] = "while loop";
            terms[6] = "instance";
            terms[7] = "private";
            terms[8] = "public";
            terms[9] = "static";
            terms[10] = "void";
            terms[11] = "conditional statement";
            terms[12] = "array";
            terms[13] = "class";
            terms[14] = "switch";

            string[] Definitions = new string[15];

            Definitions[0] = "A whole number.";
            Definitions[1] = "A string of characters.";
            Definitions[2] = "A loop that has an initializer, a condition, and an iterator. It executes a specific number of times..";
            Definitions[3] = "An instance of a class.";
            Definitions[4] = "A function of the class.";
            Definitions[5] = "A loop that will run and execute statements based on set conditions. Such as if its boolean expression is true.";
            Definitions[6] = "Part of a class that has unique information and has properties and/or operations that identify it as part of a specific class.";
            Definitions[7] = "An access modifier that that is only accessible in the body of a class or struct in which they are declared.";
            Definitions[8] = "An access modifier with no restrictions. It is the most permissive access level.";
            Definitions[9] = "A modifier that declares a member to belong to the type itself rather than to a specific object.";
            Definitions[10] = "A return type that specifies that a method does not return a value.";
            Definitions[11] = "A statement that runs only if a certain condition is met.";
            Definitions[12] = "You can store multiple variables of the same type in this data structure.";
            Definitions[13] = "A blueprint for an object";
            Definitions[14] = "A type of statement that controls the logical flow of an application. It allows values within variable/expressions to control flow through cases.";





            Random random = new Random();
            int randomindex;

            string answer = "";

            for (int i = 0; i < Definitions.Length; i++)
            {

                Clear();
                WriteLine($"Write the term for: ");
                randomindex = random.Next(0, Definitions.Length);


                WriteLine(Definitions[randomindex]);

                answer = ReadLine();



                if (answer.ToLower() == terms[randomindex])
                {
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("Correct!");

                    ResetColor();

                    score++;
                    ReadKey();
                }

                else
                {
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine($"Nope! The Answer is {terms[randomindex]}.");

                    ResetColor();

                    ReadKey();
                }
                Clear();
            }




        }

    }
}
