using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSyntax
{
    class HelloCanada
    {
        static void Main(string[] args)
        {
            // Price Calculator (Subtotal, taxes TPS and TVQ, and Total)
            System.Console.WriteLine("Calculator of Subtotal, taxes TPS and TVQ, and Total");
            System.Console.WriteLine("Data Collection");

            // Declare constants
            const double TPSRATE = 0.05;
            const double TVQRATE = 0.09975;

            // Inputs
            // Declare variables and assign values
            Console.Write("Item Name: ");
            string itemName = Console.ReadLine();
            Console.Write("Item Unit Price: ");
            string unitPrice = Console.ReadLine();
            Console.Write("Item Quantity: ");
            string quantity = Console.ReadLine();

            //Convert input string to double 
            double itemUnitPrice = double.Parse(unitPrice);
            double itemQuantity = Convert.ToDouble(quantity);

            // Calculate
            double subtotal = itemQuantity * itemUnitPrice;
            double tps = subtotal * TPSRATE;
            double tvq = subtotal * TVQRATE;
            double total = subtotal + tps + tvq;

            // Display outputs 
            System.Console.WriteLine("Calculator");
            System.Console.WriteLine("Item Name       : " + itemName);
            System.Console.WriteLine("Item Unit Price : " + itemUnitPrice);
            System.Console.WriteLine("Quantity bought : " + itemQuantity);
            System.Console.WriteLine("Subtotal        : " + subtotal);
            System.Console.WriteLine("TVQ             : " + tvq);
            System.Console.WriteLine("TPS             : " + tps);
            System.Console.WriteLine("Total           : " + total);
        }
    }
}
