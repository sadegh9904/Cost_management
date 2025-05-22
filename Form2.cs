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
        public FormExpenseInput(int count)
        {
            this.count = count;
            InitializeComponent();
            this.Text = $"Form of {ProductName}";
        }
    }
}
