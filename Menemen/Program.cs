using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menemen
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            Console.WriteLine("Günün Menüsü Çakallı Menemen :)");
            Console.WriteLine("Buzdolabı Açın !");
            Console.WriteLine("Domates var mı? H/E");
            string Domates = Console.ReadLine().ToUpper();
            
            if (Domates == "H")
            {
                ++a;
            }
            else if (Domates == "E")
            {
                ++b;

            }
            Console.WriteLine("Biber var mı? H/E");
            string Biber = Console.ReadLine().ToUpper();
            if (Biber == "H")
            {
                ++a;
            }
            else if (Biber == "E")
            {
                ++b;

            }
            Console.WriteLine("Yumurta var mı? H/E");
            string Yumurta = Console.ReadLine().ToUpper();
            if (Yumurta == "H")
            {
                ++a;
            }
            else if (Yumurta == "E")
            {
                ++b;

            }
            Console.WriteLine("Tereyagi var mı? H/E");
            string Tereyagi = Console.ReadLine().ToUpper();
            if (Tereyagi == "H")
            {
                ++a;
            }
            else if (Tereyagi == "E")
            {
                ++b;

            }
            Console.WriteLine("Peynir var mı? H/E");
            string Peynir = Console.ReadLine().ToUpper();
            if (Peynir == "H")
            {
                ++a;
            }
            else if (Peynir == "E")
            {
                ++b;

            }
            if (Domates=="E" && Biber=="E" && Yumurta=="E" && Tereyagi == "E" && Peynir == "E")
            {
                Console.WriteLine("Menemen için yeterli malzemeniz var ");
                Console.WriteLine("Biberleri yıkayarak doğrayalım.Domateslerin kabuklarını soyalım ve küçük küçük doğrayalım.Tavaya tereyağını alarak eritelim ve biberleri ilave edelim.Biberler kavrulduktan sonra domatesleri ilave ederek kaynayana kadar bekleyelim.Kaynayan ve yumuşayan domatesleri patates ezici ile güzelce ezelim.Domatesler pişene kadar pişirmeye devam edelim.Daha sonra kırmızı toz biberi ilave edelim karıştıralım.Peynirleri tel tel bölerek menemene ekleyelim, peynirler eriyene kadar karıştıralım.Son olarak yumurtaların sarısını menemene ilave edelim,  yumurtalar piştikten sonra ocaktan alalım. ");
                Console.WriteLine("Çakallı Menemeniz Afiyet olsun");
                Console.ReadLine();
            }
            else if (5==a + b)
            {
                Console.WriteLine("Toplam " + a + " tane eksik malzemeniz var ");
                Console.WriteLine("Menemen yapmakta Kararlımısınız? H/E");
                string karar = Console.ReadLine().ToUpper();
                if (karar=="H")
                {
                    if (Yumurta=="E")
                    {
                        Console.WriteLine("Evinizde soğan varsa soğanlı yumurtada lezetli ve besleyici bir seçenek olabilir :) ");
                        Console.ReadLine();
                    }
                    else Console.WriteLine("Size yardımcı olamadığım için üzgünüm :( iyi günler... ");
                    Console.ReadLine();

                }
                else if (karar == "E") /* Hocam Burası tuaf oldu goto ve TryParse Kullanmak istediğim için yaptım */
                {
                    int sayi = 0;
                    NeKararPara:
                    Console.WriteLine("Ne kar paranız var ");
                    string para = Console.ReadLine();

                    if (int.TryParse(para, out sayi))
                    {
                        Console.WriteLine("Eksik malzemelerinizi tamamlamak üzere sizi markete yolculuyoruz :) ");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Lütfen Numeretik sayi giriniz... ");
                        goto NeKararPara;
                    }
                    
                 
                }
                else
                {
                    Console.WriteLine("Size sorulan soruya istenilen şekilde cevaplamadınız. Size yardımcı olamıcam iyi günler.. ");
                    Console.ReadLine();
                }
            }
            else
	        {
                Console.WriteLine("Size sorulan soruları istenilen şekilde cevaplamadınız. Size yardımcı olamıcam iyi günler.. ");
                Console.ReadLine();
            }
        }
    }
}
