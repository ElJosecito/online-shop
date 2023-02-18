using Microsoft.EntityFrameworkCore;

namespace OnlineShop.DAL.Core
{
    public class IDbFactory
    {
        DbContext GetDbContext { get;}
    }
}
