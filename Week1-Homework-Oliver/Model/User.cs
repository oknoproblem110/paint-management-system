using System.Collections.Generic;
using System.Linq;

namespace Week1_Homework_Oliver.Model;

public class User
{
    /// <summary>
    /// 
    /// </summary>
    public string UserName { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public List<Order> OrderHistory { get; set; } = new List<Order>();


    /// <summary>
    /// 
    /// </summary>
    public List<Payment> PaymentHistory { get; set; } = new List<Payment>();
    

    /// <summary>
    /// 
    /// </summary>
    /// <param name="userName"></param>
    /// <param name="userId"></param>
    public User(string userName, int userId)
    {
        UserName = userName;
        UserId = userId;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>

    public Order? GetTheMostExpensiveOrder()
    {
        if (!OrderHistory.Any())
        {
            return null;
        }
        
        return OrderHistory.OrderByDescending(o => o.TotalPrice).FirstOrDefault();
    }


    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public Order? GetTheNewestOrder()
    {
        if (!OrderHistory.Any())
        {
            return null;
        }

        return OrderHistory.OrderByDescending(o => o.CreatedAt).FirstOrDefault();

    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public Payment? GetLowestPayment()
    {
        if (!PaymentHistory.Any())
        {
            return null;
        }
        
        return PaymentHistory.OrderBy(p => p.PaymentAmount).FirstOrDefault();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public Payment? GetNewestPayment()
    {
        if (!PaymentHistory.Any())
        {
            return null;
        }
        return PaymentHistory.OrderByDescending(p => p.CreatedDate).FirstOrDefault();
    }

    
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public List<Payment> GetPaymentOverTen()
    {
        return PaymentHistory.Where(p => p.PaymentAmount > 10).ToList();
    }
}