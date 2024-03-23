using CsvImporter.Models;
using Microsoft.AspNetCore.Mvc;

namespace CsvImporter.Services;

/// <summary>
/// Order Details Service Interface
/// </summary>
public interface IOrderDetailsService
{
    Task<IEnumerable<OrderDetails>> GetOrderDetailsAsync(int limit = 100, int offset = 0);

    Task<string> UploadOrdersData(IFormFile file);
}