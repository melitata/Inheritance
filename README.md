# Inheritance
Proje Özeti
Bu proje, C# dilinde kalıtımın kullanımını basit bir konsol uygulaması üzerinden göstermektedir. Uygulama, BaseKisi adında bir temel sınıf ve ondan türeyen Student (Öğrenci) ve Teacher (Öğretmen) sınıflarını modellemektedir.

Sınıflar
BaseKisi

Özellikler:
FirstName: Kişinin adı.
LastName: Kişinin soyadı.
Metotlar:
DisplayFullName(): Kişinin adını ve soyadını konsola yazdırır.
Student (BaseKisi'den Kalıtım Alır)

Özellikler:
StudentNumber: Öğrencinin numarası.
Metotlar:
DisplayStudentInfo(): Öğrenci numarasını ve ad-soyad bilgisini konsola yazdırır.
Teacher (BaseKisi'den Kalıtım Alır)

Özellikler:
Salary: Öğretmenin maaşı.
Metotlar:
DisplayTeacherInfo(): Öğretmenin maaş bilgisini ve ad-soyadını konsola yazdırır.
Çalıştırma Adımları
Projeyi C# destekleyen bir IDE'de (örneğin Visual Studio veya C# uzantısı ile Visual Studio Code) açın.
Projeyi derleyip çalıştırın.
Main metodu bir örnek Student (Öğrenci) ve Teacher (Öğretmen) nesnesi oluşturur, bu nesnelerin özelliklerine değerler atar ve bilgilerini konsola yazdırır.
