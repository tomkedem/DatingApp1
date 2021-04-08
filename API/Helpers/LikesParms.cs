namespace API.Helpers
{
    public class LikesParms: PaginationParams
    {
        public int UserId { get; set; }
        public string Predicate { get; set; }
    }
}