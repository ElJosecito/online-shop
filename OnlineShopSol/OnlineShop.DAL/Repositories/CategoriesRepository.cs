using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;
using OnlineShop.DAL.Context;
using OnlineShop.DAL.Entities;
using OnlineShop.DAL.Interfaces;



namespace OnlineShop.DAL.Repositories
{
    public class CategoriesRepository : Core.RepositoryBase<Categories>, ICategoriesRepository
    {

        private readonly ShopContext _shopContext;
        private readonly ILogger<CategoriesRepository> _logger;

        public CategoriesRepository(ShopContext shopContext, ILogger<CategoriesRepository> logger) : base(shopContext)
        {
            _shopContext = shopContext;
            _logger = logger;
        }
    }
}