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

    [HttpPost(Name = "UploadOrderDetails")]
    public async Task<IActionResult> Upload(IFormFile file)
    {
        if (file == null || file.Length == 0)
        {
            return BadRequest("No file uploaded");
        }

        try {
            await _service.UploadOrdersData(file);
            return Ok("File uploaded successfully");
        } catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

}
