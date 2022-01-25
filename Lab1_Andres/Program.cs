using System;

namespace Lab1_Andres
{
    class Program
    {
        static void Main(string[] args)
        {

            static void showMenu() //used method to print a text menu for user to see
            {
                Console.WriteLine("\t\tMain Menu\n"); //use of \t to tabulate string and \n to jump to next line and make it more appealing
                Console.WriteLine("Make your selection from the following options:");
                Console.WriteLine("(To make selection just enter the number)\n"); //use of \n to jump to next line and make it more appealing
                Console.WriteLine("Option 1: Show all grades");
                Console.WriteLine("Option 2: Add grades");
                Console.WriteLine("Option 3: Get grade average from class");
                Console.WriteLine("Option 4: Show top grade");
                Console.WriteLine("Option 5: Show bottom grade");
                Console.WriteLine("Option 6: Remove student grade");
                Console.WriteLine("Option 7: Edit student grade");
                Console.WriteLine("Option 8: Exit");
            }

            static void showGrades(List<double> gradeList)
            {
                for (int i = 0; i < gradeList.Count; i++)
                {
                    Console.WriteLine("student " + (i + 1) + ": " + gradeList[i]);
                }
                Console.WriteLine("Press any key to continue:");
                Console.ReadKey();
            }

            static void addGrades(double grade, List<double> gradeList)
            {
                try //we are using try catch to get any errors/exceptions when we run the following code
                {
                    string answer = "y";
                    while (answer == "y") // this loop is used to get user to enter grades and decide if wants to continue or not
                    {
                        Console.WriteLine("Enter the grade:");
                        string gradeString = Console.ReadLine();
                        grade = double.Parse(gradeString);
                        gradeList.Add(grade);
                        Console.WriteLine("Do you want to add another grade (y/n)?");
                        answer = Console.ReadLine();
                    }
                }


                catch (Exception e) // catches the error and returns to main menu
                {
                    Console.WriteLine(e.Message); // Prints an error message of what went wrong
                    Console.WriteLine("Press any key to continue:");
                    Console.ReadKey();
                }

            }

            static void getAverage(List<double> gradeList)
            {
                double sum = 0;
                double average = 0;
                foreach (double value2 in gradeList) // loop used to calculate the average of the grades 
                {
                    sum += value2;
                    average = sum / gradeList.Count;
                }
                // section below is to let the result open until the user decides to go back to main menu
                Console.WriteLine("The class average is: " + average + "\n");
                Console.WriteLine("Press any key to continue:");
                Console.ReadKey();
            }

            static void topGrade(List<double> gradeList)
            {
                Console.WriteLine("The top grade is: " + gradeList.Max() + "\n");
                // section below is to let the result open until the user decides to go back to main menu
                Console.WriteLine("Press any key to continue:");
                Console.ReadKey();
            }

        }
    }
}
