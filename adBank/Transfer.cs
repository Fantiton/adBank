using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adBank
{
    internal class Transfer
    {
        private int id {  get; set; }
        private Account source {  get; set; }
        private Account target { get; set; }
        private int amount { get; set; }
        private string title { get; set; }
        private DateTime timestamp { get; set; }
    }
}
