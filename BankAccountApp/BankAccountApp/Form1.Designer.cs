namespace BankAccountApp
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
            label1 = new Label();
            label2 = new Label();
            OwnerTxt = new TextBox();
            AmountNum = new NumericUpDown();
            DataGrid = new DataGridView();
            DepositBtn = new Button();
            WithdrawBtn = new Button();
            CreateAccountBtn = new Button();
            InterestRate = new Label();
            InterestRateTxt = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            IdTxt = new TextBox();
            PhoneTxt = new TextBox();
            AddressTxt = new TextBox();
            BalanceNum = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            OverdraftNum = new NumericUpDown();
            ApplyInterestBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InterestRateTxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BalanceNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OverdraftNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Simplified Arabic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 56);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 39);
            label1.TabIndex = 0;
            label1.Text = "Name : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Simplified Arabic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(412, 560);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 39);
            label2.TabIndex = 1;
            label2.Text = "Amount : ";
            label2.Click += label2_Click;
            // 
            // OwnerTxt
            // 
            OwnerTxt.Location = new Point(163, 59);
            OwnerTxt.Name = "OwnerTxt";
            OwnerTxt.Size = new Size(202, 37);
            OwnerTxt.TabIndex = 3;
            // 
            // AmountNum
            // 
            AmountNum.Location = new Point(530, 560);
            AmountNum.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(331, 37);
            AmountNum.TabIndex = 4;
            AmountNum.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // DataGrid
            // 
            DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.Location = new Point(412, 45);
            DataGrid.Name = "DataGrid";
            DataGrid.RowHeadersWidth = 51;
            DataGrid.Size = new Size(898, 412);
            DataGrid.TabIndex = 5;
            DataGrid.CellContentClick += DataGrid_CellContentClick;
            // 
            // DepositBtn
            // 
            DepositBtn.BackColor = Color.Plum;
            DepositBtn.Location = new Point(412, 491);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(449, 46);
            DepositBtn.TabIndex = 6;
            DepositBtn.Text = "Deposit";
            DepositBtn.UseVisualStyleBackColor = false;
            DepositBtn.Click += DepositBtn_Click;
            // 
            // WithdrawBtn
            // 
            WithdrawBtn.BackColor = Color.Plum;
            WithdrawBtn.Location = new Point(877, 491);
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.Size = new Size(433, 46);
            WithdrawBtn.TabIndex = 7;
            WithdrawBtn.Text = "Withdraw";
            WithdrawBtn.UseVisualStyleBackColor = false;
            WithdrawBtn.Click += WithdrawBtn_Click;
            // 
            // CreateAccountBtn
            // 
            CreateAccountBtn.Location = new Point(46, 600);
            CreateAccountBtn.Name = "CreateAccountBtn";
            CreateAccountBtn.Size = new Size(323, 45);
            CreateAccountBtn.TabIndex = 8;
            CreateAccountBtn.Text = "Create Account";
            CreateAccountBtn.UseVisualStyleBackColor = true;
            CreateAccountBtn.Click += CreateAccountBtn_Click;
            // 
            // InterestRate
            // 
            InterestRate.AutoSize = true;
            InterestRate.Font = new Font("Simplified Arabic", 14.8F);
            InterestRate.ForeColor = Color.DarkMagenta;
            InterestRate.Location = new Point(8, 383);
            InterestRate.Name = "InterestRate";
            InterestRate.Size = new Size(167, 43);
            InterestRate.TabIndex = 9;
            InterestRate.Text = "Interest Rate :";
            InterestRate.Click += label3_Click;
            // 
            // InterestRateTxt
            // 
            InterestRateTxt.Location = new Point(46, 438);
            InterestRateTxt.Name = "InterestRateTxt";
            InterestRateTxt.Size = new Size(319, 37);
            InterestRateTxt.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Simplified Arabic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 115);
            label3.Name = "label3";
            label3.Size = new Size(138, 39);
            label3.TabIndex = 11;
            label3.Text = "National ID :";
            label3.Click += label3_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Simplified Arabic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 174);
            label4.Name = "label4";
            label4.Size = new Size(110, 43);
            label4.TabIndex = 12;
            label4.Text = "Phone : ";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Simplified Arabic", 14.8F);
            label5.Location = new Point(24, 245);
            label5.Name = "label5";
            label5.Size = new Size(127, 43);
            label5.TabIndex = 13;
            label5.Text = "Address : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Simplified Arabic", 14.8F);
            label6.Location = new Point(24, 313);
            label6.Name = "label6";
            label6.Size = new Size(126, 43);
            label6.TabIndex = 14;
            label6.Text = "Balance : ";
            // 
            // IdTxt
            // 
            IdTxt.Location = new Point(163, 118);
            IdTxt.Name = "IdTxt";
            IdTxt.Size = new Size(202, 37);
            IdTxt.TabIndex = 15;
            IdTxt.TextChanged += textBox1_TextChanged;
            // 
            // PhoneTxt
            // 
            PhoneTxt.Location = new Point(163, 180);
            PhoneTxt.Name = "PhoneTxt";
            PhoneTxt.Size = new Size(202, 37);
            PhoneTxt.TabIndex = 16;
            // 
            // AddressTxt
            // 
            AddressTxt.Location = new Point(163, 251);
            AddressTxt.Name = "AddressTxt";
            AddressTxt.Size = new Size(202, 37);
            AddressTxt.TabIndex = 17;
            AddressTxt.TextChanged += textBox3_TextChanged;
            // 
            // BalanceNum
            // 
            BalanceNum.Location = new Point(163, 320);
            BalanceNum.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            BalanceNum.Name = "BalanceNum";
            BalanceNum.Size = new Size(202, 37);
            BalanceNum.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Simplified Arabic", 14.8F);
            label7.ForeColor = Color.DarkMagenta;
            label7.Location = new Point(8, 490);
            label7.Name = "label7";
            label7.Size = new Size(187, 43);
            label7.TabIndex = 19;
            label7.Text = "Overdraft Limit :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Stencil", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkMagenta;
            label8.Location = new Point(663, -1);
            label8.Name = "label8";
            label8.Size = new Size(166, 33);
            label8.TabIndex = 20;
            label8.Text = "Welcome !";
            label8.Click += label8_Click;
            // 
            // OverdraftNum
            // 
            OverdraftNum.Location = new Point(42, 536);
            OverdraftNum.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            OverdraftNum.Name = "OverdraftNum";
            OverdraftNum.Size = new Size(323, 37);
            OverdraftNum.TabIndex = 21;
            // 
            // ApplyInterestBtn
            // 
            ApplyInterestBtn.BackColor = Color.Plum;
            ApplyInterestBtn.Location = new Point(877, 557);
            ApplyInterestBtn.Name = "ApplyInterestBtn";
            ApplyInterestBtn.Size = new Size(433, 49);
            ApplyInterestBtn.TabIndex = 22;
            ApplyInterestBtn.Text = "Apply Interest";
            ApplyInterestBtn.UseVisualStyleBackColor = false;
            ApplyInterestBtn.Click += ApplyInterestBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 667);
            Controls.Add(ApplyInterestBtn);
            Controls.Add(OverdraftNum);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(BalanceNum);
            Controls.Add(AddressTxt);
            Controls.Add(PhoneTxt);
            Controls.Add(IdTxt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(InterestRateTxt);
            Controls.Add(InterestRate);
            Controls.Add(CreateAccountBtn);
            Controls.Add(WithdrawBtn);
            Controls.Add(DepositBtn);
            Controls.Add(DataGrid);
            Controls.Add(AmountNum);
            Controls.Add(OwnerTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Simplified Arabic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)InterestRateTxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)BalanceNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)OverdraftNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox OwnerTxt;
        private NumericUpDown AmountNum;
        private DataGridView DataGrid;
        private Button DepositBtn;
        private Button WithdrawBtn;
        private Button CreateAccountBtn;
        private Label InterestRate;
        private NumericUpDown InterestRateTxt;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox IdTxt;
        private TextBox PhoneTxt;
        private TextBox AddressTxt;
        private NumericUpDown BalanceNum;
        private Label label7;
        private Label label8;
        private NumericUpDown OverdraftNum;
        private Button ApplyInterestBtn;
    }
}
