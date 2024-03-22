using CsvImporter.Models;
using CsvImporter.Repositories;

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

    
    // private void BuildDatabase()
    // {
    //     var orderDetails = ReadCsv("./Data/order_details.csv");
    //     _context.OrderDetails.AddRange(orderDetails);
    //     _context.SaveChanges();
    // }

    // private List<OrderDetails> ReadCsv(string filePath)
    // {
    //     var orderDetails = new List<OrderDetails>();

    //     using (var reader = new StreamReader(filePath))
    //     {
    //         // Skip header if present
    //         reader.ReadLine();

    //         while (!reader.EndOfStream)
    //         {
    //             var line = reader.ReadLine();
    //             if (line != null)
    //             {
    //                 var values = line.Split(',');
    //                 var orderDetail = new OrderDetails
    //                 {
    //                     OrderDetailsId = int.Parse(values[0]),
    //                     OrderId = int.Parse(values[1]),
    //                     PizzaId = values[2],
    //                     Quantity = int.Parse(values[3])
    //                 };

    //                 orderDetails.Add(orderDetail);
    //             }
    //         }
    //     }

    //     return orderDetails;
    // }

}