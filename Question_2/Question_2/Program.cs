internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("**Welcome to the Airport Parking Calculator**");
        Console.WriteLine("Choose parking type:");
        Console.WriteLine("1. Long-Term Parking Services");
        Console.WriteLine("2. Short-Term Parking Services");
        Console.Write("Make your choice (1 or 2): ");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                CalculateLongTermParkingCharge();
                break;
            case 2:
                CalculateShortTermParkingCharge();
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

        // Calculate Long-Term Parking charge
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

        // Calculate Short-Term Parking charge
        double charge = 4.0 + (Math.Ceiling((hours - 1) / 1.0) * 3.0);
        charge = Math.Min(charge, 40.0); // Maximum charge is $40.00

        Console.WriteLine($"Your Short-Term Parking charge is: ${charge:F2}");
    }

}

