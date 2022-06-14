using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar_CSharpTemelleri2
{
    public class SepetManager
    {
        // Naming Convention - İsimlendirme kuralı
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+" Adlı Ürün Sepete Eklendi !");
        }
        // Bizim yukarıda parametre olarak classdan türemiş bir nesne göndermemizin sebebi örnek veriyorum yönetim başka bir özellikte gönderilecek sepete ekleme kısmına dedi işte bu durumda aşağıdaki yöntemle veri isteseydik kesinlikle patlayacaktık ve çok uğraşacaktık.

        // public void Add2(string productName, string productDescription, string productUnitPrice)
        // {
        //     Console.WriteLine(productName+" Adlı Ürün Sepete Eklendi");
        // }

        // Yukarıdaki yöntem iyi güzel çalışıyor fakat paramatreden bir özellik daha istemiş olsaydık metodu çağırdığımız heryerde o özelliği tekrardan göndermek zorunda kalacaktık.
        // Ama ilk kullanımdaki gibi classdan türetip bir ürün isteseydik sadece o classa gidip yeni bir property ekleyecektik ve sistem çökmeden devam edecekti.
        // İşte bu duruma Encapsulation deniyor.
        // Yani parametre gönderirken class ile kapsülleme mantığına denk geliyor.
        // Biraz daha açıklarsak ayrı ayrı düzensiz parametre isteme yapısını kapsülleyerek daha kolay ve okunabilir hale getirmiş oluyoruz.
        // Bu programlamada kod sürdürülebilirliği açısından oldukça önemlidir.
        // Daha fazla açıklama için https://youtu.be/1j68gb1-qOw?t=6314 bu linke tıkla Engin hocam kampta tamda bu konudan bahsediyor.
    }
}
