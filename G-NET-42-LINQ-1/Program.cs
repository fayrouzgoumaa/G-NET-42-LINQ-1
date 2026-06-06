using G_NET_42_LINQ_1.Models;
using System.Linq;
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
        }
    }
}
