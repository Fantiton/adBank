using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adBank
{
    public partial class NewTransfer : Form
    {
        public string token;
        public string source;
        public NewTransfer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string amount = ((float.Parse(AmountTextBox.Text) * 100)).ToString(); ;
            string target = TargetTextBox.Text;

            HttpClient client = new HttpClient();
            string url = "http://localhost/AdApi/AdApi/transfer/new";
            var data = new { amount = amount, target = target, token = token };
            HttpResponseMessage response = client.PostAsJsonAsync(url, data).Result;

            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Transfer completed successfully");
                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Transfer failed");
            }
        }
    }
}
