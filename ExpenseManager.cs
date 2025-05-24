using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using Cost_management;
using System.Text.Json;

namespace Cost_management
{
    public class ExpenseManager
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
            try
            {
                var json = JsonConvert.SerializeObject(_expenses, Formatting.Indented);
                File.WriteAllText(path, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while saving data:\n{ex.Message}",
                    "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //for loading from database(newsoft.json)
        public void LoadFromFile(string path)
        {
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                var loadedExpenses = JsonConvert.DeserializeObject<List<Expense>>(json);

                _expenses.Clear();
                if (loadedExpenses != null)
                {
                    _expenses.AddRange(loadedExpenses);
                }
            }
        }

        //Lambada Expression
        public Dictionary<int,List<Expense>> GetYearlyReport()
        {
            return _expenses.GroupBy(e => e.Date.Year)
                                    .ToDictionary(g => g.Key, g => g.ToList());
        }

        public Dictionary<int , List<Expense>> GetMonthlyReport(int year)
        {
            return _expenses.Where(e => e.Date.Year == year)
                                    .GroupBy(e => e.Date.Month)
                                    .ToDictionary(g => g.Key, g => g.ToList());
        }

        public List<Expense> GetExpensesByYear(int year)
        {
            return _expenses.Where(e => e.Date.Year == year).ToList();
        }

        public List<Expense> GetExpensesByMonth(int year, int month)
        {
            return _expenses.Where(e => e.Date.Year == year && e.Date.Month == month).ToList();
        }
    }
}