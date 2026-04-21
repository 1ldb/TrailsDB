namespace TrailsDB.Core.Models;

public class Walk : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string? ImageUrl { get; set; }
    public double Length { get; set; }
    public DifficultyLevel Difficulty { get; set; }
    public int RegionId { get; set; }
    public Region? Region { get; set; }
}