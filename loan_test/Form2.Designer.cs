
namespace loan_test
{
    partial class Form2
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
            System.Windows.Forms.Label loan_amount;
            System.Windows.Forms.Label year;
            System.Windows.Forms.Label rate;
            System.Windows.Forms.Label month_pay;
            System.Windows.Forms.Label year_pay;
            this.text_loan = new System.Windows.Forms.TextBox();
            this.text_year = new System.Windows.Forms.TextBox();
            this.text_rate = new System.Windows.Forms.TextBox();
            this.text_mpay = new System.Windows.Forms.TextBox();
            this.text_ypay = new System.Windows.Forms.TextBox();
            loan_amount = new System.Windows.Forms.Label();
            year = new System.Windows.Forms.Label();
            rate = new System.Windows.Forms.Label();
            month_pay = new System.Windows.Forms.Label();
            year_pay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loan_amount
            // 
            loan_amount.AutoSize = true;
            loan_amount.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            loan_amount.Location = new System.Drawing.Point(180, 45);
            loan_amount.Name = "loan_amount";
            loan_amount.Size = new System.Drawing.Size(94, 21);
            loan_amount.TabIndex = 0;
            loan_amount.Text = "貸款金額";
            loan_amount.Click += new System.EventHandler(this.label1_Click);
            // 
            // year
            // 
            year.AutoSize = true;
            year.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            year.Location = new System.Drawing.Point(180, 129);
            year.Name = "year";
            year.Size = new System.Drawing.Size(52, 21);
            year.TabIndex = 0;
            year.Text = "期限";
            year.Click += new System.EventHandler(this.label2_Click);
            // 
            // rate
            // 
            rate.AutoSize = true;
            rate.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            rate.Location = new System.Drawing.Point(180, 210);
            rate.Name = "rate";
            rate.Size = new System.Drawing.Size(52, 21);
            rate.TabIndex = 0;
            rate.Text = "利率";
            rate.Click += new System.EventHandler(this.label3_Click);
            // 
            // month_pay
            // 
            month_pay.AutoSize = true;
            month_pay.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            month_pay.Location = new System.Drawing.Point(180, 281);
            month_pay.Name = "month_pay";
            month_pay.Size = new System.Drawing.Size(73, 21);
            month_pay.TabIndex = 0;
            month_pay.Text = "月付款";
            month_pay.Click += new System.EventHandler(this.label4_Click);
            // 
            // year_pay
            // 
            year_pay.AutoSize = true;
            year_pay.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            year_pay.Location = new System.Drawing.Point(180, 346);
            year_pay.Name = "year_pay";
            year_pay.Size = new System.Drawing.Size(73, 21);
            year_pay.TabIndex = 0;
            year_pay.Text = "年付款";
            year_pay.Click += new System.EventHandler(this.label5_Click);
            // 
            // text_loan
            // 
            this.text_loan.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.text_loan.Location = new System.Drawing.Point(407, 45);
            this.text_loan.Name = "text_loan";
            this.text_loan.Size = new System.Drawing.Size(139, 30);
            this.text_loan.TabIndex = 1;
            // 
            // text_year
            // 
            this.text_year.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.text_year.Location = new System.Drawing.Point(407, 120);
            this.text_year.Name = "text_year";
            this.text_year.Size = new System.Drawing.Size(139, 30);
            this.text_year.TabIndex = 1;
            // 
            // text_rate
            // 
            this.text_rate.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.text_rate.Location = new System.Drawing.Point(407, 201);
            this.text_rate.Name = "text_rate";
            this.text_rate.Size = new System.Drawing.Size(139, 30);
            this.text_rate.TabIndex = 1;
            // 
            // text_mpay
            // 
            this.text_mpay.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.text_mpay.Location = new System.Drawing.Point(407, 280);
            this.text_mpay.Name = "text_mpay";
            this.text_mpay.Size = new System.Drawing.Size(139, 30);
            this.text_mpay.TabIndex = 1;
            // 
            // text_ypay
            // 
            this.text_ypay.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.text_ypay.Location = new System.Drawing.Point(407, 337);
            this.text_ypay.Name = "text_ypay";
            this.text_ypay.Size = new System.Drawing.Size(139, 30);
            this.text_ypay.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text_ypay);
            this.Controls.Add(this.text_mpay);
            this.Controls.Add(this.text_rate);
            this.Controls.Add(this.text_year);
            this.Controls.Add(this.text_loan);
            this.Controls.Add(year_pay);
            this.Controls.Add(month_pay);
            this.Controls.Add(rate);
            this.Controls.Add(year);
            this.Controls.Add(loan_amount);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_loan;
        private System.Windows.Forms.TextBox text_year;
        private System.Windows.Forms.TextBox text_rate;
        private System.Windows.Forms.TextBox text_mpay;
        private System.Windows.Forms.TextBox text_ypay;
    }
}