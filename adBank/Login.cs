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
    public partial class Login : Form
    {
        Form1 MainForm;
        public Login(Form1 p)
        {
            MainForm = p;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = EmailTextBox.Text;
            string password = PasswordTextBox.Text;

            HttpClient client = new HttpClient();
            string url = "http://localhost/AdApi/AdApi/login/";

            LoginRequest data = new LoginRequest(login, password);

            HttpResponseMessage response =
                client.PostAsJsonAsync(url, data).Result;
            string json = response.Content.ReadAsStringAsync().Result;
            Token t = JsonConvert.DeserializeObject<Token>(json);
            MainForm.token = t.token;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}