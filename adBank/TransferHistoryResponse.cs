﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adBank
{
    internal class TransferHistoryResponse
    {
        public List<Transfer> transfers;
        public string error;
    }
}