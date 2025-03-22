using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManagement_Application.Commands
{
    public class MultipleRecordsCommand
    {
        public int UserId { get; set; }
        public List<int> BookIds { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; }
    }

}
