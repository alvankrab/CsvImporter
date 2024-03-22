using CsvImporter.Models;

namespace CsvImporter.Repositories;

/// <summary>
/// Order Details Repository Interface
/// </summary>
public interface IOrderDetailsRepository
{
    Task<IEnumerable<OrderDetails>> GetOrderDetailsAsync(int limit = 100, int offset = 0);
}