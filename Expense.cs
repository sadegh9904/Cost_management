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
        public string Category { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; private set; } = DateTime.Now;


        public Expense(string productname, decimal amount, string category,string description)
        {
            ProductName = productname;
            Amount = amount;
            Category = category;
            Description = description;
        }


        public override string ToString()
        {
            return $"Product name :{ProductName}| Cost : {Amount}| Description : {Description} | Time : {Date.ToString("yyyy-MM-dd")}";
        }
    }
}
