using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VDLApp.Models
{
    public class Issue
    {
        public int IssueID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ColumnID { get; set; }

        public Column Column { get; set; }

    }
}
