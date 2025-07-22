using System;
using System.ComponentModel.DataAnnotations;

namespace test1.Orders.Dtos;

public class OrderCreationDto
{
    [Required]
    [StringLength(150)]
    public string CustomerName { get; set; }

    [Required]
    public Guid ProductId { get; set; }
}