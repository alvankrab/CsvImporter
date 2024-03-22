namespace CsvImporter.Models;

public class OrderDetails {
    //order_details_id	order_id	pizza_id	quantity

    public int OrderDetailsId { get; set; }
    public int OrderId { get; set; }
    public string PizzaId { get; set; } 
    public int Quantity { get; set; }
}