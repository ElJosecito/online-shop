namespace OnlineShop.Web.Models.Response
{
    public class SupplierDetailResponse
    {

        public bool success { get; set; }

        public SuppliersModel data { get; set; }
        public string message { get; set; }

    }
}
