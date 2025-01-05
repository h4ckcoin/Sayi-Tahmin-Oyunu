using System;

namespace SayiTahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int tutulanSayi = random.Next(1, 101); // 1-100 arasında rastgele sayı
            int tahmin = 0;
            int hak = 5; // Örnek olarak 5 tahmin hakkı

            Console.WriteLine("Sayı Tahmin Oyununa Hoş Geldiniz!");
            Console.WriteLine("1-100 arası bir sayı tuttum, bakalım bulabilecek misiniz?");
            
            while (hak > 0)
            {
                Console.Write($"Tahmininiz ({hak} hakkınız kaldı): ");
                // ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- 
                // validInput :  
                // ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- 
                // bool validInput, TryParse metodundan dönen boolean değeri saklar.
                // Eğer kullanıcı geçerli bir sayı girdiyse validInput true olur, aksi durumda false olur.
                // Böylece girilen verinin doğru formatta (geçerli bir sayı) olup olmadığını kontrol edebilirsiniz.
                // ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- 
                // int.TryParse : 
                // ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- 
                // Kullanıcının Console.ReadLine() ile girdiği değeri int (tamsayı) tipine dönüştürmeye çalışır.
                // Dönüşüm başarılı olursa true, başarısız olursa false döndürür.
                // Başarılı olduğunda, dönüştürülen tamsayı değeri out tahmin parametresine atanır.
                // Başarısız olduğunda tahmin değişkeni varsayılan değeri (0) alır ve geri dönüş false olur.
                // ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- 
                // out : 
                // ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- 
                // C#’ta out anahtar sözcüğü, bir metodun içinde değer ataması yapılacak olan ve
                // bu değerin metot dışında da kullanılmasını sağlayan bir parametre tanımlama şeklidir.
                // TryParse metodu geriye bool (true/false) değer döndürür (dönüş tipi).
                // Aynı zamanda out parametresi üzerinden tahmin değişkenine kullanıcıdan alınan değeri (eğer dönüştürme başarılı olursa) atar.
                // Böylece tek bir metod ile hem “dönüşüm başarılı mı?” bilgisini almış,
                // hem de başarı durumunda dönüştürülmüş değeri tahmin değişkeninde saklamış olursunuz.
                // ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- 
                bool validInput = int.TryParse(Console.ReadLine(), out tahmin);
                // ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- 
                // Console.ReadLine() :
                // ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- 
                // yazılan metni (satırı) alarak bir string olarak döndürür. Eğer programda tamsayı gibi farklı
                // bir türe ihtiyaç varsa (int, double vb.), alınan string parse (dönüştürme) edilmelidir.
                // örnek : 
                // Console.Write("Bir metin girin: ");
                // string girilenMetin = Console.ReadLine();
                // Console.WriteLine("Girdiğiniz metin: " + girilenMetin);
                // ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- 
                
                if (!validInput) 
                    // ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- 
                    // (!validInput)
                    // ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- 
                    // '!' (ünlem) operatörü, logical NOT (mantıksal değil) anlamına gelir.
                    // (!)"Eğer validInput false ise bu bloğu çalıştır."
                    // Başka bir deyişle, validInput == false olduğu durumlarda içindeki kod çalışacaktır.
                    // ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- 
                {
                    Console.WriteLine("Lütfen geçerli bir sayı girin.");
                    continue;
                }

                if (tahmin == tutulanSayi)
                {
                    Console.WriteLine("Tebrikler, doğru tahmin!");
                    break;
                }
                else if (tahmin < tutulanSayi)
                {
                    Console.WriteLine("Daha büyük bir sayı deneyin.");
                }
                else
                {
                    Console.WriteLine("Daha küçük bir sayı deneyin.");
                }
                
                
                // ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- 
                //  -- ve ++ : 
                // ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- 
                // C# dilinde -- ve ++ gibi kısaltmalar, sık kullanılan aritmetik işlemlerde kodun sadeleşmesine yardımcı olur.
                // C# (ve benzeri pek çok dilde) hak--, değer azaltma (decrement) operatörünün kısaltılmış kullanım şeklidir. 
                // Not: hak-- (post-decrement) ve --hak (pre-decrement) arasında, bu ifade tek başına bir satırda kullanıldığında pratikte fark yoktur.
                // Ancak bir ifadenin içinde kullanıldıklarında (örneğin Console.WriteLine(hak--)) değerlendirme sırası bakımından farklı davranırlar.
                // Tek başına satır olarak kullandığınızda ikisi de hak değerini 1 azaltacaktır.
                // ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- 

                
                hak--;
            }
            // ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- 
            // (tahmin != tutulanSayi) : 
            // ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- 
            // ! C#’ta “mantıksal değil” (logical NOT) anlamına gelir.
            // != ise “eşit değil” (not equal to) anlamında kullanılan bir karşılaştırma operatörüdür.
            // Yani tahmin != tutulanSayi, “tahmin değişkeni tutulanSayi değerine eşit değilse” anlamına gelir.
            // ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- 

            if (tahmin != tutulanSayi)
            {
                Console.WriteLine($"Maalesef, doğru sayı {tutulanSayi} idi.");
            }

            Console.WriteLine("Oyun bitti. Tekrar oynamak için programı yeniden başlatabilirsiniz.");
        }
    }
}