using KütüphaneYönetimSistemi;

class Program
{
    static void Main(string[] args)
    {
        Kitap kutuphane = new Kitap();  // Nesne oluşturuldu

        int secim;

        do
        {
            Console.WriteLine("\n--- Kütüphane Menüsü ---");
            Console.WriteLine("1 - Kitap Ekle");
            Console.WriteLine("2 - Kitap Listele");
            Console.WriteLine("3 - Kitap Ara");
            Console.WriteLine("0 - Çıkış");
            Console.Write("Seçiminiz: ");
            secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    kutuphane.KitapEkle();   // ✔ doğru kullanım
                    break;
                case 2:
                    kutuphane.KitapListele(); // ✔ doğru kullanım
                    break;
                case 3:
                    kutuphane.KitapAra();     // ✔ doğru kullanım
                    break;
                case 0:
                    Console.WriteLine("Programdan çıkılıyor...");
              
                    break;
                    

                default:
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                    break;
            }

        } while (secim != 0);
    }
}
