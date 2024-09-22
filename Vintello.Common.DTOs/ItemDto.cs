namespace Vintello.Common.DTOs;

public class CreateItemDto
{
    public int UserId { get; set; }
    public int CategoryId { get; set; }
    public string Title { get; set; } = null!;
    public decimal Price { get; set; }
    public string[] Images { get; set; } = null!;
}
public class RetriveAllItemDto
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Title { get; set; } = null!;
    public string Status { get; set; } = null!;
    public decimal? Price { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public List<string>? Images { get; set; }
}