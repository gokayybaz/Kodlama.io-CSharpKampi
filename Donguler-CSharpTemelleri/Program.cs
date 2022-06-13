Console.WriteLine("Hello CSharp Temelleri - Döngüler");


// Döngüler 

// Neden döngüleri kullanırız ?
// Döngüleri birbirine benzeyen işlemleri tekrar etmek için kullanırız.

// Örnek olarak elimizde birden fazla liste verisi var biz bu liste verisini tek tek ekrana yazdırmak istiyoruz. İşte bu gibi durumlarda bizim işimize döngüler yaramaktadır.

// Hemen döngülere bakalım ;

// For döngüsü

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//}

// For döngüsünün yapısına bakalım ;

// for : döngü keywordü
// () : içerisine başlangıç değerini, şartı, ve başlangıç değerini kaç kaç arttırmak istiyorsak onu yazdığımız alan
// {} : döngü çalıştıkça çalışacak kod bloğu

// int i = 0; : Başlangıç değeri
// i<10 : Çalışma Şartı
// i++ : Çalıştıkça başlangıç değerini ne kadar arttıracağımızı belirttiğimiz kısım

// ++ demek 1 arttır demektir.

// Gelelim çalışma mantığına ;
/*
   Döngü bir kere kod bloğu içerisindeki kodları çalıştırdı başlangıç değeri 1 oldu ve hala 10'dan küçük o yüzden
   Tekrar başa döndü tekrar kod bloğunu çalıştırdı ve başlangıç değeri 2 oldu hala 10'dan küçük o yüzden
   Tekrar başa döndü ve böyle devam ede ede 9'a geldi baktı başlangıç değeri 10 olacak 10 10'dan küçük değil işte o zaman döngümüz biter.
*/

// Çalışma mantığı kaba taslak bu şekildedir.

// Not : Başlangıç değerini 1 den fazla arttırmak istiyorsak şu yöntemi uygularız ; 
// Örnek 2 2 arttıralım : i=i+2 şeklinde yazarsak başlangıç değerini 2 2 arttırmış oluruz.
// Aynı şekilde i+=2 şeklindede yazarsak 2 2 arttırmış oluruz.

// For döngüsünü az çok öğrenmiş olduk şimdi ise for döngüsünü kullanabileceğimiz bir ortam oluşturmak için dizi array oluşturalım ;

// Öncelikle Dizi (Array) Nedir ?

// Dizi birden fazla değişkeni veya elemanı içerisinde barındırabilen yapılardır.
// Diziler içerisine girdiğimiz elemanları döngüler ile döneriz.

// Hemen basit bir dizi oluşturup for döngüsü ile dönelim ;

string[] users = new string[]
{
   "Gökay",
   "Hakkı",
   "Benan",
   "Zeynep"
};

for (int i = 0; i < users.Length; i++)
{
    Console.WriteLine(users[i]);
}

// Gördüğümüz üzere bir dizi oluşturduk ve o diziyi bir döngü ile döndük şimdi biraz daha detaya inelim ;

// Burada kullanıcıları bir dizi içerisinde aldık ve aşağıda döngü kullanarak bu kullanıcıları ekrana yazdırdık.

// Eğer dizi ve döngü olmasaydı aşağıdaki gibi yapmak zorunda kalacaktık ;

string user1 = "Benan";
string user2 = "Gökay";

Console.WriteLine(user1);
Console.WriteLine(user2);

// Bu şekilde tek tek kullanıcı oluşturup oluşturduğumuz kullanıcıları ekrana tek tek yazdıracaktık.
// İşte bu yükü üstümüzden atmak için arrayları ve döngüleri kullanırız.

// Döngülerde koşulda dizimizin uzunluğunu belirtmemizin sebebi yeni eleman eklendiğinde otomatik bir şekilde o elemanıda yazdırması için,
// Yoksa her eleman eklediğimizde koşulu tek tek elimizle arttıracaktık.

// Döngü kod bloğu içerisinde yazdırdığımız console.writeline içerisindeki users[i] şu anlama geliyor ;
/*
   Belirttiğimiz dizinin ininci elemanı demek oluyor.
   Bunun sebebi aslında for döngüsünde i bir sayı olarak dönüyor.
   Bizde o sayıyı kullanarak dizideki yazdıracağı elemenı belirtiyoruz.
   Örnek olarak i = 0 olunca dizinin sıfırıncı elemanı yazılıyor.
   i = 1 olunca dizinin birinci elemanı yazılıyor ...
   böyle uzayarak gidip koşulu tamamladıktan sonra döngüyü sonlandırıyor.
*/

// Yukarıda oluşturduğumuz dizi ve o diziyi döndüğümüz döngünün amacı dinamizmi sağlamaktır.

// Gelelim bir diğer döngü yöntemi olan For Each'a ;

// Nedir bu For Each ?

// For Each dizi temelli yapıları tek tek dönmeye yarayan bir diğer döngüdür.

string[] pcParts = new string[]
{
    "Monitor",
    "Keyboard",
    "Mouse",
    "Headphone",
};

foreach (string pcPart in pcParts)
{
    Console.WriteLine(pcPart);
}

// Gelelim çalışma mantığına ;

// Çalışma mantığı aynı for döngüsünde olduğu gibidir. Sadece bunda syntax biraz daha kolaydır.

// Döngü yapısını inceleyelim ;

/*
  foreach : keyword,
  string pcPart : alias (takma isim) - her döndüğü elemana vereceği takma isim
  in pcParts : bu liste içerisinde demek.
  kod bloğu içerisinde artık i değeri belirtmek zorunda değiliz bunun yerine takma adı yazmamız yeterli oluyor.
  İşte syntaxi daha basit olduğundan dolayı dizilerde genellikle foreach'i kullanırız.
*/