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


            

        }
    }
}
