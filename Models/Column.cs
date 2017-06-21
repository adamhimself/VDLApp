using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VDLApp.Models
{
    public class Column
    {
        public int ColumnID { get; set; }
        public int ColumnNo { get; set; }
        public DateTime DateInstalled { get; set; }
        public DateTime DateShipped { get; set; }
        public string CTS { get; set; }

        public ICollection<Issue> Issues { get; set; }
    }
}
