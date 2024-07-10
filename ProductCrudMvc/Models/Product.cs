namespace ProductCrudMvc.Models
{
    public class Product
    {
        

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public double UnitePrice { get; set; }

        public string ImageUrl { get; set; }

        public int Quantity { get; set; }

        public Product() { }

        public Product(string title, string description, double unitePrice, string imageUrl, int quantity)
        {
            
            Title = title;
            Description = description;
            UnitePrice = unitePrice;
            ImageUrl = imageUrl;
            Quantity = quantity;
        }

        public Product(int Id, string title, string description, double unitePrice, string imageUrl, int quantity)
        {
            this.Id = Id;
            Title = title;
            Description = description;
            UnitePrice = unitePrice;
            ImageUrl = imageUrl;
            Quantity = quantity;
        }

        
    }
}
