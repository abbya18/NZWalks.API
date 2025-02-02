namespace NZWalks.API.Models.DTOs
{
    // Has properties we want to communicate back to the client
    public class RegionDto
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string? RegionImageUrl { get; set; }
    }
}
