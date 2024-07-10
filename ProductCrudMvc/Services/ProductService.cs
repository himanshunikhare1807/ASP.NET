using ProductCrudMvc.Models;
using ProductCrudMvc.Repositories;

namespace ProductCrudMvc.Services
{
    public class ProductService : IProductService

    {

        private IProductRepoManager prodManager=new ProductRepoManager();
        public void AddProduct(Product product)
        {
            prodManager.AddProduct(product);
        }

        public void DeleteProduct(int id)
        {
            prodManager.DeleteProduct(id);
        }

        public List<Product> getAllProducts()
        {
            return prodManager.getAllProducts();
        }

        public Product GetProductById(int id)
        {
            return prodManager.GetProductById(id);
        }

        public void UpdateProduct(Product product)
        {
            prodManager.UpdateProduct(product);
        }
    }
}
