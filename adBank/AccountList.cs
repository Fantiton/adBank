﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adBank
{
    public partial class AccountList : Form
    {
        public AccountList()
        {

        }

        private void AccountListSearchButton_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string url = "http://localhost/AdApi/AdApi/account/list";
        }
    }
}
