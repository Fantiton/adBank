using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace adBank
{
    public partial class Form1 : Form
    {
        public string token;
        public Form1()
        {
            InitializeComponent();
        }

        private void OnAppShown(object sender, EventArgs e)
        {
            GetAccountData();
        }

        public void GetAccountData()
        {
            HttpClient client = new HttpClient();
            string url = "http://localhost/adApi/adApi/account/details";

            var data = new { token = token };
            HttpResponseMessage response = client.PostAsJsonAsync(url, data).Result;
            string json = response.Content.ReadAsStringAsync().Result;
            AccountDetailsResponse accountDetailsResponse =
                JsonConvert.DeserializeObject<AccountDetailsResponse>(json);
            Account account = accountDetailsResponse.account;

            AccountDetailsGroupBox.Enabled = true;
            AccountNameTextBox.Text = account.name.ToString();
            AccountNumberTextBox.Text = account.accountNo.ToString();
            AccountAmountTextBox.Text = ((float)account.amount / 100).ToString();
        }


        private void OnAppLoad(object sender, EventArgs e)
        {
            Login loginForm = new Login(this);
            if (loginForm.ShowDialog(this) == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                Application.Exit();
            }

        }
        private void NewTransferButton_Click(object sender, EventArgs e)
        {
            NewTransfer newTransfer = new NewTransfer();
            newTransfer.token = token;
            newTransfer.source = AccountNumberTextBox.Text;
            if (newTransfer.ShowDialog() == DialogResult.OK)
            {
                GetAccountData();
            }

        }

        private void TransferHistoryButton_Click(object sender, EventArgs e)
        {
            TransferHistory transferHistory = new TransferHistory();
            transferHistory.token = token;
            transferHistory.ShowDialog();
        }
    }
}
