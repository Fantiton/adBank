using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adBank
{
    internal class Transfer
    {
        public int id {  get; set; }
        public int source {  get; set; }
        public int target { get; set; }
        public int amount { get; set; }
        public string title { get; set; }
        public DateTime timestamp { get; set; }
    }
}
