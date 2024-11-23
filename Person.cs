using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class Person
{

    public string FullName { get; private set; }
    public string Email { get; private set; }
    public string PhoneNumber { get; private set; }
    public string Address { get; private set; }

    // Method to set and validate Full Name

    public void SetFullName(string fullName)
    {
        if (string.IsNullOrWhiteSpace(fullName) || fullName.Split(' ').Length < 2)
        {
            throw new ArgumentException("Full name must contain at least 2 words.");
        }
        FullName = fullName;
    }

    // Method to set and validate Email

    public void SetEmail(string email)
    {
        if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
        {
            throw new ArgumentException("Invalid email format.");
        }
        Email = email;
    }

    // Method to set and validate Phone Number

    public void SetPhoneNumber(string phoneNumber)
    {
        if (!Regex.IsMatch(phoneNumber, @"^\d{10,15}$"))
        {
            throw new ArgumentException("Phone number must be between 10 and 15 digits.");
        }
        PhoneNumber = phoneNumber;

    }        
    
    // Method to optionally set Address
    public void SetAddress(string address)
    {
        if (!string.IsNullOrEmpty(address) && address.Length < 5)
        {
            throw new ArgumentException("Address must be at least 5 characters if provided.");
        }
        Address = address;
    }
}
