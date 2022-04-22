using Tickets.Data;
using Tickets.Data.Entities;

namespace Tickets.fill
{
    public class Listfill
    {
        private readonly DataContext _context;
        public Listfill(DataContext context)
        {
            _context = context;
        }
        public ICollection<ticket> tickets;

    }


}
