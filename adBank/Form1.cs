using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace adBank
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void GetAccountData(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string url = "http://localhost/adApi/adApi/account/";
            url += AccountNoTextBox.Text;
            HttpResponseMessage response = client.GetAsync(url).Result;
            string json = response.Content.ReadAsStringAsync().Result;
            Account account = JsonConvert.DeserializeObject<Account>(json);

            AccountDetailsGroupBox.Enabled = true;
            AccountNameTextBox.Text = account.name.ToString();
            AccountNumberTextBox.Text = account.accountNo.ToString();
            AccountAmountTextBox.Text = account.amount.ToString();
        }
    }
}
