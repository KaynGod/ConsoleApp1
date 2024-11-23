using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*public class User
{
    public int UserId { get; private set; }
    public string FullName { get; private set; }
    public string Email { get; private set; }
    public string PhoneNumber { get; private set; }
    public string Address { get; private set; }


    private string hashedPassword;

    public User(int userId, string fullName, string email)
    {
        if (string.IsNullOrWhiteSpace(fullName))

            throw new ArgumentException("FullName cannot be empty", nameof(fullName));

        if (string.IsNullOrWhiteSpace(email))

            throw new ArgumentException("Email cannot be empty", nameof(email));

        UserId = userId;
        FullName = fullName;
        Email = email;
    }

    public void SetPassword(string newPassword)
    {
        if (string.IsNullOrEmpty(newPassword))
        {
            throw new ArgumentException("Password cannot be empty", nameof(newPassword));
        }
        hashedPassword = HashPassword(newPassword);
    }
    public bool ValidatePassword(string inputPassword)
    {
        string hashedInputPassword = HashPassword(inputPassword);
        return hashedPassword == HashPassword(inputPassword);
    }
    private string HashPassword(string password)
    {
        using (SHA256 sha256Hash = SHA256.Create())
        {
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }
    }
}
/*
public static class PasswordValidationLibrary
{

    public static void SetUserPasswordAndValidate(User user)
    {
        Console.WriteLine("Please enter a password to set for your account:");

        string password = Console.ReadLine();

        try
        {
            user.SetPassword(password);
            Console.WriteLine("Password set successfully.");

            Console.WriteLine("Please re-enter your password to validate:");
            string passwordToValidate = Console.ReadLine();

            bool isValid = user.ValidatePassword(passwordToValidate);
            if (isValid)
                Console.WriteLine("Password validation successful!");
            else
                Console.WriteLine("Invalid password entered.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
    public static User CreateUser()
    {
        Console.WriteLine("Enter User ID (Numeric):");
        int userId = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Full Name:");
        string fullName = Console.ReadLine();

        Console.WriteLine("Enter Email:");
        string email = Console.ReadLine();

        Console.WriteLine("Enter PhoneNumber:");
        string PhoneNumber = Console.ReadLine();

        Console.WriteLine("Enter Address:");
        string Address = Console.ReadLine();

        var user = new User(userId, fullName, email);

        Console.WriteLine("User Created Successfully!");
        return user;
    }
    public static void DisplayUserDetails(User user)
    {
        Console.WriteLine($"User ID: {user.UserId}");
        Console.WriteLine($"Full Name: {user.FullName}");
        Console.WriteLine($"Email: {user.Email}");
        Console.WriteLine($"PhoneNumber: {user.PhoneNumber}");
        Console.WriteLine($"Address: {user.Address}");


    }
}


public static class UserInputValidator
{
    public static int GetValidatedUserId()
    {
        int userId;
        while (true)
        {
            Console.WriteLine("Enter User ID (Numeric, must be 100 or higher):");
            if (int.TryParse(Console.ReadLine(), out userId) && userId >= 100)
            {
                return userId;
            }
            Console.WriteLine("Invalid User ID. It must be a numeric value of 100 or higher.");
        }
    }
    public static string GetValidatedFullName()
    {
        while (true)
        {
            Console.WriteLine("Enter Full Name (must be at least 10 characters):");
            string fullName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(fullName) && fullName.Length >= 10)
            {
                return fullName;
            }
            Console.WriteLine("Invalid name. Full Name must be at least 10 characters long.");
        }
    }
    */
// User class inherits common properties from Person

public class User : Person
{
    public int UserId { get; private set; }
    private string hashedPassword;

    // Method to set and validate User ID
    public void SetUserId(int userId)
    {
        if (userId < 100)
        {
            throw new ArgumentException("User ID must be 100 or greater.");
        }
        UserId = userId;
    }

    // Hashing logic encapsulated in a private method

    private string HashPassword(string password)
    {
        using (var sha256 = SHA256.Create())
        {
            var bytes = Encoding.UTF8.GetBytes(password);
            return Convert.ToBase64String(sha256.ComputeHash(bytes));
        }
    }
        // Method to set and validate Password

        public void SetPassword(string newPassword, string confirmPassword)
        {
            if (!Regex.IsMatch(newPassword, @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$"))
            {
                throw new ArgumentException("Password must be at least 8 characters, including letters, numbers, and special characters.");
            }

            if (newPassword != confirmPassword)
            {
                throw new ArgumentException("Passwords do not match.");
            }

            hashedPassword = HashPassword(newPassword);
        }
    // Method to validate Password
    public bool ValidatePassword(string inputPassword)
    {
        return hashedPassword == HashPassword(inputPassword);
    }
}