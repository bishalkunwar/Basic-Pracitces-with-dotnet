namespace Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**Welcome to the Airport Parking Calculator**");
            Console.WriteLine("Choose parking type:");
            Console.WriteLine("1. Long-Term Parking Services");
            Console.WriteLine("2. Short-Term Parking Services");
            Console.Write("Make your choice (1 or 2): ");

            // Get the user's choice (1 for Long-Term, 2 for Short-Term)
            int choice = int.Parse(Console.ReadLine());

            // Use a switch statement to handle the user's choice
            switch (choice)
            {
                case 1:
                    CalculateLongTermParkingCharge(); // Calculate charges for Long-Term parking
                    break;
                case 2:
                    CalculateShortTermParkingCharge(); // Calculate charges for Short-Term parking
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose 1 or 2.");
                    break;
            }
        }

        static void CalculateLongTermParkingCharge()
        {
            Console.Write("Enter the number of days parked: ");
            int days = int.Parse(Console.ReadLine());

            // Calculate Long-Term Parking charge: $25 one-time fee + $40 per day
            double charge = 25.0 + (40.0 * days);

            Console.WriteLine($"Your Long-Term Parking charge is: ${charge:F2}");
        }

        static void CalculateShortTermParkingCharge()
        {
            Console.Write("Enter the hours parked: ");
            int hours = int.Parse(Console.ReadLine());

            if (hours > 24)
            {
                Console.WriteLine("Maximum parking duration for Short-Term parking is 24 hours.");
                return;
            }

            // Calculate Short-Term Parking charge:
            // $4.00 for the first hour + $3.00 for each additional hour (rounded up to the nearest hour)
            // Maximum charge is $40.00
            double charge = 4.0 + (Math.Ceiling((hours - 1) / 1.0) * 3.0);
            charge = Math.Min(charge, 40.0);

            Console.WriteLine($"Your Short-Term Parking charge is: ${charge:F2}");
        }
    }
}