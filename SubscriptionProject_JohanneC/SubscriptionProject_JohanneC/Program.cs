//---------------------------------------------//
// Program: Subscription Admin Portal
// By: Johanne Christiana
//---------------------------------------------//

using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;

namespace myClient
{
    public class Client
    {
        public string Name;
        public int User;
        public string Offer;
        public string Subscription;
        public double Price;
        public double Total;
        public double Discount;
        public DateTime DateTime;

        public Client(string name, int user, string offer, string subscription, double price, double total, double discount, DateTime datetime)
        {
            Name = name;
            User = user;
            Offer = offer;
            Subscription = subscription;
            Price = price;
            Total = total;
            Discount = discount;
            DateTime = datetime;
        }
    }

    public class ClientExecution
    {
        static void Main(string[] args)
        {
            string name_input;
            int user_input;
            string offer_input;
            string subscription;
            double price;
            double total;
            double discount = 0.15; // 15% discount apply
            DateTime date = DateTime.Now;

            List<Client> Clients = new List<Client>();

            //------------------Welcome Message------------------//
            Console.WriteLine("***************Welcome to InnovationYoyo Admin Portal***************");
            Console.WriteLine("***************Logged in as Johanne Christiana***************\n");

            string option;
            //--------------------Show Menu--------------------//
            do
            {
                Console.WriteLine("Enter an option to create or view client subscription:");
                Console.WriteLine("0 - Free Trial (7 days free trial)\n" +
                    "1 - Standard Plan (15.00 AUD per user)\n" +
                    "2 - Premium Plan (25.50 AUD per user)\n" +
                    "3 - Enterprise Plan (35.00 AUD per user)\n" + "\n" +
                    "4 - View all entries\n" +
                    "5 - Exit\n");

                Console.Write("Choose an option: ");
                option = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(option))
                {
                    Console.WriteLine("Please enter an option.\n");
                    continue; // Restart the loop
                }

                switch (option)
                {
                    case "0": //---------------------------------- Free Trial ----------------------------------//
                        subscription = "FreeTrial";
                        offer_input = "N";
                        price = 0;
                        user_input = 1;
                        total = 0.0;

                        while (true)
                        {
                            Console.Write("Enter your organisation name: ");
                            name_input = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(name_input))
                            {
                                Console.WriteLine("Please enter your organisation name.\n");
                                continue;
                            }

                            Clients.Add(new Client(name_input, user_input, offer_input, subscription, price, total, discount, date));
                            Console.WriteLine("\n" + "*********************************************************************************************\n" +
                                $"The {subscription} subscription is created for {name_input}. The trial ends on {date.ToString()}\n" +
                                "*********************************************************************************************\n");
                            break;
                        }
                        break;

                    case "1": //---------------------------------- Standard ----------------------------------//
                    case "2": //---------------------------------- Premium -----------------------------------//
                    case "3": //--------------------------------- Enterprise ---------------------------------//
                        subscription = option == "1" ? "Standard" :
                            option == "2" ? "Premium" : "Enterprise";
                        price = option == "1" ? 15.0 : option == "2" ? 25.5 : 35.0;

                        // Show menu
                        DisplayChosenOption(Clients, out name_input, out user_input, out offer_input, subscription, price, out total, discount);
                        break;

                    case "4":
                        Console.WriteLine("\n" + "**************************** Subscription Summary Table ****************************\n");
                        Console.WriteLine("{0,-18} {1,-17} {2,-17} {3,-18} {4,-15}", "Client Name", "Subscription", "User Count", "Special Offer", "Price");

                        foreach (Client client in Clients)
                        {
                            Console.WriteLine("{0,-18} {1,-17} {2,-17} {3,-18} {4:F4}", client.Name, client.Subscription, client.User, client.Offer, client.Total);
                        }

                        Console.WriteLine("\n" + "************************************************************************************\n");
                        break;

                    // Repeats the menu if an option other than 0,1,2,3,4, or 5 is pressed.
                    default:
                        if (option != "5")
                        {
                            Console.WriteLine("Please try again, choose from options.\n");
                        }
                        break;
                }
            } while (option != "5"); // Exits the program when the user chooses option 5
            Console.WriteLine("Closing program...");
        }


        //-------------------------- Method for applying discount --------------------------//
        static double ApplyDiscount(double total, double discount)
        {
            double overall_cost = total * discount; // Discount applied 
            return total -= overall_cost; // Subtract discount from total price to get overall cost
        }

        //---- Method for printing Standard, Premium, and Enterprise subscription details ----//
        static void DisplayOffer(string subscription, string name_input, double total)
        {
            Console.WriteLine("\n" + "*********************************************************************************************\n" +
            "The {0} subscription is created for {1} and the price is {2:F4}\n" +
            "*********************************************************************************************\n", subscription, name_input, total);
        }

        //------------------ Method for Displaying the options: 1, 2, or 3 ------------------//
        static void DisplayChosenOption(List<Client> Clients, out string name_input, out int user_input, out string offer_input, string subscription, double price, out double total, double discount)
        {
            name_input = "";
            user_input = 0;
            offer_input = "";
            total = 0; // Initialize total


            // Loop until valid user_input is received
            while (true)
            {

                Console.Write("Enter your organisation name: ");
                name_input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name_input))
                {
                    Console.WriteLine("Please enter your organisation name.\n");
                    continue;
                }

                Console.Write("Enter a number of users (1 - 100): ");
                string userInputString = Console.ReadLine();
                if (!int.TryParse(userInputString, out user_input))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.\n");
                    continue; // Restart the loop
                }
                else if (user_input < 1 || user_input > 100)
                {
                    Console.WriteLine("Please try again with correct input (Users should range from 1 - 100).\n");
                    continue; // Restart the loop
                }

                if (user_input >= 1 && user_input <= 100)
                {
                    // Loop until valid offer_input is received
                    while (true)
                    {
                        Console.Write("Special Offer (Y/N): ");
                        offer_input = Console.ReadLine();
                        total = user_input * price;
                        if (offer_input.ToUpper() == "Y")
                        {
                            total = ApplyDiscount(total, discount); // apply discount
                            Clients.Add(new Client(name_input, user_input, offer_input, subscription, price, total, discount, DateTime.Now));
                            DisplayOffer(subscription, name_input, total);
                            break;
                        }
                        else if (offer_input.ToUpper() == "N")
                        {
                            Clients.Add(new Client(name_input, user_input, offer_input, subscription, price, total, discount, DateTime.Now));
                            DisplayOffer(subscription, name_input, total);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please try again with correct input (Y or N).\n");
                        }
                    }
                }

                break;
            }
        }
    }
}

