using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class UserManagement 
{
    public static User CreateUser()
    {
        var user = new User();

        try
        {
            Console.Write("Enter User ID (Numeric): ");
            user.SetUserId(int.Parse(Console.ReadLine()));

            Console.Write("Enter Full Name: ");
            user.SetFullName(Console.ReadLine());

            Console.Write("Enter Email: ");
            user.SetEmail(Console.ReadLine());

            Console.Write("Enter Phone Number: ");
            user.SetPhoneNumber(Console.ReadLine());

            Console.Write("Enter Address (Optional): ");
            user.SetAddress(Console.ReadLine());

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            Console.Write("Re-enter Password: ");
            string confirmPassword = Console.ReadLine();

            user.SetPassword(password, confirmPassword);

            Console.WriteLine("User created successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        return user;
    }

    public static void DisplayUserDetails(User user)
    {
        Console.WriteLine("\nUser Details:");
        Console.WriteLine($"User ID: {user.UserId}");
        Console.WriteLine($"Full Name: {user.FullName}");
        Console.WriteLine($"Email: {user.Email}");
        Console.WriteLine($"Phone Number: {user.PhoneNumber}");
        Console.WriteLine($"Address: {user.Address}");
        Console.WriteLine("\nUser Created Successfully!");
    }
}

