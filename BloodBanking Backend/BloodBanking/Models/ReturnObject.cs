using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BloodBanking.Models
{
    public class ReturnObject
    {
        public object Data { get; set; }
        public string Msg { get; set; }
        public int Total { get; set; }
        public int Status { get; set; }
    }
}