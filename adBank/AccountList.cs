using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Json;

namespace adBank
{
    public partial class AccountList : Form
    {
        public AccountList()
        {
            InitializeComponent();
        }

        private void AccountListSearchButton_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string url = "http://localhost/adApi/adApi/account/list";
            var data = new { input = AccountListTextBox.Text };
            HttpResponseMessage response = client.PostAsJsonAsync(url, data).Result;
            AccountListResponse accountListResponse = response.Content.ReadFromJsonAsync<AccountListResponse>().Result;
            
            AccountListGridView.Columns.Add("accountNo", "Numer Konta");
            AccountListGridView.Columns.Add("email", "Email Właściciela");

            AccountListGridView.Columns[0].Width = 180;
            AccountListGridView.Columns[1].Width = 180;

            foreach (Account account in accountListResponse.accounts)
            {
                AccountListGridView.Rows.Add(account.accountNo, account.email);
            }
        }
    }
}
