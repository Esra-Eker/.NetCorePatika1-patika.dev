using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_koleksiyonlar_ve_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //liste içinde int veya string değer tutabildiğimiz gibi nesne de tutabiliriz.

            List<Kullanıcılar> kullaniciListesi = new List<Kullanıcılar> { };
            //bu listeye eleman atayabilmem için kullanıcılar class ının nesnelerine ihtiyacım var.
            Kullanıcılar kullanici1 = new Kullanıcılar();
            kullanici1.Isim = "Esra";
            kullanici1.Soyisim = "Eker";
            kullanici1.Yas = 22;

            Kullanıcılar kullanici2 = new Kullanıcılar();
            kullanici2.Isim = "İrem";
            kullanici2.Soyisim = "Tekin";
            kullanici2.Yas = 23;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            //listeye nesne eklemek için bir diğer yöntem
            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar()
            {
                Isim = "Yagmur",
                Soyisim = "Yılmaz",
                Yas=25
            });

            foreach(var kullanici in kullaniciListesi)
            {
                Console.WriteLine("Kullanıcı adı: " + kullanici.Isim);
                Console.WriteLine("Kullanıcı soyadı: " + kullanici.Soyisim);
                Console.WriteLine("Kullanıcı yaşı: " + kullanici.Yas);

            }

            Console.ReadLine();


        }
    }
    public class Kullanıcılar
    {
        private string isim;
        private string soyisim;
        private int yas;

        //Encapsulate yaptık.
        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
