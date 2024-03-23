using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace CsvImporter.Models;

public class OrderDetails {
    //order_details_id	order_id	pizza_id	quantity

    [Name("order_details_id")]
    public int OrderDetailsId { get; set; }
    
    [Name("order_id")]
    public int OrderId { get; set; }
    
    [Name("pizza_id")]
    public string PizzaId { get; set; } 
    
    [Name("quantity")]
    public int Quantity { get; set; }
}