﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManagement_Application.Commands
{
    public class RecordCommand
    {
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; } // "Borrowed", "Returned", "Overdue"
    }
}
