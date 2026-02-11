using static ProductsClass.Program;

namespace ProductsClass
{
    // Define a class which contains the following information about products: 
    // name, ID, supplier ID, expire date, quantity, and unit cost.

    //       a.Declare two different appropriate constructor methods.
    //       c.Add a field which holds the number of products.

    class Program
    {
        public class Products
        {
            public string ProductName;
            public int ProductID;
            public int SupplierID;
            public double ProductPrice;
            public int Quantity;
            public DateTime ExpiryTime;

            public static int ProductsCount = 0;

            public Products()
            {
                ProductsCount++;
            }
            public Products(string name, int productId, int supplierId, double price, int qty, DateTime exp)
            {
                ProductName = name;
                ProductID = productId;
                SupplierID = supplierId;
                ProductPrice = price;
                Quantity = qty;
                ExpiryTime = exp;
                ProductsCount++;
            }
            public void display()
            {
                Console.WriteLine($"Name: {ProductName}");
                Console.WriteLine($"ID: {ProductID}");
                Console.WriteLine($"Supplier ID: {SupplierID}");
                Console.WriteLine($"Expire Date: {ExpiryTime.ToShortDateString()}"); 
                Console.WriteLine($"Quantity: {Quantity}"); 
                Console.WriteLine($"Unit Cost: {ProductPrice} $");
                Console.WriteLine("----------------------");
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine($"Products count before adding: {Products.ProductsCount}");

            Products product1 = new Products();
            Products product2 = new Products(
                "Milk",
                120,
                306054,
                36.5,
                5,
                new DateTime( 2026,11,22)
                );

            product2.display();

            Products product3 = new Products();

            Console.WriteLine($"Products count after adding: {Products.ProductsCount}");
        }
    }
}
