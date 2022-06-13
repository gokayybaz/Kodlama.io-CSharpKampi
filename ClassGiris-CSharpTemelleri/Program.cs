// Classımızı oluşturduk şimdi gelelim bu classı kullanarak bir nesne oluşturmaya
// Aşağıda değişken Course classı türünde 3 adet değişken oluşturduk
// Daha sonra class olurken oluşturduğumuz özellikleri girmek için course1.CourseName şeklinde . ile o özelliğe ulaştık
// Ve gireceğimiz değeri girdik.
Course course1 = new Course();
course1.CourseName = "Yazılımcı Yetiştirme Kampı";
course1.CourseInstructor = "Engin Demiroğ";

Course course2 = new Course();
course2.CourseName = "Java Kampı";
course2.CourseInstructor = "Engin Demiroğ";

Course course3 = new Course();
course3.CourseName = "Python Kampı";
course3.CourseInstructor = "Engin Demiroğ";

// Daha sonra oluşturduğumuz kursları foreach ile dönmek için bir dizi içerisine aldık
// Dizimizin türü önceden string idi şimdi kendi türümüzü oluşturduğumuz için Class ismimiz olmuş oldu;
Course[] myCourses = new Course[]{
course1,course2,course3
};

// Son olarak oluşturduğumuz diziyi foreach ile dönerek console ekranına bastık.
foreach (var course in myCourses)
{
    Console.WriteLine(course.CourseName + " : " + course.CourseInstructor);
}

// Classlar

// Nedir bu classlar ?
// Classlar içerisinde birden fazla özellik tutabilen bir veri kümesidir.
// Örnek olarak bir E-Ticaret sistemi düşünelim,
// Bu e-ticaret sisteminde ürün sınıfı olsun, bu ürünün adı var, fiyatı var, resim adresi var, satıcısı var
// İşte bu gibi bilgiler class içerisinde tutulur.
// Class oluşturunca kendi veri türümüzü oluşturmuş gibi düşünebiliriz.
// Class kullanmamızın bir diğer sebebi gerçek hayatta veriler tek bir veri olarak gelmiyor içerisinde dallanarak geliyor yukarıdaki örnekteki gibi.
// İşte bundan dolayı biz classlar oluşturuyoruz.

// Gelelim yapısını incelemeye ;
/*
  class : keyword
  Course : isim
  {} : içerisine özellik ve fonksiyon yazılabilecek kod bloğu
  public string CourseName {get; set;} : prop (Property) işte bu özellik oluyor.
  kendi özelliklerimizi oluşturuyoruz.
*/


class Course
{
    public string CourseName { get; set; }
    public string CourseInstructor { get; set; }
}

