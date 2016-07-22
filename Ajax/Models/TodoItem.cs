using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ajax.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public int Priority { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
    }
}