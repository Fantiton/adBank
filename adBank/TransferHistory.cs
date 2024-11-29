using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace adBank
{
    public partial class TransferHistory : Form
    {
        public string token;
        public TransferHistory()
        {
            InitializeComponent();
        }

        private void TransferHistory_Load(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string url = "http://localhost/AdApi/AdApi/transfer/history/";
            TransferHistoryRequest data = new TransferHistoryRequest(token);
            HttpResponseMessage response = client.PostAsJsonAsync(url, data).Result;

            TransferHistoryResponse transferHistoryResponse = JsonConvert.DeserializeObject<TransferHistoryResponse>(response.Content.ReadAsStringAsync().Result);
        }
    }
}
