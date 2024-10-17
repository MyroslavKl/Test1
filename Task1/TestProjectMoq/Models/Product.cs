using System.ComponentModel.DataAnnotations;

namespace TestProjectMoq.Models;

public class Product
{
    [Key]
    public int Id { get; set; }
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;
    public int Count { get; set; }
}