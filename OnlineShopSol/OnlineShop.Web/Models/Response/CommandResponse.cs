using System.Reflection.Emit;

namespace OnlineShop.Web.Models.Response
{
    public class CommandResponse
    {
        public bool success { get; set; }
        public string message { get; set; }
        public dynamic MyProperty { get; set; }
    }
}
