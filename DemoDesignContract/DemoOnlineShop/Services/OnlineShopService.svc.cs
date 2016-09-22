using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DemoOnlineShop.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OnlineShopService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select OnlineShopService.svc or OnlineShopService.svc.cs at the Solution Explorer and start debugging.
    public class OnlineShopService : IOnlineShopService
    {
        public void AddProductToCart(int productId, int quantity)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public Cart GetShoppingCart()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> ListProducts()
        {
            throw new NotImplementedException();
        }
    }
}
