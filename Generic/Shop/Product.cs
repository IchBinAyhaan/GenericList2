
namespace Shop
{
    internal class Product
    {
        public Product(string name, int count, decimal price)
        {
            Name = name;
            Count = count;
            Price = price;
        }

        public string Name { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
    }
}
