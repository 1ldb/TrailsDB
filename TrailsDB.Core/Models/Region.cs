namespace TrailsDB.Core.Models;
public class Region : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public string? ImageUrl { get; set; }
    public ICollection<Walk> Walks { get; set; } = new List<Walk>();
}