using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cost_management
{
    public partial class FormReport : Form
    {
        private readonly ExpenseManager _manager;
        public FormReport(ExpenseManager manager)
        {
            InitializeComponent();
            _manager = manager;
            PopulateYearComboBox();
            PopulateTreeView();
        }

        private void PopulateYearComboBox()
        {
            comboBoxYears.Items.Clear();
            var years = _manager.GetYearlyReport().Keys.OrderBy(y => y).ToList();

            foreach (var year in years)
            {
                comboBoxYears.Items.Add(year);
            }
            if (years.Any())
            {
                comboBoxYears.SelectedIndex = 0;
            }
            else
            {
                comboBoxYears.Items.Add("No years available");
            }
        }

        private void PopulateTreeView(int? selectedyear = null)
        {
            treeViewReports.Nodes.Clear();
            var yearlyReport = _manager.GetYearlyReport();

            if (!yearlyReport.Any())
            {
                treeViewReports.Nodes.Add("No epense available");
                return;
            }
            foreach (var yeargroup in yearlyReport.OrderBy(y => y.Key))
            {
                if (selectedyear.HasValue && yeargroup.Key != selectedyear.Value)
                {
                    continue;
                }
                var yearNode = treeViewReports.Nodes.Add($"Year {yeargroup.Key}");
                decimal yearTotal = yeargroup.Value.Sum(e => e.Amount);
                yearNode.Nodes.Add($"Total :{yearTotal:N0}");


                var monthlyReport = _manager.GetMonthlyReport(yeargroup.Key);

                foreach (var monthGroup in monthlyReport.OrderBy(m => m.Key))
                {
                    string monthName = System.Globalization.CultureInfo.CurrentCulture
                        .DateTimeFormat.GetMonthName(monthGroup.Key);
                    var monthNode = yearNode.Nodes.Add($"{monthName}");
                    decimal monthTotal = monthGroup.Value.Sum(e => e.Amount);
                    monthNode.Nodes.Add($"Tatal :{monthTotal:N0}");

                    foreach (var expence in monthGroup.Value)
                    {
                        monthNode.Nodes.Add($"{expence.ProductName} : {expence.Amount:N0}|{expence.Category}");
                    }
                }
            }
            treeViewReports.ExpandAll();
        }

        private void comboBoxYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxYears.SelectedItem != null && comboBoxYears.SelectedItem.ToString() != "No years available")
            {
                int selectedYear = (int)comboBoxYears.SelectedItem;
                PopulateTreeView(selectedYear);
            }
            else
            {
                PopulateTreeView();
            }
        }
    }
}
