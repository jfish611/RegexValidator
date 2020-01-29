using System;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            int min;
            int max;
            int sum;

            int studentNumber = GetInt("Please enter the number of students: ");

            int[] scores = new int[studentNumber];
            //string[] classNames = new string[studentNumber];
            //string[] foodFavorite = new string[studentNumber];
            //string[] previousTitle = new string[studentNumber];
            for (int i = 0; i < studentNumber; i++)
            {
                Console.WriteLine($"Please enter the score for student number {(i + 1)}.");
                scores[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine(".....................................................................");
            Console.WriteLine();
            Console.Write("The class scores are: \t");
            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write(scores[i] + ", ");
            }

            /////// MIN/MAX ///////////////////////////////////////////////////////////////////////////

            min = scores[0];
            max = scores[0];
            sum = 0;
            for (int i = 0; i < scores.Length; i++)
            {


                sum += scores[i];
                if (scores[i] < min)
                {
                    min = scores[i];
                }
                else if (scores[i] > max)
                {
                    max = scores[i];
                }
            }
            Console.WriteLine($"\n\nThe MIN score is: \t{min}");
            Console.WriteLine("The AVG score is:\t" + ((double)sum / scores.Length));
            Console.WriteLine($"The MAX score is: \t{max}");

            Console.WriteLine(".....................................................................");

            ///////////////////////////////////////////////////////////////////////////////////////////////////
            ///
            bool keepGoing = true;
            while (keepGoing)
            {
                Console.WriteLine("Do you want to change a score? y/n?");
                if (Console.ReadLine() == "y")
                {

                    int changeIndex = GetInt("Which score do you want to change?") - 1;
                    int newScore = GetInt("What do you want to change it to?");
                    scores[changeIndex] = newScore;
                }
                else if (Console.ReadLine() == "n")
                {
                    keepGoing = false;
                }

                for (int i = 0; i < scores.Length; i++)
                {
                    sum += scores[i];
                    if (scores[i] < min)
                    {
                        min = scores[i];
                    }
                    else if (scores[i] > max)
                    {
                        max = scores[i];
                    }
                }

                Console.WriteLine("......................................................................");
                Console.Write("The new class scores are: \t");

                min = scores[0];
                max = scores[0];
                sum = 0;
                for (int i = 0; i < scores.Length; i++)
                {
                    Console.Write(scores[i] + ", ");
                }
                for (int i = 0; i < scores.Length; i++)
                {
                    sum += scores[i];
                    if (scores[i] < min)
                    {
                        min = scores[i];
                    }
                    else if (scores[i] > max)
                    {
                        max = scores[i];
                    }

                }
                Console.WriteLine($"\n\nThe new MIN score is: \t{min}");
                Console.WriteLine("The new AVG score is:\t" + ((double)sum / scores.Length));
                Console.WriteLine($"The new MAX score is: \t{max}");


                //while (true)
                //{
                //    Console.WriteLine("Please enter student's name.");
                //    classNames[studentNumber] = Console.ReadLine();

                //    Console.WriteLine("Please enter student's favorite food.");
                //    foodFavorite[studentNumber] = Console.ReadLine();

                //    Console.WriteLine("Please enter previous title.");
                //    previousTitle[studentNumber] = Console.ReadLine();

                //    studentNumber++;
                //}
            }

            //METHODS
            //Method headers have 3+ parts:
            //1. Access Modifier
            //2. Static or Not-Static (if called from a static method, it must be static)
            //3. Return type 
            //4. name (Pascal - starts with capital)
            //5. argument list in parentheses
            // *Signature* is name + argument list

            static int GetInt(string prompt)
            {
                Console.Write(prompt);
                return int.Parse(Console.ReadLine());

            }

        }
    }
}
