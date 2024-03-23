using Microsoft.EntityFrameworkCore;
using CsvImporter.Models;
using Microsoft.AspNetCore.Mvc;

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

    public async Task<string> SaveMultipleOrdersAsync(IEnumerable<OrderDetails> orders)
    {
        try
        {
            _context.OrderDetails.AddRange(orders);
            await _context.SaveChangesAsync();
            return "Success";
        }
        catch(Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}