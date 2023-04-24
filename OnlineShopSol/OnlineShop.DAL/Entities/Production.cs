using System;

namespace OnlineShop.DAL.Entities
{
    public  class Production
    {
        public int ProductionID { get; set; }
        public string? Name { get; set; }
        public int  Supplierid { get; set; }
        public int Categoryid { get; set; }
        public decimal Unitprice { get; set; }
        public byte Discontinued { get; set; }
        public int ProductionId { get; set; }
        public DateTime Creation_Date { get; set; }
        public DateTime? Modify_Date { get; set; }
        public int Creation_User { get; set; }
        public int? Modify_User { get; set; }
    }
}
