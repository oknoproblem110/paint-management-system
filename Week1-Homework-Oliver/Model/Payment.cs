using System;
using System.Collections.Generic;
using Week1_Homework_Oliver.Enums;

namespace Week1_Homework_Oliver.Model;

public class Payment
{
    public Payment(User user)
    {
        User = user;
    }

    /// <summary>
    /// 
    /// </summary>
    public Order Order { get; set; } 
    
    /// <summary>
    /// 
    /// </summary>
    public int PaymentId { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public PaymentStatus Status { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public decimal PaymentAmount { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public List<Payment>? Payments { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public DateTime CreatedDate { get; } = DateTime.Now;
    
    /// <summary>
    /// 
    /// </summary>
    public User User { get; set; }
    
    
}