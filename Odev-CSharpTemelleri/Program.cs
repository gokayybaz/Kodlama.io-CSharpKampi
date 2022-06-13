

// Ternary operatör ve kullanımı ;

/*
  Tek satırlık if else yapısıdır. Kod okunurluğunu ve daha düzenli olmasını sağlar.
  Kullanımı şu şekildedir ;
  degisken = koşul ? dogruise  : yanlisise
*/

// Switch case yapısı ve kullanımı ;
/*
  Switch case yapısı bir anahtar yapısı gibi düşünülebilir. Kullanımı şu şekildedir;
  int deger = 0;
  switch(deger){
    case 0 :
    Console.WriteLine("Değer 0'a eşittir.");
    break;
    case 1:
    Console.WriteLine("Değer 1'e eşittir.");
    break;
    case 2:
    Console.WriteLine("Değer 2'ye eşittir.");
    default:
    Console.WriteLine("Değer"+deger+"'e eşittir.");
  }

  yukarıda bir değişken oluşturuyoruz ve bu değişkeni switch yapısına veriyoruz.
  Daha sonra case ile yakalamak istediğimiz değeri girip yakalandıktan sonra yapacağı işlemi yazıyoruz.
  case ile yakalarsak diğerlerine bakmasın diye break kullanmak zorundayız. Yani asıl amacı kontrolü durdurmaktır.
  case ile yakalayamıyorsak default ile tanımladığımız değerleri yakalayamadığımızı söylüyoruz.
*/

// While ve Do-While Döngülerinin Kullanımı ;

/*
  While döngüsü aynı diğer döngüler gibidir. Çalışma mantığı aynıdır. Fakat syntax'ı farklıdır. Hemen kullanımına geçelim;
  2 kullanım türü vardır ;
  while döngüsü
  while(koşul){
     koşul sağlandığı sürece tekrar tekrar çalışacak kodlar
  }
  do-while döngüsü
  do {
      koşul sağlandığı sürece tekrar tekrar çalışacak kodlar
  }
  while(koşul) 
  */