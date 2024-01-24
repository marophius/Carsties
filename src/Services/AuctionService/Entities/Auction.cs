namespace AuctionService.Entities
{
    public class Auction
    {
        public Guid Id { get; set; }
        public int ReservePrice { get; set; } = 0;
        public string Seller { get; set; } = string.Empty;
        public string Winner { get; set; } = string.Empty;
        public int? SoldAmount { get; set; }
        public int? CurrintHighBid { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public DateTime AuctionEnd { get; set; }
        public EStatus Status { get; set; }
        public Item Item { get; set; }
    }
}
