using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevNet.Models
{
    public class VPA
    {
        public string VpaId { get; set; }
        public string PayeeName { get; set; }
        public double? Amount { get; set; }
        public string TxnNote { get; set; }
    }
}
