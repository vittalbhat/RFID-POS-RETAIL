﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDClient.Desktop
{
    public class ReceiptPayment
    {
        public string Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public decimal Amount { get; set; }
    }
}
