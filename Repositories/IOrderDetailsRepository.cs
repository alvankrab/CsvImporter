using System.Runtime.CompilerServices;
using CsvImporter.Models;
using Microsoft.AspNetCore.Mvc;

namespace CsvImporter.Repositories;

/// <summary>
/// Order Details Repository Interface
/// </summary>
public interface IOrderDetailsRepository
{
    Task<IEnumerable<OrderDetails>> GetOrderDetailsAsync(int limit = 100, int offset = 0);

    Task<string> SaveMultipleOrdersAsync(IEnumerable<OrderDetails> orders);
}