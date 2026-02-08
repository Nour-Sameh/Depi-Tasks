using System.ComponentModel;
using System.Security.Principal;

namespace BankAccountApp
{
    public partial class Form1 : Form
    {
        BindingList<BankAccount> accounts = new BindingList<BankAccount>();
        public Form1()
        {
            InitializeComponent();
            DataGrid.DataSource = accounts;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (InterestRateTxt.Value > 0 && OverdraftNum.Value > 0)
                {
                    MessageBox.Show("Cannot create account with both Interest Rate and Overdraft Limit.\nPlease choose one type only.");
                    return;
                }
                if (InterestRateTxt.Value > 0)
                {
                    accounts.Add(new SavingAccount(OwnerTxt.Text, IdTxt.Text, PhoneTxt.Text, AddressTxt.Text, BalanceNum.Value, InterestRateTxt.Value));
                }
                else if (OverdraftNum.Value > 0)
                {
                    accounts.Add(new CurrentAccount(OwnerTxt.Text, IdTxt.Text, PhoneTxt.Text, AddressTxt.Text, BalanceNum.Value, OverdraftNum.Value));
                }
                else
                {
                    accounts.Add(new BankAccount(OwnerTxt.Text, IdTxt.Text, PhoneTxt.Text, AddressTxt.Text, BalanceNum.Value));
                }

                OwnerTxt.Clear();
                IdTxt.Clear();
                PhoneTxt.Clear();
                AddressTxt.Clear();
                BalanceNum.Value = 0;
                InterestRateTxt.Value = 0;
                OverdraftNum.Value = 0;

                MessageBox.Show("Account Created Successfully!");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshDataGrid()
        {
            DataGrid.DataSource = null;
            DataGrid.DataSource = accounts;
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            if (DataGrid.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select only one account to perform the operation.");
                return;
            }
            if (AmountNum.Value <= 0)
            {
                MessageBox.Show("Please enter a valid amount greater than zero.");
                return;
            }
            BankAccount selectedAccount = DataGrid.SelectedRows[0].DataBoundItem as BankAccount;
            if (selectedAccount == null) return;
            string result = selectedAccount.Deposit(AmountNum.Value);
            AmountNum.Value = 0;
            RefreshDataGrid();
            MessageBox.Show(result);
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            if (DataGrid.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select only one account to perform the operation.");
                return;
            }

            BankAccount selectedAccount = DataGrid.SelectedRows[0].DataBoundItem as BankAccount;
            if (selectedAccount == null) return;

            if (AmountNum.Value <= 0)
            {
                MessageBox.Show("Please enter a valid amount greater than zero");
                return;
            }

            string result = selectedAccount.Withdraw(AmountNum.Value);
            if (result.Contains("Insufficient")) //ÚáÔÇä äÝÑÞ Èíä ÇáÍÓÇÈíä
            {
                MessageBox.Show(result);
                return;
            }
            AmountNum.Value = 0;
            RefreshDataGrid();
            MessageBox.Show(result);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ApplyInterestBtn_Click(object sender, EventArgs e)
        {
            if (DataGrid.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select only one account");
                return;
            }

            BankAccount selectedAccount = DataGrid.SelectedRows[0].DataBoundItem as BankAccount;

            if (selectedAccount is SavingAccount savingAccount)
            {
                decimal interest = savingAccount.CalculateInterest();
                if (interest > 0)
                {
                    savingAccount.Balance += interest;
                    RefreshDataGrid();
                    MessageBox.Show($"Interest applied: {interest }\nNew balance: {savingAccount.Balance}");
                }
                else
                {
                    MessageBox.Show("No interest to apply");
                }
            }
            else
            {
                MessageBox.Show("Selected account is not a saving account");
            }
        }
    }
}
