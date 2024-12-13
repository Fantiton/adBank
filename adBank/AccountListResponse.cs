using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adBank
{
    internal class AccountListResponse
    {
        public List<Account> accounts { get; set; }
        public string error { get; set; }
    }
}
