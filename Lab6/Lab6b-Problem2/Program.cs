using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6b_Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare and initialize cutomers variable
            var customers = new[] { 
                   new { ID = 1, FirstName = "Sandeep" , LastName = "Ramani" }, 
                   new { ID = 2, FirstName = "Dharmik" , LastName = "Chotaliya" }, 
                   new { ID = 3, FirstName = "Nisar" , LastName = "Kalia" } , 
                   new { ID = 4, FirstName = "Ravi" , LastName = "Mapara" } , 
                   new { ID = 5, FirstName = "Hardik" , LastName = "Mistry" },
                   new { ID = 6, FirstName = "Sandy" , LastName = "Ramani" }, 
                   new { ID = 7, FirstName = "Jigar" , LastName = "Shah" }, 
                   new { ID = 8, FirstName = "Kaushal" , LastName = "Parik" } , 
                   new { ID = 9, FirstName = "Abhishek" , LastName = "Swarnker" } ,
                   new { ID = 10, FirstName = "Sanket" , LastName = "Patel" },
                   new { ID = 11, FirstName = "Dinesh" , LastName = "Prajapati" }, 
                   new { ID = 12, FirstName = "Jayesh" , LastName = "Patel" }, 
                   new { ID = 13, FirstName = "Nimesh" , LastName = "Mishra" } , 
                   new { ID = 14, FirstName = "Shiva" , LastName = "Reddy" } , 
                   new { ID = 15, FirstName = "Jasmin" , LastName = "Malviya" },
                   new { ID = 16, FirstName = "Haresh" , LastName = "Bhanderi" }, 
                   new { ID = 17, FirstName = "Ankit" , LastName = "Ramani" }, 
                   new { ID = 18, FirstName = "Sanket" , LastName = "Shah" } , 
                   new { ID = 19, FirstName = "Amit" , LastName = "Shah" } , 
                   new { ID = 20, FirstName = "Nilesh" , LastName = "Soni" } };

            // select customers with ID between 5 and 15
            var selectCustomersBetween5And15 = customers.AsParallel().Where(ID => ID.ID >= 5 && ID.ID <= 15).
                                                Select(customer => new { customer.ID, 
                                                        customer.FirstName, customer.LastName});

            // in parallel show customers with ID betwen 5 and 15
            Parallel.ForEach (selectCustomersBetween5And15, item => Console.WriteLine(item));

            Console.WriteLine();

            // in parallel select customres with distinct last name
            var selectCustomersWithDistinctLastName = customers.AsParallel().
                                                        Select(customer => customer.LastName).
                                                         Distinct();

            // in parallel show customers with distinct last name
            Parallel.ForEach(selectCustomersWithDistinctLastName, item => Console.WriteLine(item));

            Console.WriteLine();

            // in parallel select customers` information in string
            var selectInString = customers.AsParallel().Select(customer => customer.ID + ", " +
                                                                           customer.FirstName + ", " +
                                                                           customer.LastName);

            // in parallel show customers` information in string
            Parallel.ForEach(selectInString, item => Console.WriteLine(item));
        }
    }
}
