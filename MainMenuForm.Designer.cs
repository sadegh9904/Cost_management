namespace Cost_management
{
    partial class MainMenuForm
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
            lblwelcome = new Label();
            btnAddExpense = new Button();
            btnExit = new Button();
            btnReport = new Button();
            SuspendLayout();
            // 
            // lblwelcome
            // 
            lblwelcome.AutoSize = true;
            lblwelcome.Location = new Point(280, 44);
            lblwelcome.Name = "lblwelcome";
            lblwelcome.Size = new Size(215, 20);
            lblwelcome.TabIndex = 0;
            lblwelcome.Text = "Welcome to The Cost_manager";
            // 
            // btnAddExpense
            // 
            btnAddExpense.AutoSize = true;
            btnAddExpense.Location = new Point(50, 129);
            btnAddExpense.Name = "btnAddExpense";
            btnAddExpense.Size = new Size(330, 80);
            btnAddExpense.TabIndex = 1;
            btnAddExpense.Text = "New Product";
            btnAddExpense.UseVisualStyleBackColor = true;
            btnAddExpense.Click += btnAddExpense_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(658, 365);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(50, 231);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(330, 77);
            btnReport.TabIndex = 3;
            btnReport.Text = "Reports";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReport);
            Controls.Add(btnExit);
            Controls.Add(btnAddExpense);
            Controls.Add(lblwelcome);
            Name = "MainMenuForm";
            Text = "MainMenuForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblwelcome;
        private Button btnAddExpense;
        private Button btnExit;
        private Button btnReport;
    }
}