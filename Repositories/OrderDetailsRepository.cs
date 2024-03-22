using Microsoft.EntityFrameworkCore;
using CsvImporter.Models;

namespace CsvImporter.Repositories;

public class OrderDetailsRepository : IOrderDetailsRepository
{
    
    private readonly CsvImporterDbContext _context;

    public OrderDetailsRepository(CsvImporterDbContext context)
    {
        _context = context;
    }


    public async Task<IEnumerable<OrderDetails>> GetOrderDetailsAsync(int limit = 100, int offset = 0)
    {
        return await _context.OrderDetails.Skip(offset).Take(100).ToListAsync();
    }

}