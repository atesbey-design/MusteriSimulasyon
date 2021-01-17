using System;

namespace MusteriSimulasyon
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri[] musterilerim = new Musteri[] { };
            Musteri musteri1 = new Musteri();
            Console.WriteLine("Yapmak istediğiniz işlemi giriniz: \n A-Müsteri ekleme \n B-Müsteri Silme");
            string secım = Console.ReadLine();
            if (secım == "A")
                
            {
                
                Console.WriteLine("*************Müsteri Bilgi Giriş Alanı*************");
                Console.WriteLine("Müsterinin adını giriniz");
                string ad=Console.ReadLine();
                musteri1.Adı = ad;
                Console.WriteLine("Müsterinin soyadını giriniz");
                string soyad = Console.ReadLine();
                musteri1.Soyadı = soyad;
                Console.WriteLine("Müsterinin ID'sini giriniz");
                int ıd = Convert.ToInt32( Console.ReadLine());
                musteri1.Id = ıd;
                MusteriSorgula musterim = new MusteriSorgula();
                musterim.MusteriSorgu(musteri1);
          

                musterilerim[0] = musteri1;
                




            }
            else if(secım=="B")
            { 
                if(musterilerim[0]!=musteri1)
                Console.WriteLine("Kullanıcı silindi."); 
            }

           
            

        }
        
    }
}
