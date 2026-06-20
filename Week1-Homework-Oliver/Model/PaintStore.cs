namespace Week1_Homework_Oliver.Model;

public class PaintStore
{
    /// <summary>
    /// 
    /// </summary>
    public List<PaintProduct> PaintProducts { get; set; }

    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="paintProducts"></param>
    public PaintStore(List<PaintProduct> paintProducts)
    {
        PaintProducts = paintProducts;
    }
}