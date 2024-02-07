



using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person person1 = new Person();
            person1.FirsName = "Yaşar";
            person1.LastName = "Kemal";
            person1.DateOfBirthYear = 1923;
            person1.NationalIdentity = 11111111111;

            Person person2 = new Person();
            person2.FirsName = "Yaşar Nuri";
            person2.LastName = "Güntekin";
            person2.DateOfBirthYear = 1889;
            person2.NationalIdentity = 22222222222;


            PttManager pttManager =new PttManager(new PersonManager());
            pttManager.GiveMask(person2);

        }

    }

}



/*
// consolReadLine kullanmasamda console ekranı kapanmıyor zaten. Galiba bir güncelleme ile bu durum düzeltilmiş.
string mesaj = "Selam";
double tutar = 15000;
double eskiKdv = 1.18;
double yeniKdv = 1.2;
int urunSayisi = 10;
double urunFiyat = 12;
bool odemeDurumu = true;

Console.WriteLine(mesaj);
Console.WriteLine("{0} olan kdv oranımız {1}'ye yükseltildi.", eskiKdv, yeniKdv);
Console.WriteLine("{0} tane ürün aldınız Ödemeniz gereken toplam tutar {1} TL'dır.", urunSayisi, (urunSayisi * urunFiyat * yeniKdv));

//Müşterinin ödeme yapıp yapmadığını kontrol eder.
if (odemeDurumu)
{
    Console.WriteLine("Ödeme yapıldı");
}
else
{
    Console.WriteLine("Ödeme yapılmadı");
}
public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
    SelamVer("Engin");
            SelamVer("Deniz");
            SelamVer();
            Topla(20, 32);



        }

        static void SelamVer(string name = "NoName")
        {
            Console.WriteLine("Selam " + name);
        }
        static int Topla(int number1, int number2)
        {
            int result = number1 + number2;
            Console.WriteLine("Toplam : " + result);
            return result;
        }
string[] students = new string[3];
            students[0] = "Ahmet";
            students[1] = "Mehmet";
            students[2] = "Veli";
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }

*/