using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManagement_Application.Dto
{
    public class RecordResponseDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string BookName { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; }
    }

}
