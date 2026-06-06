using G_NET_42_LINQ_1.Models;
using System.Linq;
using System.Xml.Linq;
namespace G_NET_42_LINQ_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            var seafoodProducts = Source.ProductList
                 .Where(p => p.Category == "Seafood");

            foreach (var product in seafoodProducts)
            {
                Console.WriteLine($"Name: {product.ProductName}, Price: {product.UnitPrice}");
            }

            #endregion
            #region Q2
            var productNames = Source.ProductList
                .Select(p => p.ProductName);

            foreach (var name in productNames)
            {
                Console.WriteLine(name);
            }
            #endregion
            #region Q3
            var sortedByPrice = Source.ProductList
                 .OrderBy(p => p.UnitPrice);

            foreach (var product in sortedByPrice)
            {
                Console.WriteLine($"Name: {product.ProductName}, Price: {product.UnitPrice}");
            }

            #endregion
            #region Q4
            var productsBetween10And30 = Source.ProductList
                 .Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);

            foreach (var product in productsBetween10And30)
            {
                Console.WriteLine($"Name: {product.ProductName}, Price: {product.UnitPrice}");
            }

            #endregion
            #region Q5
            var condimentsInStock = Source.ProductList
                 .Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");

            foreach (var product in condimentsInStock)
            {
                Console.WriteLine($"Name: {product.ProductName}, Stock: {product.UnitsInStock}");
            }

            #endregion
            #region Q6
            var productInfo = Source.ProductList
                .Select(p => new
                {
                    Name = p.ProductName,
                    Price = p.UnitPrice,
                    StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
                });

            foreach (var item in productInfo)
            {
                Console.WriteLine($"Name: {item.Name}, Price: {item.Price}, Status: {item.StockStatus}");
            }
            #endregion
            #region Q3

            #endregion
            #region Q3

            #endregion
            #region Q3

            #endregion
            #region Q3

            #endregion
            #region Q3

            #endregion
            #region Q3

            #endregion
            #region Q3

            #endregion
            #region Q3

            #endregion
            #region Q3

            #endregion
            #region Q3

            #endregion
            #region Q3

            #endregion
            var#region Q3

            #endregion
                
                #region Q3

            #endregion
            #region Q3

            #endregion
            #region Q3

            #endregion
            #region Q3

            #endregion
               
                #region Q3

            #endregion
               
                #region Q3

            #endregion
                #region Q3

            #endregion
                #region Q3

            #endregion
                #region Q3

            #endregion
                #region Q3

            #endregion
                #region Q3

            #endregion
                #region Q3

            #endregion
                #region Q3

            #endregion
                #region Q3

            #endregion
                #region Q3

            #endregion
                #region Q3

            #endregion
                #region Q3

            #endregion
                #region Q3

            #endregion
                #region Q3

            #endregion
                #region Q3

            #endregion
                #region Q3

            #endregion

        }
    }
}
