﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManagement_Application.Commands
{
    public class RecordsFilterCommand
    {
        public int? UserId { get; set; }
        public int? BookId { get; set; }
        public DateTime? DueDate { get; set; }
        public string? Status { get; set; }
    }
}
