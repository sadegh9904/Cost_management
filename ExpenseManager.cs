using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Cost_management
{
    class ExpenseManager
    {
        private readonly List<Expense> _expenses = new List<Expense>();
        public void AddExpense(string productname, decimal amount, string category, string description)
        {
            _expenses.Add(new Expense(productname, amount, category, description));
        }
        public decimal GetTotalAmount() => _expenses.Sum(e => e.Amount);

        public string GetSummary()
        {
            var sb = new StringBuilder();
            foreach (var expense in _expenses)
            {
                sb.AppendLine(expense.ToString());
            }
            sb.AppendLine($"Total Cost : {GetTotalAmount():N0}");
            return sb.ToString();
        }

        public void Clear() => _expenses.Clear();
        public List<Expense> GetExpenses() => _expenses;

        //for saving anythings in the prijects we use newsoft.json
        public void SaveToFile(string path)
        {
            var json = JsonConvert.SerializeObject(_expenses, Formatting.Indented);
            File.WriteAllText(path, json);
        }

        //for loading from database(newsoft.json)
        public void LoadFromFile(string path)
        {
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                var loadedExpenses = JsonConvert.DeserializeObject<List<Expense>>(json);

                _expenses.Clear();
                _expenses.AddRange(loadedExpenses);
            }
        }
    }
}
