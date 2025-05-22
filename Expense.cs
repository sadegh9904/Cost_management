using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cost_management
{
    class Expense
    {
        public string ProductName { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        //public DateTime Date { get; set; }


        public Expense(string productname, decimal amount, string description, DateTime date)
        {
            ProductName = productname;
            Amount = amount;
            Description = description;
            //Date = date;
        }


        public override string ToString()
        {
            return $"Product name :{ProductName}| Cost : {Amount}| Description : {Description}";
        }
    }
}
