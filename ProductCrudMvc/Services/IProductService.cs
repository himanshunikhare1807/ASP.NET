using ProductCrudMvc.Models;

namespace ProductCrudMvc.Services
{
    public interface IProductService
    {
        public List<Product> getAllProducts();

        public Product GetProductById(int id);

        public void AddProduct(Product product);

         public void UpdateProduct(Product product);

         public void DeleteProduct(int id);
    }
}
