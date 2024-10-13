using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20230608_StreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StreamReader sınıfı ile bir dosya içerisindeki yazıları okuyabiliriz
            //Bu sınıfı kullanabilmek için System.Io kütüphanesi gerekli
            StreamReader okuyucu = new StreamReader(@"C:\Users\pcc\Desktop\Yeni klasör\deneme.txt");

            //readline() metodu ile ilk satırı okuyabiliriz
            //Console.WriteLine(okuyucu.ReadLine());

            //EndOfStream properties i streamreader içerisinde bulunan dosyada son satıra kadar okuma işlemi yapar.Okuduğu satır son satır mı değil mi sorgulaması yapar geriye bool veritpinde değer döndürür

            while (!okuyucu.EndOfStream)
            {
                Console.WriteLine(okuyucu.ReadLine());
            }


            Console.ReadKey();
        }
    }
}
