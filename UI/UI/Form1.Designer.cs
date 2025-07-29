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
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(488, 409);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(300, 29);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calculate Monthly Payment";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(240, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter property's state of residency: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 210);
            label3.Name = "label3";
            label3.Size = new Size(158, 20);
            label3.TabIndex = 3;
            label3.Text = "Enter the interest rate: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 167);
            label4.Name = "label4";
            label4.Size = new Size(172, 20);
            label4.TabIndex = 4;
            label4.Text = "Enter loan term in years: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 123);
            label5.Name = "label5";
            label5.Size = new Size(220, 20);
            label5.TabIndex = 5;
            label5.Text = "Enter a down payment amount: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 80);
            label6.Name = "label6";
            label6.Size = new Size(184, 20);
            label6.TabIndex = 6;
            label6.Text = "Enter the property's value: ";
            // 
            // cmbState
            // 
            cmbState.FormattingEnabled = true;
            cmbState.Location = new Point(310, 34);
            cmbState.Name = "cmbState";
            cmbState.Size = new Size(478, 28);
            cmbState.TabIndex = 7;
            cmbState.Text = "Select a state";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(310, 80);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(475, 27);
            txtPrice.TabIndex = 8;
            // 
            // txtDownPmt
            // 
            txtDownPmt.Location = new Point(310, 123);
            txtDownPmt.Name = "txtDownPmt";
            txtDownPmt.Size = new Size(475, 27);
            txtDownPmt.TabIndex = 9;
            // 
            // txtTerm
            // 
            txtTerm.Location = new Point(310, 167);
            txtTerm.Name = "txtTerm";
            txtTerm.Size = new Size(475, 27);
            txtTerm.TabIndex = 10;
            // 
            // txtInterest
            // 
            txtInterest.Location = new Point(310, 210);
            txtInterest.Name = "txtInterest";
            txtInterest.Size = new Size(475, 27);
            txtInterest.TabIndex = 11;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(236, 338);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(50, 20);
            lblResult.TabIndex = 12;
            lblResult.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
