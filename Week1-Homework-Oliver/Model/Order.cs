namespace Week1_Homework_Oliver.Model;

public class Order
{
    /// <summary>
    /// 
    /// </summary>
    private readonly DateTime CreatedAt = DateTime.Today;
    
    /// <summary>
    /// 
    /// </summary>
    private PaintProduct Product { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    private decimal TotalPrice { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="paintProduct"></param>
    /// <param name="quantity"></param>
    public Order(PaintProduct paintProduct, int quantity)
    {
        Product = paintProduct;
        TotalPrice = Product.GetFinalPrice() * quantity;
    }

    /// <summary>
    /// 
    /// </summary>
    public void DisplayOrder()
    {
        Console.WriteLine($"Hi you bought {Product.Name} at {CreatedAt}, and the final price is {TotalPrice}");
    }

    
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public decimal GetTotalPrice()
    {
        return TotalPrice;
    }
    
}