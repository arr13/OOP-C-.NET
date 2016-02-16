using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5___Problem1
{
    class Problem1
    {
        static void Main(string[] args)
        {
            // declare and initialize an array of invoices
            Invoice[] invoices = {  new Invoice(83, "Electric sander", 7, 57.98M),
                                    new Invoice(24, "Power saw", 18, 99.99M),
                                    new Invoice(7, "Sledge hammer", 11, 21.50M),
                                    new Invoice(77, "Hammer", 76, 11.99M),
                                    new Invoice(39, "Lawn mower", 3, 79.5M),
                                    new Invoice(68, "Screwdriver", 106, 6.99M),
                                    new Invoice(56, "Jig saw", 21, 11M),
                                    new Invoice(3, "Wrench", 34, 7.5M)
                                 }; 
            // shows ivoices sorted by part description
            Display(SortByPartDescription(invoices), "Sorted by part description");
            Console.WriteLine();

            // shows invoices sorted by prace
            Display(SortByPrice(invoices), "Sorted by price");
            Console.WriteLine();

            // shows invoices selected by part description and quantity
            // and ordered by quantity
            DisplaySrting(SelectFromPartDescrQunatitySortByQuantity(invoices), "Selected from part description and quantity and ordered by quantity");
            Console.WriteLine();

            // shows invoices sorted bt value of invoice
            DisplaySrting(SortByValueOfInvoice(invoices), "Sorted by part value");
            Console.WriteLine();

            // shows invoices with value between 200 and 500
            DisplaySrting(SortByValueBetween200And500(invoices), "Sorted by value between 200 and 500");
            Console.WriteLine();

            // shows invoices below and above 12$
            DisplayGroup(TwoGroupsByPrice(invoices));
            Console.WriteLine();
            DisplayGroup(ThreeGroupsByPrice(invoices));
        }

        // show result of a request
        static void Display(IEnumerable<Invoice> results, string header)
        {
            Console.WriteLine("{0} :", header);

            foreach (var result in results)
            {
                Console.WriteLine(" {0}", result);
            }
        }

        // shows results of a request with return type string
        static void DisplaySrting(IEnumerable<string> results, string header)
        {
            Console.WriteLine("{0} :", header);

            foreach (var result in results)
            {
                Console.WriteLine(" {0}", result);
            }
        }

        // shows results of a request that groups data
        static void DisplayGroup(IEnumerable<IGrouping<string, Invoice>> Group)
        {
            foreach (var item in Group)
            {
                Console.WriteLine(item.Key + ":");
                foreach (var w in item)
                {
                    Console.WriteLine(w);
                }
            }
        }

        // sort by part description
        static IEnumerable<Invoice> SortByPartDescription(Invoice[] invoices)
        {
            var sortByPartDescription =
                from invoice in invoices
                orderby invoice.PartDescription
                select invoice;

            return sortByPartDescription;
        }

        // sort by price
        static IEnumerable<Invoice> SortByPrice(Invoice[] invoices)
        {
            var sortByPartDescription =
                from invoice in invoices
                orderby invoice.PartDescription
                select invoice;

            return sortByPartDescription;
        }

        // selectt from part description and quantity and sort by quantity
        static IEnumerable<string> SelectFromPartDescrQunatitySortByQuantity(Invoice[] invoices)
        {
            var sortByQuantity =
                from invoice in invoices
                orderby invoice.Quantity
                select new { Desc = invoice.PartDescription, Quan = invoice.Quantity };

            foreach (var item in sortByQuantity)
            {
                yield return string.Format("{0, -20} {1, 5}", item.Desc, item.Quan);
            }
        }

        // sort by value of invoice
        static IEnumerable<string> SortByValueOfInvoice(Invoice[] invoices)
        {
            var sortByValueOfInvoice =
                from invoice in invoices
                let value = invoice.Price * invoice.Quantity
                orderby value
                select new{ Desc = invoice.PartDescription, Value = value };

            foreach (var result in sortByValueOfInvoice)
            {
                yield return string.Format("{0, -23} {1, -5}", result.Desc, result.Value);
            }
        }

        // sort by value between 200 and 500
        static IEnumerable<string> SortByValueBetween200And500(Invoice[] invoices)
        {
            var sortByValue =
                from invoice in invoices
                let value = invoice.Price * invoice.Quantity
                where value >= 200 && value <= 500
                orderby value
                select new { Desc = invoice.PartDescription, Value = value };

            foreach (var result in sortByValue)
            {
                yield return string.Format("{0, -23} {1, -5}", result.Desc, result.Value);
            }
        }

        // sort in two groups
        static IEnumerable<IGrouping<string, Invoice>> TwoGroupsByPrice(Invoice[] invoices)
        {
            var sortByPrice =
                from invoice in invoices
                orderby invoice.Price
                group invoice by TwoGroupsByPrice(invoice.Price) into g
                select g;
            return sortByPrice;
        }

        // check if price is above or below $12
        static string TwoGroupsByPrice(decimal price)
        {
            if (price <= 12)
            {
                return "Invoice below $12";
            }
            return "Invoice above $12";
        }

        // sort in 3 groups
        static IEnumerable<IGrouping<string, Invoice>> ThreeGroupsByPrice(Invoice[] invoices)
        {
            var sortByPrice =
                from invoice in invoices
                orderby invoice.Price
                group invoice by ThreeGroupsByPrice(invoice.Price) into g
                select g;
            return sortByPrice;
        }

        // check if price isbelow $10, between $10 and $20 or above $20
        static string ThreeGroupsByPrice(decimal price)
        {
            if (price < 10)
            {
                return "Invoices with prices below $10";
            }
            if (price >= 10 && price <= 20)
            {
                return "Invoices with prices between $10 and $20";
            }
            return "Invoices with prices above $20";
        }
    }
}
