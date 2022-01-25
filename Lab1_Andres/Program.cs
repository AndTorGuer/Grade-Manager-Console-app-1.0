using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// Claim Academy
/// Andres Torres Guerrero
/// Lab 1 - Grades Manager
/// </summary>
namespace Lab1_Andres
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = 0;
            List<double> gradeList = new List<double>(); // list to be used to store the grades        

            int selection = 10;
            while (selection < 12) // this section encapsulates the desicion making through methods
            {
                showMenu();
                string choice = Console.ReadLine();
                int choice2 = int.Parse(choice);// takes user input converts it to an integer value to be used in the switch selection

                switch (choice2)
                {
                    case 1:
                        showGrades(gradeList);
                        break;

                    case 2:
                        addGrades(grade, gradeList);
                        break;

                    case 3:
                        getAverage(gradeList);
                        break;

                    case 4:
                        topGrade(gradeList);
                        break;

                    case 5:
                        bottomGrade(gradeList);
                        break;

                    case 6:
                        removeGrade(gradeList);
                        break;

                    case 7:
                        editGrade(gradeList);
                        break;

                    case 8:
                        if (getExit() == true)
                        {
                            Environment.Exit(0); // handles the termination of the program 
                            break;
                        }

                        else
                        {
                            break;
                        }


                    default: // handles exceptions were the user selection was invalid and brings up the main menu
                        Console.WriteLine("Invalid entry\nBack to Main Menu");
                        break;
                }
            }

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

            static void bottomGrade(List<double> gradeList)
            {
                Console.WriteLine("The bottom grade is: " + gradeList.Min() + "\n");
                // section below is to let the result open until the user decides to go back to main menu
                Console.WriteLine("Press any key to continue:");
                Console.ReadKey();
            }

            static void removeGrade(List<double> gradeList)
            {
                string answer = "y";
                try
                {
                    while (answer == "y") // this loop is used to get user to remove grades and decide if wants to continue or not
                    {
                        showGrades(gradeList);
                        Console.WriteLine("Enter the studen# for the grade to be removed");
                        string indexString = Console.ReadLine();
                        int index = int.Parse(indexString);
                        gradeList.RemoveAt(index - 1);
                        Console.WriteLine("Do you want to remove another grade (y/n)?");
                        answer = Console.ReadLine();
                    }
                    Console.WriteLine("This is your new grade list:"); // shows user list with changes made 
                    showGrades(gradeList); // modified list
                    // section below is to let the result open until the user decides to go back to main menu
                    Console.WriteLine("\n Press any key to continue:");
                    Console.ReadKey();
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Press any key to continue:");
                    Console.ReadKey();
                }

            }

            static void editGrade(List<double> gradeList)
            {
                string answer = "y";
                try
                {
                    while (answer == "y")
                    {   // this loop is used to get user to enter grades that wants
                        // to replace/edit and decide if you want to continue or not
                        showGrades(gradeList);
                        Console.WriteLine("Enter the student# for grade to be edited");
                        string indexString = Console.ReadLine();
                        int index = int.Parse(indexString);

                        Console.WriteLine("Enter the new grade");
                        string newGradeString = Console.ReadLine();
                        double newGrade = double.Parse(newGradeString);

                        gradeList[index - 1] = newGrade;

                        Console.WriteLine("Do you want to edit another grade (y/n)?");
                        answer = Console.ReadLine();
                    }
                    Console.WriteLine("This is your new grade list:"); // shows user list with changes made 
                    showGrades(gradeList); // modified list
                    // section below is to let the result open until the user decides to go back to main menu
                    Console.WriteLine("\n Press any key to continue:");
                    Console.ReadKey();
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Press any key to continue:");
                    Console.ReadKey();
                }
            }

            static bool getExit()
            {
                string y = "y",
                       n = "n";
                bool answer = false;
                try
                {
                    Console.WriteLine("Do you want to exit (y/n)?"); // desicion making part, giving user a second chance to think
                    string input = Console.ReadLine();

                    if (input.Equals(y)) // loop returns value depending choice to give to out side funtion
                    {
                        answer = true;
                    }

                    else if (input.Equals(n))
                    {
                        answer = false;
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Press any key to continue:");
                    Console.ReadKey();
                }
                return answer;
            }
        }
    }
}
