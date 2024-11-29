using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adBank
{
    internal class TransferHistoryRequest
    {
        public string token { get; set; }
        public TransferHistoryRequest(string token)
        {
            this.token = token;
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
