
namespace KütüphaneYönetimSistemi
{
    public class Kitap
    {
         List<Kitap> yenikitap = new List<Kitap>();
      
        public string ad { get; set; }
        public string yazar { get; set; }
        public int yil { get; set; }
        public string tur { get; set; }

        public Kitap(string? ad, string? yazar, int yil, string? tur)
        {
            this.ad = ad;
            this.yazar = yazar;
            this.yil = yil;
            this.tur = tur;
        }

        public Kitap()
        {
        }

        public override string ToString()
        {
            return $"{ad} - {yazar} ({yil}) - Tür: {tur}";
        }
       

        public void KitapEkle()
        {


            Console.WriteLine("Kaç tane kitap eklemek istiyorsunuz");
            int eklenecekKitapSayısı=Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i <= eklenecekKitapSayısı-1; i++)
            {
                Console.Write("Kitap Adı: ");
                string ad = Console.ReadLine();

                Console.Write("Yazar: ");
                string yazar = Console.ReadLine();

                Console.Write("Yıl: ");
                int yil = Convert.ToInt32(Console.ReadLine());
                
                Console.Write("Tür: ");
                string tur = Console.ReadLine();

                Kitap a = new Kitap(ad, yazar, yil, tur);
                yenikitap.Add(a);

                new Kitap("Suç ve Ceza", "Dostoyevski", 1866, "Roman");

                if (eklenecekKitapSayısı >=2)
                {
                    Console.WriteLine("-----Diğer kitap-----");
                }
            }
        }

        public void KitapListele()
        {
            foreach(var a in yenikitap) 
            { Console.WriteLine(a.ToString()); }
        }

        public void KitapAra()
        {
            Console.WriteLine("Araamak istediğiniz kitabın adını giriniz:  ");
            string aranan=Console.ReadLine();

            bool bulundu=false;

            Console.WriteLine("Arama sonuçları: ");
            
            foreach(var kitap in yenikitap)
            {Console.WriteLine(kitap);

            }
           

        }




    }

}

