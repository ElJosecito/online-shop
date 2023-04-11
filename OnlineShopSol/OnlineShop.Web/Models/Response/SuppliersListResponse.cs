namespace OnlineShop.Web.Models.Response
{
    public class SuppliersListResponse
    {
        public bool Success { get; set; }
        public List<SuppliersModel> data { get; set; }
        public string message { get; set; }
    }
}
