using System;

namespace test1.Orders.Dtos;

public class OrderDto
{
    public Guid Id { get; set; }
    public string CustomerName { get; set; }
    public string ProductName { get; set; } 
    public Guid ProductId { get; set; }
}