using Model;

namespace Linku
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Ticket> ticketList = new List<Ticket>()
            {
                new Ticket(){Status = Status.New, Title = "T1"},
                new Ticket(){Status = Status.New, Title = "T2"},
                new Ticket(){Status = Status.Old, Title = "T3"},
                new Ticket(){Status = Status.Old, Title = "T4"},
                new Ticket(){Status = Status.Resolved, Title = "T5"},
                new Ticket(){Status = Status.Resolved, Title = "T5"},
                new Ticket(){Status = Status.Resolved, Title = "T5"},
                new Ticket(){Status = Status.Resolved, Title = "T5"},
            };


            var item = ticketList.Where(m => m.Title == "T1").ToList();
            var newItem = ticketList.Where(m => m.Status == Status.New).ToList();
            var newAndResolved = ticketList.Where(t => t.Status == Status.New && t.Status == Status.Resolved).ToList();
            var titleStartOnT = ticketList.Where(ticket => ticket.Title.StartsWith("T")).ToList();
            var titleInclude = ticketList.Where(u => u.Title.Contains("T4"));

            var NewTicked = ticketList.Select(oldTicket => new SelectTicketItem()
            {
                Text = oldTicket.Title,
                Value = oldTicket.Status.ToString()
            });

            Console.WriteLine("Hello, World!");
        }


        static bool Funkcja(Ticket ticket)
        {
            return ticket.Title == "T1";
        }
    }
}