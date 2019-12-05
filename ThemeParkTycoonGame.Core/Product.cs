namespace ThemeParkTycoonGame.Core
{
    public class Product
    {
        public string Name { get; }
        public string Description { get; }
        public double Price { get; }

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