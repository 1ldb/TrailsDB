public class Review : BaseEntity
{
    public int WalkId { get; set; }
    public Walk? Walk { get; set; }
    public string UserId { get; set; } = string.Empty; 
    public int Rating { get; set; }
    public string Comment { get; set; } = string.Empty;
}
