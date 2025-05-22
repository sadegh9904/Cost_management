namespace Cost_management
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblcount = new Label();
            btnnext = new Button();
            numeticCount = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numeticCount).BeginInit();
            SuspendLayout();
            // 
            // lblcount
            // 
            lblcount.AutoSize = true;
            lblcount.Location = new Point(367, 89);
            lblcount.Name = "lblcount";
            lblcount.Size = new Size(194, 20);
            lblcount.TabIndex = 0;
            lblcount.Text = "Please choose  your amount";
            // 
            // btnnext
            // 
            btnnext.Location = new Point(612, 143);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(94, 29);
            btnnext.TabIndex = 1;
            btnnext.Text = "Next";
            btnnext.UseVisualStyleBackColor = true;
            btnnext.Click += btnnext_Click;
            // 
            // numeticCount
            // 
            numeticCount.Location = new Point(583, 87);
            numeticCount.Name = "numeticCount";
            numeticCount.Size = new Size(150, 27);
            numeticCount.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numeticCount);
            Controls.Add(btnnext);
            Controls.Add(lblcount);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numeticCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblcount;
        private Button btnnext;
        private NumericUpDown numeticCount;
    }
}
