namespace Cost_management
{
    partial class FormExpenseInput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAmount = new TextBox();
            txtCategory = new TextBox();
            txtDescription = new TextBox();
            btnAdd = new Button();
            dgvExpenses = new DataGridView();
            lblTotal = new Label();
            btnClear = new Button();
            txtProductName = new TextBox();
            lblProductName = new Label();
            lblAmount = new Label();
            lblCategory = new Label();
            lblDescription = new Label();
            btnfinal = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).BeginInit();
            SuspendLayout();
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(128, 70);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(125, 27);
            txtAmount.TabIndex = 0;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(128, 123);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(125, 27);
            txtCategory.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(128, 176);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(211, 105);
            txtDescription.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(128, 315);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add\t";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvExpenses
            // 
            dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpenses.Location = new Point(454, 28);
            dgvExpenses.Name = "dgvExpenses";
            dgvExpenses.RowHeadersWidth = 51;
            dgvExpenses.Size = new Size(300, 188);
            dgvExpenses.TabIndex = 5;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(580, 276);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(82, 20);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Show Total";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(245, 315);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(128, 28);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(125, 27);
            txtProductName.TabIndex = 8;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(12, 28);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(107, 20);
            lblProductName.TabIndex = 9;
            lblProductName.Text = "ProductName :";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(50, 70);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(69, 20);
            lblAmount.TabIndex = 10;
            lblAmount.Text = "Amount :";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(43, 123);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(76, 20);
            lblCategory.TabIndex = 11;
            lblCategory.Text = "Category :";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(27, 221);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(92, 20);
            lblDescription.TabIndex = 12;
            lblDescription.Text = "Description :";
            // 
            // btnfinal
            // 
            btnfinal.Location = new Point(580, 350);
            btnfinal.Name = "btnfinal";
            btnfinal.Size = new Size(94, 29);
            btnfinal.TabIndex = 13;
            btnfinal.Text = "Save";
            btnfinal.UseVisualStyleBackColor = true;
            btnfinal.Click += btnfinal_Click;
            // 
            // FormExpenseInput
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnfinal);
            Controls.Add(lblDescription);
            Controls.Add(lblCategory);
            Controls.Add(lblAmount);
            Controls.Add(lblProductName);
            Controls.Add(txtProductName);
            Controls.Add(btnClear);
            Controls.Add(lblTotal);
            Controls.Add(dgvExpenses);
            Controls.Add(btnAdd);
            Controls.Add(txtDescription);
            Controls.Add(txtCategory);
            Controls.Add(txtAmount);
            Name = "FormExpenseInput";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAmount;
        private TextBox txtCategory;
        private TextBox txtDescription;
        private Button btnAdd;
        private DataGridView dgvExpenses;
        private Label lblTotal;
        private Button btnClear;
        private TextBox txtProductName;
        private Label lblProductName;
        private Label lblAmount;
        private Label lblCategory;
        private Label lblDescription;
        private Button btnfinal;
    }
}