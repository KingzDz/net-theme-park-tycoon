namespace ThemeParkTycoonGame.Core
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Product()
        {
            Name = "untitled Product";
            Description = "New Product";
            Price = 0;

        }

        public Product(string name, string description, double price)
            : this()
        {
            Name = name;
            Description = description;
            Price = price;
        }
    }
}