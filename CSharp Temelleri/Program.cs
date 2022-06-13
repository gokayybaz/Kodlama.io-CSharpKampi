Console.WriteLine("Hello CSharp by Baz");

// Değişkenler

// Değişkenler veri tutuculardır.
// Değişkenler veri yönetme işimize yarar ve programlamanın temelidir.
// Değişkenlerde verileri tutarken verinin türüne göre farklı değişken keywordleri kullanırız.

// Metinsel verileri biz 'string' değişken türü ile tutarız.
string kategoriEtiketi = "Kategori";

// Not : C# ve JAVA gibi programlama dilleri syntax konusunda oldukça serttir. Bu yüzden değişken tanımladıktan sonra satır sonuna mutlaka noktalı virgül koymalıyız.
// Genelde her satırın sonuna noktalı virgül koymalıyız.

// Not 2 : C# ve JAVA gibi programlama dilleri çok sert bir şekilde type safety (Tip Güvenliği) 'e dikkat ederler.
// Örnek olarak bir değişken tanımlamak istersek mutlaka o değişkenin veri türüne göre uygun olan değişken tip keywordünü girmemiz gerekir.
// Bir diğer Örnek : string türünde metinsel bir değişken tanımladık diyelim mutlaka o değişkenin değerini metinsel olarak girmemiz gerekir. Yoksa program çalışmaz hata verir.
// Bir diğer tip güvenliği örneği olarak : metinsel bir değişken tanımlarken değişkenin değerini mutlaka çift tırnak içerisinde girmemiz gerekmektedir. Tek tırnak ile oluşturamayız.

// Pekala devam etmeden önce şu konuya bir açıklama getirelim : Biz Neden Değişkenleri Kullanıyoruz ?
// Bu olayı bir örnek vererek anlatayım;
/*
   Bir programcısınız, ve oldukça büyük bir projede bulunuyorsunuz, Bir sayfada 5 adet Kategori yazan yeriniz var ve siz onu şu şekilde tanımladınız ;

   Console.WriteLine("Kategori");
   Console.WriteLine("Kategori");
   Console.WriteLine("Kategori");
   Console.WriteLine("Kategori");
   Console.WriteLine("Kategori");

   Tanımladıktan sonra bir baktınız herşey olduğu gibi çalışıyor herhangi bir problem yok, Herşey güzel ama o istek gelirse çok sıkıntıya gireceksiniz ;
   Yönetim dediki Kategori yazan yerleri Kategoriler olarak değiştirelim. İşte bu durumda bütün Kategori yazan yerleri değiştireceksiniz tek tek.
   Ve diyelim ki bu sayfayı uğraştınız ve bitirdiniz. Ama başka sayfalarda da aynı şekilde aynı Kategori yazısınıda yazdıysanız vay halinize :(
   İşte bu gibi durumlarla karşılaşmamak için biz değişkenleri kullanıyoruz. Diyelimki doğru olanı yapmak istiyoruz hemen göstereyim ;

   string categoryLabel = "Kategori"
   Console.WriteLine(categoryLabel);
   Console.WriteLine(categoryLabel);
   Console.WriteLine(categoryLabel);
   Console.WriteLine(categoryLabel);
   Console.WriteLine(categoryLabel);
   
   Bu şekilde tanımlarsak ve uygularsak tek bir değişkenin değerini değiştirdikten sonra otomatik birşekilde heryerde değer değişecektir.
   Yani merkezi bir değişkene bağlıyoruz.
   İşte yukarıdaki bu anlattığım kötü olaya karşılık şu sözü söylüyoruz ;
   'Do not repeat yourself' - Kendini tekrar etme veya Kendini tekrarlama
   Çok önemli ve uygulanması gereken bir yazılım kuralıdır.
 */

// Kuralıda öğrendiğimize göre devam edelim ;

// Sayısal verileri tutmak için aşağıda bulunan keywordleri kullanırız ;

// Tam sayıları tutmak için 
int age = 18;
// Not : int ile sayısal değişkenler tutarken elbette bir sınırı vardır. Bu yüzden birden fazla tam sayıları tutmak için değişken tipleri bulunmaktadır.

// Ondalıklı sayıları tutmak için
double pi = 3.14;

// Sayısal verileri tutmayı gördük şimdi ise programlamada çok önemlşi olan mantıksal ifadeleri tutmayı görelim ;
bool girisYapmisMi = true;

// Not : Mantıksal değişkenler programlamanın temelidir. binary tarafa vurursak : true 1, false 0 demektir.
// Not 2 : Mantıksal değişkenler ile programımızı dallandırırız. Örnek olarak giriş yapmışsa şu ekran giriş yapmamışsa şu ekran gözüksün gibi vb...

// Mantıksal değişkenleride gördüğümüze göre biraz değişken tanımlamaya ara verelim ve mantıksal değişkenlerle oldukça iç içe olan şart blokları yapısına geçelim ;

// Şart bloklarından en çok kullanılanı if-else veya if-elseif-else yapısıdır.

// Hemen bir if else yapısı oluşturalım ;
if (girisYapmisMi == true)
{
    Console.WriteLine("Kullanıcı sisteme giriş yapmış");
}else
{
    Console.WriteLine("Kullanıcı sisteme giriş yapmamış");
}

// if else bloğumuzu oluşturduk.

// Şimdi bloğu açıklayalım ;
// if : eğer demektir.
// () : içerisine koşul yazılır.
// {} : koşul sağlanırsa bu block içerisindeki kodlar çalışır.
// else : değil ise (koşul sağlanmıyorsa) demektir.
// {} : koşul sağlanmıyorsa çalışacak kodlar yazılır.

// if else bloğunu açıkladık.

// Şimdi ise else if bloğuna bakalım ; 

double dolarDun = 17.30;
double dolarBugun = 17.36;

if (dolarDun > dolarBugun)
{
    Console.WriteLine("Dolar değeri azaldı");
}else if (dolarDun < dolarBugun)
{
    Console.WriteLine("Dolar değeri arttı");
}else
{
    Console.WriteLine("Dolar değeri değişmedi");
}

// Burada else if bloğunu kullanarak aslında tek bir if bloğu içerisinde birden fazla koşul oluşturuyoruz.
// Aslında tamamen birden fazla koşul oluşturmak için else if bloğunu kullanıyoruz diyebiliriz.
// else if leri istediğimiz kadar uzatabiliriz.

// Not : ödevler için kodlama.io sitesine git.


