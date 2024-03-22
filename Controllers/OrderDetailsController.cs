using System.Runtime.InteropServices;
using CsvImporter.Models;
using CsvImporter.Services;
using Microsoft.AspNetCore.Mvc;

namespace CsvImporter.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderDetailsController : ControllerBase
{

    private readonly IOrderDetailsService _service;

    public OrderDetailsController(IOrderDetailsService service)
    {
        _service = service;
    }

    [HttpGet(Name = "GetOrderDetails")]
    public async Task<ActionResult<IEnumerable<OrderDetails>>> Get(int limit = 100, int offset = 0)
    {
        var orderDetails = await _service.GetOrderDetailsAsync(limit, offset);
        return Ok(orderDetails);
    }

}
