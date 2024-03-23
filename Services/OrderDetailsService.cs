using CsvImporter.Models;
using CsvImporter.Repositories;
using CsvHelper;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;

namespace CsvImporter.Services;

public class OrderDetailsService : IOrderDetailsService
{
    
    private readonly IOrderDetailsRepository _repository;

    public OrderDetailsService(IOrderDetailsRepository repository)
    {
        _repository = repository;
    }


    public async Task<IEnumerable<OrderDetails>> GetOrderDetailsAsync(int limit = 100, int offset = 0)
    {
        return await _repository.GetOrderDetailsAsync(limit, offset);
    }

    public async Task<string> UploadOrdersData(IFormFile file)
    {
        var orderDetails = ReadCsv(file);
        return await _repository.SaveMultipleOrdersAsync(orderDetails);
    }

    private List<OrderDetails> ReadCsv(IFormFile filePath)
    {
        var orderDetails = new List<OrderDetails>();
        using (var reader = new StreamReader(filePath.OpenReadStream()))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            orderDetails.AddRange(csv.GetRecords<OrderDetails>().ToList());
        }

        return orderDetails;
    }

}