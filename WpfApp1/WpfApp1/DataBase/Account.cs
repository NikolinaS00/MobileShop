using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.DataBase
{
    internal class Account
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string ThemeColor { get; set; }
        public string ThemeFontStyle { get; set; }
        public string ThemeFontSize { get; set;}
        public string Language { get; set; }
        public Account() { }
        
    }
}
