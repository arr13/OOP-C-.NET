using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2Problem3
{
    public class Invoice
    {
        private string partDescription;
        private string partNumber;
        private decimal pricePerItem;
        private int quantity;

        public Invoice()
        {
            throw new System.NotImplementedException();
        }

        public Invoice(string partDescription, string partNumber, decimal pricePerItem, int quantity)
        {
            PartDescription = partDescription;
            PartNumber = partNumber;
            PricePerItem = pricePerItem;
            Quantity = quantity;
        }

        public string PartDescription
        {
            get
            {
                return partDescription;
            }
            set
            {
                if (value != "" && value != " ")
                {
                    partDescription = value;
                }
            }
        }

        public string PartNumber
        {
            get
            {
                return partNumber;
            }
            set
            {
                if (value != "" && value != " ")
                {
                    partNumber = value;
                }
            }
        }

        public decimal PricePerItem
        {
            get
            {
                return pricePerItem;
            }
            set
            {
                if (value > 0)
                {
                    pricePerItem = value;
                }
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value > 0)
                {
                    quantity = value;
                }
            }
        }

        public decimal GetInvoiceAmount()
        {
            return (decimal)Quantity * PricePerItem; 
        }
    }
}
