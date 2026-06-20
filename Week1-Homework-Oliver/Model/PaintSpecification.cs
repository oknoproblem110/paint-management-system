using System;

namespace Week1_Homework_Oliver.Model;

public class PaintSpecification
{
    /// <summary>
    /// 
    /// </summary>
    public string Color { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public int SizeInLiters { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="color"></param>
    /// <param name="sizeInLiters"></param>
    public PaintSpecification(string color, int sizeInLiters)
    {
        Color = color;
        SizeInLiters = sizeInLiters;
    }

    /// <summary>
    /// 
    /// </summary>
    public void DisplaySpecification()
    {
        Console.WriteLine($"Your paint color is {Color} and it is {SizeInLiters}L!");
    }
}