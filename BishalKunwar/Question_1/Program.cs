namespace Question_1
{
    internal class Program
    {

        static int nums; // Declare nums outside Main() to make it accessible to all methods.
        static string[] firstNames;
        static string[] lastNames;
        static double[] marks;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of friends to store data:");
            nums = int.Parse(Console.ReadLine());

            // Initialize arrays to store friend information with the specified size.
            firstNames = new string[nums];
            lastNames = new string[nums];
            marks = new double[nums];

            FriendsInput(); // Call the method to input friend data.
            DisplayFriendsInfo(); // Call the method to display friend information.
        }

        static void FriendsInput()
        {
            // For loop to take the users' input for each friend.
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
                string dob = Console.ReadLine(); // Note: The date of birth is collected but not stored.
            }
        }

        static void DisplayFriendsInfo()
        {
            double sum = 0;
            double highestGpa = 0;
            double averageGpa = 0;
            string highestScorer = "";

            // Calculate sum, highest GPA, and average GPA for all friends.
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

            Console.WriteLine("Full Name: " + highestScorer); // Display the highest scorer's name.
            Console.WriteLine("Highest GPA: " + highestGpa); // Display the highest GPA.
            Console.WriteLine("Average GPA: " + averageGpa); // Display the average GPA.
            Console.WriteLine("Current Time: " + DateTime.Now); // Display the current date and time.
        }
    }
}




