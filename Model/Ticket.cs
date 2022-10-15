using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ticket
    {
        public string Title { get; set; }
        public Status Status { get; set; }
    }

    public class SelectTicketItem
    {
        public string Value { get; set; }
        public string Text { get; set; }
    }
}
