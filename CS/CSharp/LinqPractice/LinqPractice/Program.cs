namespace LinqPractice
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product { Id = 1, Name = "Laptop", Brand = "Dell", Quantity = 5, Price = 46500 },
                new Product { Id = 2, Name = "Camera", Brand = "Canon", Quantity = 7, Price = 32300 },
                new Product { Id = 3, Name = "Tablet", Brand = "Lenovo", Quantity = 2, Price = 18500 },
                new Product { Id = 4, Name = "Desktop", Brand = "HP", Quantity = 9, Price = 78200 },
                new Product { Id = 5, Name = "Earphones", Brand = "Boat", Quantity = 3, Price = 3000 },
                new Product { Id = 6, Name = "Mobile", Brand = "Apple", Quantity = 4, Price = 84000 },
            };
            //var query = from p in products where p.Price>50000 select p;
            //var query = from p in products where p.Id == 1 select p;
            //var query = products.Where(p => p.Price > 50000);
            //var query = products.Sum(p => p.Price);
            var query = products.Where(p => p.Price == products.Max(p => p.Price)).ToList();
            //Console.WriteLine( query );
            //foreach(Product p in query)
            //{
            //   Console.WriteLine($"{p.Id} {p.Name} {p.Brand} {p.Quantity} {p.Price}");
            //}
        }
    }
}