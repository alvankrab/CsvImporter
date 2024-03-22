using CsvImporter.Models;

namespace CsvImporter.Services;

/// <summary>
/// Order Details Service Interface
/// </summary>
public interface IOrderDetailsService
{
    Task<IEnumerable<OrderDetails>> GetOrderDetailsAsync(int limit = 100, int offset = 0);
}