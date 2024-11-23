using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class UserValidator
{
    public static int GetUserId()
    {
        int userId;
        while (true)
        {
            try
            {
                Console.Write("Enter User ID (Numeric): ");
                userId = int.Parse(Console.ReadLine());

                if (userId < 100)
                {
                    throw new ArgumentException("User ID must be 100 or greater.");
                }

                return userId;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine("Please try again.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter a numeric value.");
            }
        }
    }

    public static string GetFullName()
    {
        string fullName;
        while (true)
        {
            try
            {
                Console.Write("Enter Full Name: ");
                fullName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(fullName) || fullName.Length < 10)
                {
                    throw new ArgumentException("Full name must be at least 10 characters long.");
                }

                return fullName;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine("Please try again.");
            }
        }
    }

    public static string GetEmail()
    {
        string email;
        while (true)
        {
            try
            {
                Console.Write("Enter Email: ");
                email = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
                {
                    throw new ArgumentException("Invalid email format.");
                }

                return email;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine("Please try again.");
            }
        }
    }

    public static string GetPhoneNumber()
    {
        string phoneNumber;
        while (true)
        {
            try
            {
                Console.Write("Enter Phone Number: ");
                phoneNumber = Console.ReadLine();

                if (phoneNumber.Length != 10 || !phoneNumber.All(char.IsDigit))
                {
                    throw new ArgumentException("Phone number must be a valid 10-digit number.");
                }

                return phoneNumber;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine("Please try again.");
            }
        }
    }

    public static string GetAddress()
    {
        Console.Write("Enter Address (optional): ");
        return Console.ReadLine() ?? "N/A";
    }

    // Main method to call all validations and return user details as a tuple
    public static (int userId, string fullName, string email, string phoneNumber, string address) GetUserDetails()
    {
        int userId = GetUserId();
        string fullName = GetFullName();
        string email = GetEmail();
        string phoneNumber = GetPhoneNumber();
        string address = GetAddress();

        return (userId, fullName, email, phoneNumber, address);
    }
}
