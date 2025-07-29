namespace UI
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
            btnCalculate = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmbState = new ComboBox();
            txtPrice = new TextBox();
            txtDownPmt = new TextBox();
            txtTerm = new TextBox();
            txtInterest = new TextBox();
            lblResult = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = SystemColors.GradientActiveCaption;
            btnCalculate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCalculate.ForeColor = SystemColors.HotTrack;
            btnCalculate.Location = new Point(238, 453);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(300, 37);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calculate Monthly Payment";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(15, 93);
            label1.Name = "label1";
            label1.Size = new Size(257, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter property's state of residency: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(15, 266);
            label3.Name = "label3";
            label3.Size = new Size(171, 20);
            label3.TabIndex = 3;
            label3.Text = "Enter the interest rate: ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(15, 223);
            label4.Name = "label4";
            label4.Size = new Size(184, 20);
            label4.TabIndex = 4;
            label4.Text = "Enter loan term in years: ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(15, 179);
            label5.Name = "label5";
            label5.Size = new Size(234, 20);
            label5.TabIndex = 5;
            label5.Text = "Enter a down payment amount: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(15, 136);
            label6.Name = "label6";
            label6.Size = new Size(197, 20);
            label6.TabIndex = 6;
            label6.Text = "Enter the property's value: ";
            // 
            // cmbState
            // 
            cmbState.FormattingEnabled = true;
            cmbState.Location = new Point(313, 90);
            cmbState.Name = "cmbState";
            cmbState.Size = new Size(478, 28);
            cmbState.TabIndex = 7;
            cmbState.Text = "Select a state";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(313, 136);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(475, 27);
            txtPrice.TabIndex = 8;
            // 
            // txtDownPmt
            // 
            txtDownPmt.Location = new Point(313, 179);
            txtDownPmt.Name = "txtDownPmt";
            txtDownPmt.Size = new Size(475, 27);
            txtDownPmt.TabIndex = 9;
            // 
            // txtTerm
            // 
            txtTerm.Location = new Point(313, 223);
            txtTerm.Name = "txtTerm";
            txtTerm.Size = new Size(475, 27);
            txtTerm.TabIndex = 10;
            // 
            // txtInterest
            // 
            txtInterest.Location = new Point(313, 266);
            txtInterest.Name = "txtInterest";
            txtInterest.Size = new Size(475, 27);
            txtInterest.TabIndex = 11;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = SystemColors.ControlDarkDark;
            lblResult.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblResult.Location = new Point(616, 316);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ScrollBar;
            label7.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label7.ForeColor = SystemColors.Desktop;
            label7.Location = new Point(30, 9);
            label7.Name = "label7";
            label7.Size = new Size(727, 50);
            label7.TabIndex = 14;
            label7.Text = "Mortgage - Monthly Payment Calculator";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 502);
            Controls.Add(label7);
            Controls.Add(lblResult);
            Controls.Add(txtInterest);
            Controls.Add(txtTerm);
            Controls.Add(txtDownPmt);
            Controls.Add(txtPrice);
            Controls.Add(cmbState);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnCalculate);
            ForeColor = SystemColors.ButtonFace;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmbState;
        private TextBox txtPrice;
        private TextBox txtDownPmt;
        private TextBox txtTerm;
        private TextBox txtInterest;
        private Label lblResult;
        private Label label7;
    }
}
