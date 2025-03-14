using System;

class Program
{
    static int bakiye = 0; // Bakiye tüm işlemlerde kullanılacak
    static void Main()
    {
        Console.WriteLine("Merhaba! Lütfen Giriş yapınız.");
        KullaniciGiris();
    }

    static void KullaniciGiris()
    {
        Console.Write("İsim Soyisim giriniz: ");
        string adsoyad = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"{adsoyad}, Hoş Geldiniz!");
        Random rnd = new Random();
        int hesapno=rnd.Next(100000, 999999);
        Console.WriteLine($"İşte hesap numaranız: {hesapno} ");

        IslemMenü();
    }

    static void IslemMenü()
    {
        while (true) // sonduz döngü tüm işlemlerde işlem menü önde dursun diye
        {
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz.");
            Console.WriteLine("1. Para Yatır");
            Console.WriteLine("2. Para Çek");
            Console.WriteLine("3. Bakiye Görüntüle");
            Console.WriteLine("4. Çıkış");
            Console.Write("Seçiminiz: ");

            

            string secim = Console.ReadLine();

            if (secim == "1")
            {
                ParaYatir();
            }              
            else if (secim == "2")
            {
                ParaCek();
            }                
            else if (secim == "3")
            {
                BakiyeGör();
            }
            else if (secim == "4")
            {
                Console.WriteLine("Çıkış yapılıyor... İyi günler dileriz <3");
                return;
            }
            else
                Console.WriteLine("Geçersiz seçim! Lütfen tekrar deneyin.");

        }
                
    }

    static void ParaYatir()
    {
       Console.WriteLine("💰 Para yatırma islemine hos geldiniz!");      
        Console.Write("Yatırmak istediğiniz tutarı giriniz: ");
        if (int.TryParse(Console.ReadLine(), out int t)&& t > 0)
        {
            bakiye = bakiye + t;
            Console.WriteLine($"✅ Başarıyla {t} TL yatırdınız.");
            BakiyeGör();
        }
        else
            Console.WriteLine("❌ Geçersiz miktar! Lütfen geçerli bir sayı giriniz.");

    }

    static void ParaCek()
    {
        Console.WriteLine("Para çekme islemine hos geldiniz!");
        Console.Write("Çekmek istediğiniz tutarı giriniz: ");
        
        if(int.TryParse(Console.ReadLine(),out int t)&& t > 0)
        {
            if (bakiye >= t)
            {
                bakiye = bakiye - t;
                Console.WriteLine($"Yeni bakiyeniz: {bakiye} TL");
                BakiyeGör();
            }
            else if (bakiye < t)
            {
                Console.WriteLine("Üzgünüz hesabınızda yeterli miktarda para yok");
                BakiyeGör();
            }
        }
        else
            Console.WriteLine("❌ Geçersiz miktar! Lütfen geçerli bir sayı giriniz.");

    }

    static void BakiyeGör()
    {
        Console.WriteLine($"İşte güncel bakiyeniz {bakiye} TL");
    }

}