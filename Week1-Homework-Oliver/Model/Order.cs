using Week1_Homework_Oliver.Enums;

namespace Week1_Homework_Oliver.Model;

public class Order
{
    /// <summary>
    /// 
    /// </summary>
    //private readonly DateTime _createdAt = DateTime.Today;

    public DateTime CreatedAt { get; } = DateTime.Now;
    
    /// <summary>
    /// 
    /// </summary>
    private PaintProduct Product { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public decimal TotalPrice { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public List<PaintProduct> Products { get; set; } = new List<PaintProduct>();
    /// <summary>
    /// 
    /// </summary>
    /// <param name="paintProduct"></param>
    /// <param name="quantity"></param>
    public Order(PaintProduct paintProduct, int quantity)
    {
        Product = paintProduct;
        TotalPrice = Math.Round(Product.GetFinalPrice() * quantity, 2);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="products"></param>
    public Order(List<PaintProduct> products)
    {
        Products = products;
    }
    
    
   /// <summary>
   /// 
   /// </summary>
   /// <returns></returns>
    public decimal GetTotalOrderPrice()
    {
        decimal total = 0;
        
        if (!Products.Any())
        {
            return 0;
        }

        foreach (var product in Products)
        {
            total += product.GetFinalPrice();
        }
        
        return Math.Round(total, 2);
    }
    
    
    /// <summary>
    /// 
    /// </summary>
    public void DisplayOrder()
    {
        Console.WriteLine(!Products.Any()
            ? $"Hi you bought {Product.Name} at {CreatedAt}, and the final price is ${TotalPrice}"
            : $"Hi you bought products at {CreatedAt}, and the final price is ${GetTotalOrderPrice()}");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public PaintProduct? GetMostExpensivePaintProduct()
    {
        if (!Products.Any())
        {
            return null;
        }

        return Products.OrderByDescending(p => p.Price).FirstOrDefault();
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="productId"></param>
    /// <returns></returns>
    public List<PaintProduct> RemoveProduct(int productId)
    {
        return Products.Where(p => p.ProductId != productId).ToList();
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="price1"></param>
    /// <param name="price2"></param>
    /// <returns></returns>
    public List<PaintProduct>? FindPaintInThePriceRange(decimal price1, decimal price2)
    {
        if (price1 >= price2)
        {
            return null;
        }

        return Products.Where(p => p.Price >= price1 && p.Price <= price2).ToList();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="paintType"></param>
    /// <returns></returns>
    public decimal PiantProdcutTotalPrice(PaintType  paintType)
    {
        return Products.Where(p => p.PaintType == paintType).Sum(p => p.Price);

    }
    
    
}