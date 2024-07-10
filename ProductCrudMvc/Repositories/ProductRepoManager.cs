using ProductCrudMvc.Models;

namespace ProductCrudMvc.Repositories
{
    public class ProductRepoManager : IProductRepoManager
    {
        public void AddProduct(Product product)
        {
            using (var context = new EStoreCollectionContext())
            {
                context.products.Add(product);
                context.SaveChanges();
            }
            
        }

        public void DeleteProduct(int id)
        {
            using(var context = new EStoreCollectionContext())
            {
                var productById = context.products.Find(id);
                context.products.Remove(productById);
                context.SaveChanges();
            }
            
        }

        public List<Product> getAllProducts()
        {
            using (var context = new EStoreCollectionContext())
            {
                var products = from Product
                                   in context.products
                               select Product;
                return products.ToList<Product>();
            }
           
            
        }

        public Product GetProductById(int id)
        {
            using( var context = new EStoreCollectionContext())
            {
                var product = context.products.Find(id);

                return product;
            }
            
        }

        public void UpdateProduct(Product product)
        {
            using (var context = new EStoreCollectionContext())
            {
                var productById= context.products.Find(product.Id);

                if(productById != null)
                {
                    productById.Title = product.Title;
                    productById.Description = product.Description;
                    productById.UnitePrice = product.UnitePrice;
                    productById.ImageUrl = product.ImageUrl;
                    productById.Quantity = product.Quantity;

                    context.SaveChanges();
                }
            }


        }
    }
}
