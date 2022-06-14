// Metodlar

// Nedir bu Metodlar ?
// Metodlar bizim için tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır.

// Don't Repeat Yourself - DRY - Kendini Tekrar Etme
// Clean Code - Temiz Kod Yazma
// Best Practice - En iyi uygulama teknikleri

using Metotlar_CSharpTemelleri2;

Product product1 = new Product();
product1.Id = 1;
product1.ProductName = "Elma";
product1.ProductDescription = "Amasya Elması";
product1.ProductUnitPrice = 14.50;

Product product2 = new Product();
product2.Id = 2;
product2.ProductName = "Muz";
product2.ProductDescription = "Yerli Taze Muz";
product2.ProductUnitPrice = 12.25;

Product product3 = new Product();
product3.Id = 3;
product3.ProductName = "Mandalina";
product3.ProductDescription = "Akdenizden Taze Mandalina";
product3.ProductUnitPrice = 15.90;

Product[] products = new Product[] { product1, product2,product3 };

foreach (var product in products)
{
    Console.WriteLine(product.Id + " - " + product.ProductName + " - " + product.ProductDescription + " - " + product.ProductUnitPrice + " TL");
}

SepetManager sepetManager = new SepetManager();
sepetManager.Add(product1);
sepetManager.Add(product2);
sepetManager.Add(product3);
