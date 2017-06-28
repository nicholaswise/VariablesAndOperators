using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            /* STRINGS
            string firstName = "Mike";
            Console.WriteLine(firstName);

            string birthMonth = "December";
            Console.WriteLine(birthMonth);
            */

            int Age = 65;
            string why = "Because I said so";
            char firstInitial = 'L';


            /*FLOATING POINT TYPES

            float floatNumber = 2.164403304897294849383961032f;
            Console.WriteLine(floatNumber);

            double doubleNumber = 2.164403304897294849383961032d;
            Console.WriteLine(doubleNumber);

            decimal decimalNumber = 2.164403304897294849383961032m;
            Console.WriteLine(decimalNumber);
            */

            /*
            Console.WriteLine("What is the name on the reservation?");
            string reserveName = Console.ReadLine();


            Console.WriteLine("How many people are in your party?");


            int numberOfPeople = int.Parse(Console.ReadLine());

            
            double amountEach = 13.53d;
            double totalBill = numberOfPeople * amountEach;
            Console.WriteLine(totalBill);

            Console.WriteLine("Reservation: " + reserveName);
            Console.WriteLine("Total Due: $" + totalBill);
            */
            /*Word problems
            int cupsOfSugar;
            Console.WriteLine("How many cups needed?");
            int cupsAdded = int.Parse(Console.ReadLine());
            
            Console.WriteLine("How many cups have you added?");
            int cupsUsed = int.Parse(Console.ReadLine());
            Console.WriteLine("Remaining cups required: " + (cupsAdded - cupsUsed));
            

            int diapersNeeded;
            Console.WriteLine("How much money do you have?");
            int dollarsHad = int.Parse(Console.ReadLine());

            Console.WriteLine("How much do the diapers cost?");
            int diaperCost = int.Parse(Console.ReadLine());
            Console.WriteLine("Diapers you can afford: " + (dollarsHad / diaperCost));

            int currentMoney = 29;
            int newMoney = 41;
            Console.WriteLine(newMoney - currentMoney);
            */
            /*
            //Create a receipt (on console)
            //Ask how many donations
            //Get details of the money donated
            Console.WriteLine("Welcome to your donation tracker!");
            Console.WriteLine("Please enter the information below as prompted.");
            //How many ones, fives, tens, twenties, fifties, hundreds, quarters
            Console.WriteLine("How many $1 bills?");
            int ones = int.Parse(Console.ReadLine());
            int onesInDollars = ones * 1;
            Console.WriteLine("How many $5 bills?");
            int fives = int.Parse(Console.ReadLine());
            int fivesInDollars = fives * 5;
            Console.WriteLine("How many $10 bills?");
            int tens = int.Parse(Console.ReadLine());
            int tensInDollars = tens * 10;
            Console.WriteLine("How many $20 bills?");
            int twenties = int.Parse(Console.ReadLine());
            int twentiesInDollars = twenties * 20;
            Console.WriteLine("How many $50 bills?");
            int fifties = int.Parse(Console.ReadLine());
            int fiftiesInDollars = fifties * 50;
            Console.WriteLine("How many $100 bills?");
            int hundreds = int.Parse(Console.ReadLine());
            int hundredsInDollars = hundreds * 100;
            Console.WriteLine("How many quarters?");
            int quarters = int.Parse(Console.ReadLine());
            double quartersInDollars = quarters * .25d;

            //Ask for personal information: name, address, email address
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            Console.WriteLine("What is your address?");
            string yourAddress = Console.ReadLine();

            Console.WriteLine("What is your e-mail address?");
            string yourEmail = Console.ReadLine();

            Console.WriteLine("What is the current fiscal year? Don't know? Look it up!");
            string fiscalYear = Console.ReadLine();

            //Print personal info and donation amount
            Console.WriteLine("Your name is " + yourName);
            Console.WriteLine("Your address is " + yourAddress);
            Console.WriteLine("Your e-mail address is " + yourEmail);
            Console.WriteLine("The fiscal year is " + fiscalYear);

            double donationAmount = (onesInDollars + fivesInDollars + tensInDollars + twentiesInDollars + fiftiesInDollars + hundredsInDollars + quartersInDollars);
            Console.WriteLine("Your donation total is $ " + donationAmount);

            Console.WriteLine("Thank you for your donation!");
            */

            /*Assignment: 
             * local high school swim team, tshirt fundraiser. 
             * 3 different graphics. 
             * 1st one, super swim. super swim $15
             * 2nd graphic, be the shark. $17.50.
             * 3rd graphic. baby bubbles. $4.75.
             * swim team needs application to automatically calculate total.
             * For each transaction, the following receipt:
             * total number of shirts purchased, subtotal, grand total = 8% tax added.
             * */
            Console.WriteLine("Greetings! Welcome to the swim team merchandise calculator! ");
            
            Console.WriteLine("How many Super Swim shirts were purchased?");
            int superSwim = int.Parse(Console.ReadLine());

            Console.WriteLine("How many Be The Shark shirts were purchased?");
            int beShark = int.Parse(Console.ReadLine());

            Console.WriteLine("How many Baby Bubbles shirts were purchased?");
            int babyBubbles = int.Parse(Console.ReadLine());

            Console.WriteLine("Thank you! Here is your receipt: ");

            Console.WriteLine("Total shirts purchased: " + (superSwim + beShark + babyBubbles));

            int superSwimTotals = superSwim * 15;
            float beSharkTotals = beShark * 17.50f;
            float babyBubblesTotals = babyBubbles * 4.75f;
            double taxRate = .08d;
            double subTotal = (superSwimTotals + beSharkTotals + babyBubblesTotals);
            double grandTotal = ((subTotal * taxRate) + subTotal);

            Console.WriteLine("Subtotal: " + subTotal);

            Console.WriteLine("Your grand total is: " + grandTotal);




            
            




        }
    }
}
