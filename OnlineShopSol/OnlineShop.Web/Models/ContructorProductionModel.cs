namespace OnlineShop.Web.Models
{
    public class ContructorProductionModel
    {
        public DateTime CreationDate { get; set; }
        public int CreationUser { get; set; }
        public DateTime ModifyDate { get; set; }
        public int ModifyUser { get; set; }
        public int DeleteUser { get; set; }
        public DateTime DeleteDate { get; set; }
        public int Deleted { get; set; }
    }
}
