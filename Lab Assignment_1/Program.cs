using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Question1();
        Question2();
        Question3();
        Question4();
        Question5();
        Question6();
        Question7();
        Question8();
        Question9();
        Question10();
    }
    // Question 1: Shopping Cart
    static void Question1()
    {
        double[] itemPrices = new double[] { 500, 700, 800, 1200, 1000 };
        double totalPrice = 0;
        foreach (double price in itemPrices)
        {
            totalPrice += price;
        }
        double discount = (totalPrice > 3000) ? totalPrice * 0.10 : 0;
        double finalPrice = totalPrice - discount;
        Console.WriteLine("Question 1:");
        Console.WriteLine($"Total Price: Rs. {totalPrice}");
        Console.WriteLine($"Discount: Rs. {discount}");
        Console.WriteLine($"Final Price: Rs. {finalPrice}\n");
    }
    // Question 2: Temperature Conversion
    static void Question2()
    {
        Console.WriteLine("Question 2:");
        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;
        if (celsius < 0)
        {
            Console.WriteLine("Warning: Freezing temperatures!");
        }
        Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}\n");
    }
    // Question 3: ATM Simulation
    static void Question3()
    {
        double balance = 10000;
        Console.WriteLine("Question 3:");
        Console.WriteLine("1. Check Balance");
        Console.WriteLine("2. Deposit Money");
        Console.WriteLine("3. Withdraw Money");
        Console.Write("Choose an option (1-3): ");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                Console.WriteLine($"Current Balance: Rs. {balance}");
                break;
            case 2:
                Console.Write("Enter amount to deposit: Rs. ");
                double deposit = Convert.ToDouble(Console.ReadLine());
                balance += deposit;
                Console.WriteLine($"New Balance: Rs. {balance}");
                break;
            case 3:
                Console.Write("Enter amount to withdraw: Rs. ");
                double withdrawal = Convert.ToDouble(Console.ReadLine());
                if (withdrawal <= balance)
                {
                    balance -= withdrawal;
                    Console.WriteLine($"New Balance: Rs. {balance}");
                }
                else
                {
                    Console.WriteLine("Insufficient funds!");
                }
                break;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
        Console.WriteLine();
    }
    // Question 4: Calculate Average and Grade
    static void Question4()
    {
        Console.WriteLine("Question 4:");
        double[] marks = new double[5];
        double sum = 0;
        for (int i = 0; i < marks.Length; i++)
        {
            Console.Write($"Enter marks for subject {i + 1}: ");
            marks[i] = Convert.ToDouble(Console.ReadLine());
            sum += marks[i];
        }
        double average = sum / marks.Length;
        char grade;
        if (average >= 90) grade = 'A';
        else if (average >= 80) grade = 'B';
        else if (average >= 70) grade = 'C';
        else if (average >= 60) grade = 'D';
        else grade = 'F';
        Console.WriteLine($"Average Marks: {average}");
        Console.WriteLine($"Grade: {grade}\n");
    }
    // Question 5: Password Validation
    static void Question5()
    {
        Console.WriteLine("Question 5:");
        Console.Write("Enter a password: ");
        string password = Console.ReadLine();
        bool hasUpper = false, hasLower = false, hasDigit = false;
        if (password.Length >= 8)
        {
            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpper = true;
                if (char.IsLower(c)) hasLower = true;
                if (char.IsDigit(c)) hasDigit = true;
            }
            if (hasUpper && hasLower && hasDigit)
                Console.WriteLine("Password is valid.");
            else
                Console.WriteLine("Password must contain at least one uppercase letter, one lowercase letter, and one number.");
        }
        else
        {
            Console.WriteLine("Password must be at least 8 characters long.");
        }
        Console.WriteLine();
    }
    // Question 6: Taxi Fare Calculation
    static void Question6()
    {
        Console.WriteLine("Question 6:");
        Console.Write("Enter distance traveled (km): ");
        double distance = Convert.ToDouble(Console.ReadLine());
        double fare = (distance > 2) ? 20 + (distance - 2) * 10 : 20;
        Console.Write("Enter current hour (24-hour format): ");
        int hour = Convert.ToInt32(Console.ReadLine());
        if (hour >= 22)
        {
            fare += 5;
        }
        Console.WriteLine($"Total Fare: Rs. {fare}\n");
    }
    // Question 7: Student Attendance
    static void Question7()
    {
        Console.WriteLine("Question 7:");
        bool[] attendance = new bool[5];
        for (int i = 0; i < attendance.Length; i++)
        {
            Console.Write($"Is student present on day {i + 1}? (yes/no): ");
            attendance[i] = Console.ReadLine().ToLower() == "yes";
        }
        int daysAttended = 0;
        foreach (bool present in attendance)
        {
            if (present) daysAttended++;
        }
        Console.WriteLine($"Total Days Attended: {daysAttended}");
        if (daysAttended == 5)
        {
            Console.WriteLine("Perfect Attendance!");
        }
        Console.WriteLine();
    }
    // Question 8: Monthly Expenses
    static void Question8()
    {
        Console.WriteLine("Question 8:");
        double[] expenses = new double[12];
        double totalExpenses = 0;
        double maxExpense = double.MinValue;
        double minExpense = double.MaxValue;
        int maxMonth = 0;
        int minMonth = 0;
        for (int i = 0; i < expenses.Length; i++)
        {
            Console.Write($"Enter expenses for month {i + 1}: Rs. ");
            expenses[i] = Convert.ToDouble(Console.ReadLine());
            totalExpenses += expenses[i];
            if (expenses[i] > maxExpense)
            {
                maxExpense = expenses[i];
                maxMonth = i;
            }
            if (expenses[i] < minExpense)
            {
                minExpense = expenses[i];
                minMonth = i;
            }
        }
        Console.WriteLine($"Total Expenses for the Year: Rs. {totalExpenses}");
        Console.WriteLine($"Month with Highest Expense: {maxMonth + 1} (Rs. {maxExpense})");
        Console.WriteLine($"Month with Lowest Expense: {minMonth + 1} (Rs. {minExpense})\n");
    }
    // Question 9: Shopping Cart System
    static void Question9()
    {
        Console.WriteLine("Question 9:");
        Dictionary<string, double> cart = new Dictionary<string, double>();
        cart.Add("Item1", 100);
        cart.Add("Item2", 200);
        cart.Add("Item3", 300);
        Console.WriteLine("1. Add Item");
        Console.WriteLine("2. Remove Item");
        Console.WriteLine("3. View Total Price");
        Console.Write("Choose an option (1-3): ");
        int cartOption = Convert.ToInt32(Console.ReadLine());
        switch (cartOption)
        {
            case 1:
                Console.Write("Enter item name: ");
                string addItem = Console.ReadLine();
                Console.Write("Enter item price: Rs. ");
                double addPrice = Convert.ToDouble(Console.ReadLine());
                cart[addItem] = addPrice;
                Console.WriteLine("Item added.");
                break;
            case 2:
                Console.Write("Enter item name to remove: ");
                string removeItem = Console.ReadLine();
                if (cart.ContainsKey(removeItem))
                {
                    cart.Remove(removeItem);
                    Console.WriteLine("Item removed.");
                }
                else
                {
                    Console.WriteLine("Item not found.");
                }
                break;
            case 3:
                double totalCartPrice = 0;
                foreach (var item in cart)
                {
                    totalCartPrice += item.Value;
                }
                Console.WriteLine($"Total Price: Rs. {totalCartPrice}");
                break;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
        Console.WriteLine();
    }
    // Question 10: Monthly Salary Calculation
    static void Question10()
    {
        Console.WriteLine("Question 10:");
        Console.Write("Enter hourly wage (Rs.): ");
        double hourlyWage = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter hours worked per week: ");
        double hoursWorked = Convert.ToDouble(Console.ReadLine());
        double monthlySalary = hourlyWage * hoursWorked * 4;
        Console.WriteLine($"Monthly Salary: Rs. {monthlySalary}");
    }
}