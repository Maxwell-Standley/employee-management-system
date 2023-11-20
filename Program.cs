using System;

namespace YourProjectName
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the DataAccess class with your connection string
            string connectionString = "Server=(localdb)\\EmpMngSystem;Integrated Security=True;Initial Catalog=EmpMngSystem;";
            DataAccess dataAccess = new DataAccess(connectionString);

            // Your existing code starts here
            string Name;
            string position;
            string dept;
            string userSelection;
            string salary;
            string userAnswer;
            string age;
            string userChoiceForRestart;
            string employeeIDNumber;
            bool userBoolAnswer;
            int switchCaseSelection;

        beginning:
            // Input & Output?
            Console.WriteLine("Welcome to Employee Updater");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1 for New Employee");
            Console.WriteLine("2 for updating an existing employee");
            Console.WriteLine("3 Delete an existing employee from the database");
            Console.WriteLine("4 for searching for an employee");
            Console.WriteLine("5 to close the program");
            Console.WriteLine("Please select an option: ");

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            userSelection = keyInfo.KeyChar.ToString();

            if (int.TryParse(userSelection, out switchCaseSelection))
            {

            }
            else
            {
                Console.WriteLine("Please try again. That is not a valid choice.");
                Console.WriteLine("Please select an option: ");
                userSelection = keyInfo.KeyChar.ToString();
            }
        switchLoop:
            switch (switchCaseSelection)
            {
                case 1:
                    Console.WriteLine("\n Please enter the name of the new employee: ");
                    Name = Console.ReadLine();
                    Console.WriteLine("Please enter the age of the new employee: ");
                    age = Console.ReadLine();
                    Console.WriteLine("Please write the position title: ");
                    position = Console.ReadLine();
                    Console.WriteLine("Please write the salary per year of the employee here: ");
                    salary = Console.ReadLine();
                    Console.WriteLine("Enter the department they work in here: ");
                    dept = Console.ReadLine();
                    Console.WriteLine("You have entered this as the entries. Are these correct?: ");
                    Console.WriteLine("Name: " + Name);
                    Console.WriteLine("Position: " + position);
                    Console.WriteLine("Salary per year: " + salary);
                    Console.WriteLine("Department: " + dept);
                    Console.WriteLine("Please press Y if correct or N if incorrect: ");
                    userAnswer = Console.ReadLine();
                    if (userAnswer == "Y")
                    {
                        userBoolAnswer = true;
                    }
                    else { userBoolAnswer = false; }

                    if (userBoolAnswer)
                    {
                        Console.WriteLine("Thank you.");
                        Console.WriteLine("Is there anything else you would like to do today?");
                        Console.WriteLine("If yes, press Y. If no, press N.");
                        Console.WriteLine("Entry: ");
                        userChoiceForRestart = Console.ReadLine();

                        if (userChoiceForRestart == "Y")
                        {
                            goto beginning;
                        }
                        else
                        {
                            goto closeProgram;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Let's try again. ");
                        goto switchLoop;
                    }
                //updating an existing employee
                case 2:
                    Console.WriteLine("Which employee would you like to update? ");
                    Console.WriteLine("Please enter the employee ID. If it is not valid, please try again.");
                    employeeIDNumber = Console.ReadLine();

                    // Retrieve data here? That's a tomorrow issue

                    break;

                case 3:
                    Console.WriteLine("Which employee would you like to delete?");
                    Console.WriteLine("Please enter the employee's ID here.");
                    employeeIDNumber = Console.ReadLine();

                    break;
                case 4:
                    Console.WriteLine("Which employee would you like to search for? ");
                    Console.WriteLine("Please enter the employee's ID number here.");
                    employeeIDNumber = Console.ReadLine();

                    // Retrieve and display data here

                    break;

                case 5:
                closeProgram:

                    Console.WriteLine("Thank you for using our program. Goodbye.");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid selection.");
                    break;

                    dataAccess.Dispose();
            }
        }
    }
}
