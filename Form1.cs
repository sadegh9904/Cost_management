namespace Cost_management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            int count = (int)numeticCount.Value;

            if (count <= 0)
            {
                MessageBox.Show("The count must be positive!!!");
                return;
            }

            var inputform = new FormExpenseInput(count);
            inputform.ShowDialog();
        }
    }
}
