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
