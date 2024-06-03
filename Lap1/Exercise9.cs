using System;

class WeekendChecker
{
    static void Main(string[] args)
    {
        int choice;

        Console.WriteLine("Enter a number between 1 and 7 to represent a day of the week: ");

        // Input validation (optional)
        // You can add a loop to keep prompting the user until a valid input is entered
        choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Today is Monday");
                break;
            case 2:
                Console.WriteLine("Today is Tuesday");
                break;
            case 3:
                Console.WriteLine("Today is Wednesday");
                break;
            case 4:
                Console.WriteLine("Today is Thursday");
                break;
            case 5:
                Console.WriteLine("Today is Friday");
                break;
            case 6:
                Console.WriteLine("Today is Saturday");
                break;
            case 7:
                Console.WriteLine("Today is Sunday");
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 7.");
                break;
        }
    }
}
