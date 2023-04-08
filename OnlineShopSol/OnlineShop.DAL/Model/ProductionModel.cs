namespace OnlineShop.DAL.Model
{
    public class ProductionModel
    {
        public int ProductionId { get; set; }
        public string Name { get; set; }
        public int supplierId { get; set; }
        public int categoryId { get; set; }
        public decimal unitprice { get; set; }
        public byte discontinued { get; set; }

    }
}