using Tickets.Data.Entities;

namespace Tickets.Data
{
    public class SeedDB
    {
        private readonly DataContext _context;

        public SeedDB(DataContext context)
        {
            _context = context;
        }
        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckEntrancesAsync();
            await CheckTicketsAsinc();
        }

        private async Task CheckTicketsAsinc()
        {
            if (!_context.tickets.Any())
            {
                await AddTicketsAsync();
                await _context.SaveChangesAsync();
            };
        }
        private async Task CheckEntrancesAsync()
        {
            if (!_context.entrances.Any())
            {
                await AddEntranceAsync(1, "Norte");
                await AddEntranceAsync(2, "Sur");
                await AddEntranceAsync(3, "Oriental");
                await AddEntranceAsync(4, "Occidental");

                await _context.SaveChangesAsync();
            };
        }

        private async Task AddTicketsAsync()
        {
            for (int i = 1; i <= 5000; i++)
               
            {
                ticket tickets = new()
                {
                    
                    WasUsed = false,
                    Document = "",
                    Name = "Disponible",
                    entrance = new() { Description = "" },
                    Date =  DateTime.Now

                };
                _context.tickets.Add(tickets);
            }

        }

        private async Task AddEntranceAsync(int id, string description)
        {
            Entrance entrance = new()
            {
                
                Description = description
            };
            _context.entrances.Add(entrance);
        }
    }
}


