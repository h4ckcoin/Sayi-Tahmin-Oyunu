// Sayı Tahmin Oyunu Başlangıç Kısmı:

// Bu proje, C# ile geliştirilmiş basit bir konsol tabanlı sayı tahmin oyunudur.
// Bilgisayar 1-100 arasında rastgele bir sayı tutar ve kullanıcının bu sayıyı
// belirli bir tahmin hakkı (veya sınırsız hak) ile bilmeye çalışmasını hedefler.
//
// Nasıl Çalışır?
// 1. Program başladığında 'Random' sınıfı ile 1-100 arasında rastgele bir sayı tutulur.
// 2. Kullanıcıdan, bu sayıyı bulması için her tahminde bir tamsayı girişi istenir.
// 3. Kullanıcıya örnek olarak 5 tahmin hakkı verilir. Tahmin hakkı sıfırlanana veya
//    doğru sayı bulunana kadar şu geri bildirimler verilir:
//      - Tahmin, tutulan sayıdan küçük ise: "Daha büyük bir sayı deneyin."
//      - Tahmin, tutulan sayıdan büyük ise: "Daha küçük bir sayı deneyin."
//      - Tahmin doğru ise: "Tebrikler, doğru tahmin!" (Oyun sonlanır)
// 4. Tüm haklar bittiğinde sayı hâlâ tahmin edilmediyse, "Maalesef, doğru sayı x idi."
//    mesajı gösterilir ve oyun biter.

// Notlar ve Açıklamalar:
//
// 1. Random random = new Random();
//    - C#’ta rastgele sayı üretmek için 'Random' sınıfı kullanılır.
//    - 'random.Next(1, 101)' ifadesi, 1 ile 100 (dahil) arasında bir tamsayı üretir.
//
// 2. bool validInput = int.TryParse(Console.ReadLine(), out tahmin);
//    - 'Console.ReadLine()', kullanıcının girdiği metni (string) alır.
//    - 'int.TryParse(...)', bu metnin int türüne dönüştürülüp dönüştürülemeyeceğini kontrol eder.
//    - Başarılı olursa 'validInput' true döner ve 'tahmin' değişkenine dönüştürülmüş değer atanır.
//    - Başarısız olursa 'validInput' false döner; bu durumda 'tahmin' varsayılan değeri (0) alır.
//
// 3. if (!validInput) {...}
//    - '!' (ünlem) operatörü 'mantıksal NOT' işlemi yapar.
//    - Yani 'validInput' false ise (geçerli bir sayı girilmemişse) bu blok çalışır.
//
// 4. hak--;
//    - Bu ifade 'hak' değişkenini 1 azaltır (post-decrement).
//    - Kodun daha sade ve kısa yazılmasını sağlar.
//
// 5. Değiştirilebilir Parametreler:
//    - 'int hak = 5;' satırında isterseniz tahmin hakkını artırabilir veya azaltabilirsiniz.
//    - 'random.Next(1, 101);' ifadesindeki aralık (1, 101) değiştirilerek tahmin edilmesi gereken sayı aralığı genişletilebilir.
