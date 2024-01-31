using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.DataBase
{
    internal class ProcurementItem
    {
        public int ProcurementNumber { get; set; }
        public int ArticleId { get; set; }
        public int Amount { get; set; }
        public double TotalPrice { get; set; }
        public string ArticleName { get; set; }
        public double ArticlePrice { get; set; }
        public ProcurementItem() { }    

    }
}
