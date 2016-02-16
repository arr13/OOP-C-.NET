using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            string partDescription = "item";
            string partNumber = "101";
            decimal pricePerItem = 2.5M;
            int quantity = 5;

            Invoice invoice = new Invoice(partDescription, partNumber, pricePerItem, quantity);
            Console.WriteLine(invoice.GetInvoiceAmount());            
        }
    }
}
