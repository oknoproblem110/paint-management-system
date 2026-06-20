using Week1_Homework_Oliver.Enums;
using Week1_Homework_Oliver.Interface;

namespace Week1_Homework_Oliver.Model;

public class PaintProduct : IBuyable
{
    
    
    /// <summary>
    /// 
    /// </summary>
    private readonly double TaxRate = 0.1;
    
    /// <summary>
    /// 
    /// </summary>
    private const double DefaultDiscount = 0.05;
    
    /// <summary>
    /// 
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public int ProductId { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public PaintType PaintType { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public PaintSpecification Specification { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public Brand PaintBrand { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="productId"></param>
    /// <param name="name"></param>
    /// <param name="type"></param>
    /// <param name="specification"></param>
    /// <param name="price"></param>
    /// <param name="paintBrand"></param>
    public PaintProduct(int productId, string name, PaintType type, PaintSpecification specification, decimal price, Brand paintBrand)
    {
        ProductId = productId;
        Name = name;
        PaintType = type;
        Specification = specification;
        Price = price;
        PaintBrand = paintBrand;
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public decimal GetFinalPrice()
    {
        decimal discountedPrice = Price * (decimal)(1 - DefaultDiscount);
        decimal finalPrice = discountedPrice * (1 + (decimal)TaxRate);

        return finalPrice;
    }

    /// <summary>
    /// 
    /// </summary>
    public void DisplayInfo()
    {
        Console.WriteLine($"This paint is {Name} ,and it is a {PaintType} paint, the original price is {Price}," +
                          $" more info: Color is {Specification.Color}, size is {Specification.SizeInLiters}L");
    }

    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="rate"></param>
    /// <param name="isOverridable"></param>
    /// <returns></returns>
    public decimal GetMaxDiscount(int rate, bool isOverridable)
    {
        if (isOverridable)
        {
            return Price * rate / 100;
        }

        return Price * (decimal)DefaultDiscount;
    }
}