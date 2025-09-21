namespace Useraccesscheck;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== User Access Check (Activity 14) ===");
        
        Console.Write("Enter username: ");
        string username = Console.ReadLine() ?? "";

        Console.Write("Enter password: ");
        string password = Console.ReadLine() ?? "";

        Console.Write("Enter user ID: ");
        string? idInput = Console.ReadLine();
        if (!UInt32.TryParse(idInput, out uint userId))
        {
            Console.WriteLine("Invalid user ID. Please enter a valid number.");
            return;
        }

      
        bool userIsAdmin = userId > 65536;          
        bool usernameValid = username.Length >= 3;   

      
        bool passwordHasRequiredChar =
            password.Contains('$') || password.Contains('[') ||
            password.Contains(']') || password.Contains('@');

     
        int requiredLength = userIsAdmin ? 20 : 16;
        bool passwordHasRequiredLength = password.Length >= requiredLength;

        bool passwordValid = passwordHasRequiredChar && passwordHasRequiredLength;

      
        Console.WriteLine();
        if (usernameValid && passwordValid)
        {
            Console.WriteLine($"✅ Access granted. {(userIsAdmin ? "Admin" : "User")} login successful.");
        }
        else
        {
            Console.WriteLine("❌ Access denied because:");
            if (!usernameValid)
                Console.WriteLine("- Username must have at least 3 characters.");
            if (!passwordHasRequiredChar)
                Console.WriteLine("- Password must contain at least one of these: $, [, ], @");
            if (!passwordHasRequiredLength)
                Console.WriteLine($"- Password must be at least {requiredLength} characters long for a {(userIsAdmin ? "admin" : "user")}.");
        }
    }
}
