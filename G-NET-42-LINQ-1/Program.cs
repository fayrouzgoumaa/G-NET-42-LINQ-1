using G_NET_42_LINQ_1.Models;
using System.Linq;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
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
            #region Q7
            var productsWithPosition = Source.ProductList
                .Select((p, index) => new
                {
                    Position = index + 1,
                    Name = p.ProductName
                });

            foreach (var item in productsWithPosition)
            {
                Console.WriteLine($"{item.Position}. {item.Name}");
            }
            #endregion
            #region Q8
            var sortedProducts =  Source.ProductList
                  .OrderBy(p => p.Category)
                  .ThenByDescending(p => p.UnitPrice);

            foreach (var product in sortedProducts)
            {
                Console.WriteLine($"Category: {product.Category}, Name: {product.ProductName}, Price: {product.UnitPrice}");
            }
            #endregion
            #region Q9
            var beveragesSortedByStock = Source.ProductList
                .Where(p => p.Category == "Beverages")
                .OrderByDescending(p => p.UnitsInStock);

            foreach (var product in beveragesSortedByStock)
            {
                Console.WriteLine($"Name: {product.ProductName}, Stock: {product.UnitsInStock}");
            }
            #endregion
            #region Q10
            var ordersFrom1997 =
                    from a in Source.CustomerList
                    from i in a.Orders
                    where i.OrderDate.Year >= 1997
                    select new
                    { a.CustomerID,
                        i.OrderDate
                    };
            

            foreach (var order in ordersFrom1997)
            {
                Console.WriteLine($"CustomerID: {order.CustomerID}, OrderDate: {order.OrderDate:d}");
            }
            #endregion
            #region Q11
            var result = Source.ProductList
            .Select((p, index) => new
            {
                Position = index + 1,
                ProductName = p.ProductName
            });

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Position}. {item.ProductName}");
            }

            #endregion
            #region Q12
            string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var sortedWords = Arr
                .OrderBy(word => word.Length)
                .ThenBy(word => word, StringComparer.OrdinalIgnoreCase);

            foreach (var word in sortedWords)
            {
                Console.WriteLine(word);
            }
            #endregion
            #region Q13
            string[] digits =
            {
            "zero","one","two","three","four",
            "five","six","seven","eight","nine"
            };

            var Result = digits
                .Where(d => d.Length > 1 && d[1] == 'i')
                .Reverse();

            foreach (var digit in  Result)
            {
                Console.WriteLine(digit);
            }
            #endregion


        }
    }
}
