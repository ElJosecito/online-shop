using System;

namespace OnlineShop.DAL.Entities
{
    public  class Production
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public int supplierid { get; set; }
        public int categoryid { get; set; }
        public decimal unitprice { get; set; }
        public byte discontinued { get; set; }
        public int ProductionId { get; set; }
        public DateTime Creation_Date { get; set; }
    }
}
