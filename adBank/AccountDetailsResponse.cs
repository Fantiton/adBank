﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adBank
{
    internal class AccountDetailsResponse
    {
        public string error { get; set; }
        public Account account { get; set; }    
    }
}
