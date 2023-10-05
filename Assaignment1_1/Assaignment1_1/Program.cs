using System;

class Program
{
    static int nums; // Declare nums outside Main() to make it accessible to all methods.
    static string[] firstNames;
    static string[] lastNames;
    static double[] marks;

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of friends to store data:");
        nums = int.Parse(Console.ReadLine());

        // Initialize arrays with the specified size.
        firstNames = new string[nums];
        lastNames = new string[nums];
        marks = new double[nums];

        FriendsInput();
        DisplayFriendsInfo();
    }

    static void FriendsInput()
    {
        // For loop to take the users' input
        Console.WriteLine("Friend's Information Desk");
        for (int i = 0; i < nums; i++)
        {
            Console.WriteLine("Enter First Name of Friend " + (i + 1));
            string firstName = Console.ReadLine();
            firstNames[i] = firstName;

            Console.WriteLine("Enter Last Name of Friend " + (i + 1));
            string lastName = Console.ReadLine();
            lastNames[i] = lastName;

            Console.WriteLine("Enter Last Term GPA of Friend " + (i + 1));
            double lastTermGpa = double.Parse(Console.ReadLine());
            marks[i] = lastTermGpa;

            Console.WriteLine("Enter Date of Birth of Friend " + (i + 1) + " (YYYY-MM-DD)");
            string dob = Console.ReadLine();
        }
    }

    static void DisplayFriendsInfo()
    {
        double sum = 0;
        double highestGpa = 0;
        double averageGpa = 0;
        string highestScorer = "";

        for (int i = 0; i < nums; i++)
        {
            string firstName = firstNames[i];
            string lastName = lastNames[i];
            double score = marks[i];

            sum += score;
            if (score > highestGpa)
            {
                highestGpa = score;
                highestScorer = firstName + " " + lastName;
            }
        }
        averageGpa = sum / nums;

        Console.WriteLine("Highest Scorer Name and GPA \n");

        Console.WriteLine("Full Name: " + highestScorer);
        Console.WriteLine("Highest GPA: " + highestGpa);
        Console.WriteLine("Average GPA: " + averageGpa);
        Console.WriteLine("Current Time: " + DateTime.Now);
    }
}
