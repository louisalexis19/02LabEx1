using System;

class Program
{
    static void Main()
    {
        //the application name
        const string appName = "Fruits Price Calculator";

        // Print a welcome message to the console
        Console.WriteLine($"Welcome to {appName}!");
        Console.WriteLine("We sell a variety of fruits.");
        Console.WriteLine("");

        //prices for each fruit 
        double applePrice = 0.50; 
        double bananaPrice = 0.25; 
        double orangePrice = 0.75; 
        double grapePrice = 1.00; 
        double watermelonPrice = 2.50; 

        //print the prices of each fruit to the console
        // f2 format specifier for 2 decimal places
        Console.WriteLine("Our fruits and prices are:");
        Console.WriteLine($"Apple: ${applePrice:F2}"); 
        Console.WriteLine($"Banana: ${bananaPrice:F2}");
        Console.WriteLine($"Orange: ${orangePrice:F2}");
        Console.WriteLine($"Grape: ${grapePrice:F2}");
        Console.WriteLine($"Watermelon: ${watermelonPrice:F2}");
        Console.WriteLine("");
        //ask the user the quantity converted to int
        Console.Write("Enter the number of apples you want to buy: ");
        int appleQuantity = Convert.ToInt32(Console.ReadLine()); 

        Console.Write("Enter the number of bananas you want to buy: ");
        int bananaQuantity = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of oranges you want to buy: ");
        int orangeQuantity = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of grapes you want to buy: ");
        int grapeQuantity = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of watermelons you want to buy: ");
        int watermelonQuantity = Convert.ToInt32(Console.ReadLine());

        //calculate the total price by quantity of fruit
        double totalPrice = (appleQuantity * applePrice) + (bananaQuantity * bananaPrice) + (orangeQuantity * orangePrice) + (grapeQuantity * grapePrice) + (watermelonQuantity * watermelonPrice);

       
        Console.WriteLine("");
         //the receipt
        Console.WriteLine("Your receipt:");
        Console.WriteLine($"Apple x {appleQuantity}: ${appleQuantity * applePrice:F2}");
        Console.WriteLine($"Banana x {bananaQuantity}: ${bananaQuantity * bananaPrice:F2}");
        Console.WriteLine($"Orange x {orangeQuantity}: ${orangeQuantity * orangePrice:F2}");
        Console.WriteLine($"Grape x {grapeQuantity}: ${grapeQuantity * grapePrice:F2}");
        Console.WriteLine($"Watermelon x {watermelonQuantity}: ${watermelonQuantity * watermelonPrice:F2}");
         Console.WriteLine("");


        Console.WriteLine($"Total price: ${totalPrice:F2}");

        //conveting the total price to a whole number
        int wholeNumberPrice = (int)totalPrice;
        Console.WriteLine($"Converted price (whole number): ${wholeNumberPrice}");
    }
}