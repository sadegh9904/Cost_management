namespace Cost_management
{
    partial class FormReport
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
            comboBoxYears = new ComboBox();
            treeViewReports = new TreeView();
            SuspendLayout();
            // 
            // comboBoxYears
            // 
            comboBoxYears.FormattingEnabled = true;
            comboBoxYears.Location = new Point(28, 12);
            comboBoxYears.Name = "comboBoxYears";
            comboBoxYears.Size = new Size(151, 28);
            comboBoxYears.TabIndex = 0;
            comboBoxYears.SelectedIndexChanged += comboBoxYears_SelectedIndexChanged;
            // 
            // treeViewReports
            // 
            treeViewReports.Location = new Point(28, 69);
            treeViewReports.Name = "treeViewReports";
            treeViewReports.Size = new Size(151, 121);
            treeViewReports.TabIndex = 1;
            // 
            // FormReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(treeViewReports);
            Controls.Add(comboBoxYears);
            Name = "FormReport";
            Text = "FormReport";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxYears;
        private TreeView treeViewReports;
    }
}