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
    public partial class FormExpenseInput : Form
    {
        private int count;
        private int added_counter = 0;
        private ExpenseManager manager = new ExpenseManager();
        private BindingList<Expense> expenseBindingList = new BindingList<Expense>();
        public FormExpenseInput(int count)
        {
            this.count = count;
            InitializeComponent();
            btnfinal.Enabled = false;
        }

        private void FormExpenseInput_Load(object sender, EventArgs e)
        {
            expenseBindingList = new BindingList<Expense>(manager.GetExpenses());
            dgvExpenses.AutoGenerateColumns = false;
            dgvExpenses.DataSource = expenseBindingList;

            dgvExpenses.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ProductName",
                DataPropertyName = "ProductName",
                Width = 150
            });
            dgvExpenses.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Price",
                DataPropertyName = "Amount",
                Width = 100
            });
            dgvExpenses.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Category",
                DataPropertyName = "Category",
                Width = 100
            });
            dgvExpenses.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Explanation",
                DataPropertyName = "Description",
                Width = 200
            });
            dgvExpenses.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Time",
                DataPropertyName = "Date",
                Width = 100
            });

            UpdateTotal();
        }

        private void UpdateTotal()
        {
            decimal total = manager.GetTotalAmount();
            lblTotal.Text = $"Total price is :{total:N0}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtProductName.Text.Trim();
            string amnt = txtAmount.Text.Trim();
            string cat = txtCategory.Text.Trim();
            string desc = txtDescription.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter Productname!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductName.Focus();
                return;
            }

            if (!decimal.TryParse(amnt, out decimal amount))
            {
                MessageBox.Show("Please enter valid amount !", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmount.Focus();
                return;
            }

            if (string.IsNullOrEmpty(cat))
            {
                MessageBox.Show("Please enter Category", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategory.Focus();
                return;
            }

            //if (string.IsNullOrEmpty(desc))
            //{
            //    MessageBox.Show("Please enter Description", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtDescription.Focus();
            //    return;
            //}

            manager.AddExpense(name, amount, cat, desc);
            expenseBindingList.ResetBindings();
            UpdateTotal();

            added_counter++;

            //this is for showing the buuten for save 
            if (added_counter >= count)
            {
                btnfinal.Enabled = true;
                MessageBox.Show("All the Products are entered, now you can click on save","WellDone!",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
            }


            txtProductName.Clear();
            txtAmount.Clear();
            txtCategory.Clear();
            txtDescription.Clear();
            txtProductName.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            manager.Clear();
            expenseBindingList.Clear();
            UpdateTotal();
        }

        private void btnfinal_Click(object sender, EventArgs e)
        {
            if (added_counter < count)
            {
                MessageBox.Show($"Please enter all {count} products before saving!",
                    "Incomplete Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string path = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "expenses.json");

            manager.SaveToFile(path);

            MessageBox.Show("All the informations saved now!",
                "Information saved",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }
    }
}
