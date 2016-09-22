using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DemoOnlineShop.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOnlineShopService" in both code and config file together.
    [ServiceContract]
    public interface IOnlineShopService
    {
        [OperationContract]
        // or GetProducts();
        IEnumerable<Product> ListProducts();
        [OperationContract]
        Product GetProduct(int productId);
        [OperationContract]
        void AddProductToCart(int productId, int quantity);
        [OperationContract]
        Cart GetShoppingCart();
    }

    public class Cart
    {
        public int CartId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Status { get; set; }
        public IList<ProductInCart> Products { get; set; }
    }

    public class ProductInCart
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }

    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Size { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
    }
}
