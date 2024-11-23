using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    //public class User
    //{
    //    public int UserId { get; }
    //    public string FullName { get; }
    //    public string Email { get; }
    //    public string Password { get; }
    //    public string PhoneNumber { get; }
    //    public string Address { get; }

    //    public User(int userId, string fullName, string email, string password, string phoneNumber, string address)
    //    {
    //        UserId = userId;
    //        FullName = fullName;
    //        Email = email;
    //        Password = password;
    //        PhoneNumber = phoneNumber;
    //        Address = address;
    //    }
    //}

    //public class Bundle
    //{
    //    public int BundleId { get; }
    //    public string BundleName { get; }
    //    public string Description { get; }
    //    public decimal Price { get; }
    //    public IReadOnlyList<Item> ItemsIncluded { get; }

    //    public Bundle(int bundleId, string bundleName, string description, decimal price, List<Item> itemsIncluded)
    //    {
    //        BundleId = bundleId;
    //        BundleName = bundleName;
    //        Description = description;
    //        Price = price;
    //        ItemsIncluded = itemsIncluded.AsReadOnly();
    //    }
    //}

    //public class Item
    //{
    //    public int ItemId { get; }
    //    public string ItemName { get; }
    //    public string Category { get; }
    //    public decimal Price { get; }
    //    public string Description { get; }

    //    public Item(int itemId, string itemName, string category, decimal price, string description)
    //    {
    //        ItemId = itemId;
    //        ItemName = itemName;
    //        Category = category;
    //        Price = price;
    //        Description = description;
    //    }
    //}

    //public class Order
    //{
    //    public int OrderId { get; }
    //    public int UserId { get; }
    //    public IReadOnlyList<Item> OrderedItems { get; }
    //    public DateTime OrderDate { get; }
    //    public string OrderStatus { get; }
    //    public decimal TotalAmount { get; }

    //    public Order(int orderId, int userId, List<Item> orderedItems, DateTime orderDate, string orderStatus, decimal totalAmount)
    //    {
    //        OrderId = orderId;
    //        UserId = userId;
    //        OrderedItems = orderedItems.AsReadOnly();
    //        OrderDate = orderDate;
    //        OrderStatus = orderStatus;
    //        TotalAmount = totalAmount;
    //    }
    //}

    //public class Payment
    //{
    //    public int PaymentId { get; }
    //    public int OrderId { get; }
    //    public string PaymentMethod { get; }
    //    public DateTime PaymentDate { get; }
    //    public decimal AmountPaid { get; }
    //    public bool IsPaymentSuccessful { get; }

    //    public Payment(int paymentId, int orderId, string paymentMethod, DateTime paymentDate, decimal amountPaid, bool isPaymentSuccessful)
    //    {
    //        PaymentId = paymentId;
    //        OrderId = orderId;
    //        PaymentMethod = paymentMethod;
    //        PaymentDate = paymentDate;
    //        AmountPaid = amountPaid;
    //        IsPaymentSuccessful = isPaymentSuccessful;
    //    }
    //}

    //public class AdminDashboard
    //{
    //    public int TotalUsers { get; }
    //    public int TotalOrders { get; }
    //    public decimal TotalRevenue { get; }
    //    public int PendingOrders { get; }
    //    public int CompletedOrders { get; }

    //    public AdminDashboard(int totalUsers, int totalOrders, decimal totalRevenue, int pendingOrders, int completedOrders)
    //    {
    //        TotalUsers = totalUsers;
    //        TotalOrders = totalOrders;
    //        TotalRevenue = totalRevenue;
    //        PendingOrders = pendingOrders;
    //        CompletedOrders = completedOrders;
    //    }
    //}

    //public class TrackOrder
    //{
    //    public int OrderId { get; }
    //    public DateTime OrderDate { get; }
    //    public string CurrentStatus { get; }
    //    public string DeliveryEstimate { get; }

    //    public TrackOrder(int orderId, DateTime orderDate, string currentStatus, string deliveryEstimate)
    //    {
    //        OrderId = orderId;
    //        OrderDate = orderDate;
    //        CurrentStatus = currentStatus;
    //        DeliveryEstimate = deliveryEstimate;
    //    }
    //}

    //public class DataAnalysis
    //{
    //    public int TotalSales { get; }
    //    public decimal AverageOrderValue { get; }
    //    public int TotalItemsSold { get; }
    //    public int MonthlyActiveUsers { get; }
    //    public IReadOnlyDictionary<string, int> SalesByCategory { get; }

    //    public DataAnalysis(int totalSales, decimal averageOrderValue, int totalItemsSold, int monthlyActiveUsers, Dictionary<string, int> salesByCategory)
    //    {
    //        TotalSales = totalSales;
    //        AverageOrderValue = averageOrderValue;
    //        TotalItemsSold = totalItemsSold;
    //        MonthlyActiveUsers = monthlyActiveUsers;
    //        SalesByCategory = new ReadOnlyDictionary<string, int>(salesByCategory);
    //    }
    //}

    class Program
    {  
    static void Main(string[] args)
        {
            // Get user details using the library
            var userDetails = UserValidator.GetUserDetails();

            // Display the valid user details
            Console.WriteLine("\nUser Details:");
            Console.WriteLine($"User ID: {userDetails.userId}");
            Console.WriteLine($"Full Name: {userDetails.fullName}");
            Console.WriteLine($"Email: {userDetails.email}");
            Console.WriteLine($"Phone Number: {userDetails.phoneNumber}");
            Console.WriteLine($"Address: {userDetails.address}");

            // Success message
            Console.WriteLine("\nUser Created Successfully!");
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();

        }
    }
}
