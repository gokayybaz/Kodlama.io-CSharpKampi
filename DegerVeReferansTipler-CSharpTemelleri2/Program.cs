




// int, double, decimal, float, bool(0,1) = Değer Tip
// array, class, interface = Referans Tip

int sayi1 = 45;
int sayi2 = 25;
sayi1 = sayi2;
sayi2 = 65;

Console.WriteLine(sayi1); // 25

// Mantığı şu şekilde açıklayalım ;
/*
   Şimdi bellekte iki adet bölüm vardır (Stack, Heap)
   Değer tip bir değişken oluşturduğumuz zaman bu değişken belleğin sadece stack tarafında oluşturulur.
   Daha sonra oluşturduğumuz değişkenin değerini başka bir değişkenin değerine eşitlediğimiz zaman sadece değerler eşitlenir ve eşitlemede kullandığımız ikinci değişkenle işi biter.
   Böylece bellekte sadece tek bir alanda sadece değerler değişir.
   Bundan dolayı yukarıdaki sonuç sayı1 25 olarak kaldı.
   sayı 2 nin sonradan değerinin değiştirilmesi sayı1 in değerine herhangi bir müdahalesi olmadı.
   Değer tipleri okurken örnek olarak : sayi1'in değeri diye okuma yaparız.
*/


int[] sayilar = new int[] { 100, 200, 300 };
int[] sayilar2 = new int[] { 1500, 2500, 3500 };
sayilar = sayilar2;
sayilar2[0] = 1999;

Console.WriteLine(sayilar[0]); // 1999

/*
  Referans tiplere geçtiğimiz zaman işler burada biraz değişmektedir.
  Referans tip bir değişken oluşturduğumuz zaman ilk önce stack tarafında değişkenimiz oluşuyor daha sonra eşitliğin sağ tarafında bulunan
  new keywordü ile değişkenin değeri heap tarafına yazılıyor ve bu iki taraf birbiri ile adresleşerek haberleşiyorlar.
  Bu durumda new keywordü şu işe yaramaktadır ;
  new yazılınca bellekte heap tarafında bir alan oluşturuluyor ve newden sonraki değerler oraya yazılıyor.
  
  Referans tiplerin çalışma mantığını öğrendik. Şimdi ise buradaki sonucun neden 1999 çıktığına bakalım ;
   - ilk önce iki adet dizi oluşturduk
   - birinci oluşturduğumuz dizinin değerini ikinci oluşturduğumuz dizinin değerine eşitledik
   Burada mantık şu şekilde ilerliyor sayilar adlı dizinin stack tarafındaki adresi sayilar2 adlı dizinin adresine eşitleniyor.
   Bu durumda sayilar1 ve sayilar2 heap ve stack tarafında aynı adresi tutmuş oluyor.
   Aynı adresi tuttukları için sayilar2 nin ilk elemanı değiştirildiği zaman her iki dizi değişkenlerindede değiştiği için cevap 1999 oluyor. Bunun sebebi aynı adresi tuttukları için
   Ve sayilar1 in eşitlemeden önceki adreste tuttuğu veriler dotnet'in gargabe collector aracı tarafından yok ediliyor.
   Bellekte yük oluşturacağından dolayı yok edilmesi gerekiyor.
   dotnet garbage collector bakıyor heap tarafına bunu tutan bir adres yok stack tarafında en iyisi ben bunu yok edim ki bellekte yer açılsın bellek yönetimi güzel olsun diye.
  
*/