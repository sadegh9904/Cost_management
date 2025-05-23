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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "expenses.json");

            if (File.Exists(path) || new FileInfo(path).Length == 0)
            {
                MessageBox.Show("Products not added yet!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormReport formReport = new FormReport();
            formReport.ShowDialog();
        }
    }
}
