namespace LuxuryAssetsApi.Models
{
    public class Asset
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty; // Pl. Óra, Műtárgy, Bor
        public decimal PurchasePrice { get; set; }
        public decimal CurrentValue { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
