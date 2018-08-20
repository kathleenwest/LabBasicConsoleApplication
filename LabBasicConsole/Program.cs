using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabBasicConsole
{
    /// <summary>
    /// Program to demonstrate user interactions and mathematical operations
    /// LabBasicConsole
    /// Kathleen West
    /// </summary>
    class Program
    {
        /// <summary>
        /// Basic Console Apps, Variables, Conversions and Mathematical Operations
        /// </summary>
        /// <param name="args">None processed</param>
        static void Main(string[] args)
        {
            // Basic User Interaction and Parsing Data

            #region userinteractions

            UserName();               // Ask for Username and Print
            UserDOB();                // Ask for User DOB and Print
            UserID();                 // Ask for User ID and Print
            UserSalary();             // Ask for User Salary and Print
            UserEmploymentStatus();   // Ask for User Employment Status and Print 

            #endregion userinteractions

            // Mathematical Operations

            #region mathoperations

            // Problem 1

            Console.WriteLine("The area of a rectangle with width of 6.5 and a height of 3 is: {0}", CalculateAreaRectangle(6.5,3));

            // Problem 2

            Console.WriteLine("The area of a circle with a radius of 7.1 is: {0}", CalculateAreaCircle(7.1));

            // Problem 3

            Console.WriteLine("3A. (2, 5) and (-3, 7) Distance is: {0}", CalculatePointDistance(2,5,-3,7));
            Console.WriteLine("3B. (-5, 4) and (1, 0) Distance is: {0}", CalculatePointDistance(-5, 4, 1, 0));
            Console.WriteLine("3C. (6, -2) and (-4, -6) Distance is: {0}", CalculatePointDistance(6, -2, -4, -6));

            #endregion mathoperations

            // Prompt User to Quit
            Console.Write("Press <ENTER> to quit...");
            Console.ReadLine();
        }

        #region MethodsUserInteraction

        /// <summary>
        /// Prompt the user for their name
        /// Prints the user name
        /// </summary>
        private static void UserName()
        {            
            string name = string.Empty;   // Input string      

            // User Prompt Loop
            while (name == string.Empty)
            {
                // Prompt User and Read Input
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Please enter your name: ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                name = Console.ReadLine();
            } // end of while loop

            // Print the Validated User Name
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hello, " + name);

        } // end of UserName()

        /// <summary>
        /// Prompt the user for their birthday
        /// Print the usr birthday
        /// </summary>
        private static void UserDOB()
        {
            string userInput = string.Empty;     // Input string
            DateTime dob = DateTime.MinValue;    // Parsed Date of Birth
            bool ok = false;                     // For While Loop

            // User Prompt Loop
            while (!ok)
            {
                // Prompt User and Read Input
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Please enter your date of birth: ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                userInput = Console.ReadLine();

                // Validate the user input
                if (DateTime.TryParse(userInput, out dob)) // Valid
                {
                    ok = true;
                }

                else // Invalid
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("That is an invalid birthday!");
                } 
            } // end of while loop

            // Print the User Birthday to the Screen
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Your birthday is " + dob.ToShortDateString() + " which was a " + dob.DayOfWeek);

        } // end of UserDOB

        /// <summary>
        /// Prompt the user for their ID
        /// Print the user ID
        /// </summary>
        private static void UserID()
        {
            string userInput = string.Empty;     // Input string
            int userID = 0;                      // Parsed User ID
            bool ok = false;                     // For While Loop

            // User Prompt Loop
            while (!ok)
            {
                // Prompt User and Read Input
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Please enter your user ID: ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                userInput = Console.ReadLine();

                // Validate the User Input
                if (Int32.TryParse(userInput, out userID) && userID >= 0) // Valid
                {
                    ok = true;
                }

                else // Invalid
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("That is an invalid number.");
                } 
            } // end of while loop

            // Print the user id to the console window
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Your user id is " + userID.ToString());

        } // end of UserID

        /// <summary>
        /// Prompts the user for their salary
        /// Prints the user salary
        /// </summary>
        private static void UserSalary()
        {
            string userInput = string.Empty;     // Input string
            double salary = 0.0;                 // Parsed User ID
            bool ok = false;                    // For While Loop

            // User Prompt Loop
            while (!ok)
            {
                // Prompt User and Read Input
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Please enter your salary: ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                userInput = Console.ReadLine();

                //Validate the User Input 
                if (Double.TryParse(userInput, out salary) && salary >= 0.0) // Valid
                {
                    ok = true;
                }

                else // Invalid
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("That is an invalid number.");
                } 
            } // end of while loop

            // Print the validated user salary to the console window
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Your salary is " + salary.ToString());

        } // end of UserSalary()

        /// <summary>
        /// Prompts the user for their employment status
        /// Prints the user employment status
        /// </summary>
        private static void UserEmploymentStatus()
        {
            string userInput = string.Empty;     // Input string 
            bool employmentStatus = false;       // Parsed Employment Status
            bool ok = false;                     // For While Loop

            // User Prompt Loop
            while (!ok)
            {
                // Prompt User and Read Input
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Are you employed (true/false): ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                userInput = Console.ReadLine();

                // Validate the User Input
                if (Boolean.TryParse(userInput, out employmentStatus)) // Valid
                {
                    ok = true;
                } 

                else // InValid
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("That is an invalid answer (true or false).");
                } 
            } // end of while loop

            // Print the Validated Employment Status to Console Window
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Your employment status is " + employmentStatus.ToString());

        } // end of UserEmploymentStatus()

        #endregion MethodsUserInteraction

        #region MethodsMathOperations

        /// <summary>
        /// Calculates the area of a rectangle
        /// </summary>
        /// <param name="width">double width of rectangle</param>
        /// <param name="height">double height of rectangle</param>
        /// <returns>double area of rectangle</returns>
        private static double CalculateAreaRectangle(double width, double height)
        {
            return width * height;
        }

        /// <summary>
        /// Returns the area for a circle
        /// Formula for circle area is pi * radius2
        /// </summary>
        /// <param name="radius">double radius of the circle</param>
        /// <returns>double area of the circle</returns>
        private static double CalculateAreaCircle(double radius)
        {
            return Math.PI * radius * radius;
        }

        /// <summary>
        /// Calculates distance between two points (x1, y1) and (x2,y2)
        /// </summary>
        /// <param name="x1">double x coordinate of first point pair</param>
        /// <param name="y1">double y coordinate of first point pair</param>
        /// <param name="x2">double x coordinate of second point pair</param>
        /// <param name="y2">double y coordinate of second point pair</param>
        /// <returns>double distance between the two points</returns>
        private static double CalculatePointDistance(double x1, double y1, double x2, double y2)
        {            
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }

        #endregion MethodsMathOperations
    }
}
