namespace OnlineShop.Web.Models
{

    public class ProductionProductsModel : ContructorProductionModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int supplierid { get; set; }
        public int categoryid { get; set; }
        public decimal unitprice { get; set; }
        public byte discontinued { get; set; }

    }
}


