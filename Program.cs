using System;
using System.Linq;

namespace Algoritma_Odev
{
    class Program
    {
        static void Main(string[] args)
        {

            CharsAgain();
            StringAnagrami("kavak", "kaavk");
            StringReverse("bilgeadam");
            WordsNumber("Bilge adam cumartesi dersi");
            NotCharsAgain("bilge");
            CharsChanging("bilge adam cumartesi dersi");
            ArrayAdd();
            ArraySort();
            ArryChanging();
            DegiskenDegistirme(34, 24);
            BubbleSort();
            Console.ReadKey();

        }

       //1.Bir string’de yinelenen karakterleri yazdırın.
        static void CharsAgain()
        {
            string str = "bilgeeadamm";
            int n = str.Length;
            string dupstr = "";

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j <= n - 1; j++)
                {
                    if (str[i] == str[j])
                    {
                        dupstr = dupstr + str[i];
                    }
                }
            }
            Console.WriteLine("Tekrarlayan Karakterler: " + dupstr);
        }
        //2.İki string’in birbirinin anagramı olup olmadığı kontrol ediniz.
        static void StringAnagrami(string str1, string str2)
        {
            int a = str1.Length;
            int b = str2.Length;
            if (a == b)
            {
                char[] dizi1 = new char[a];
                char[] dizi2 = new char[a];
                for (int i = 0; i < a; i++)
                {
                    dizi1[i] = str1[i];
                    dizi2[i] = str2[i];
                }
                Array.Sort(dizi1);
                Array.Sort(dizi2);
                Console.WriteLine(dizi1.Equals(dizi1));
            }
            else Console.WriteLine("anagramı olamaz uzunlukarı eşit değil");

        }
        //3.String, reverse metodu kullanılmadan nasıl ters çevirilir?
        static void StringReverse(string str)
        { 
            string chrrvs = "";
            foreach (char chr in str)
            {
                chrrvs =chr.ToString() + chrrvs;
            }
            Console.WriteLine(chrrvs);
        }

        //4.String’deki kelime sayısını yazdırın.
        static void WordsNumber(string str)
        {
            string[] words = str.Split(' ');
            Console.WriteLine(words.Length);
        }

        //6.String’deki karakterlerin birbirlerinden benzersiz olduğunu doğrulayın.
        static void NotCharsAgain(string str)
        {
            int n = str.Length;
            string dupstr = "";

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j <= n - 1; j++)
                {
                    if (str[i] == str[j])
                    {
                        dupstr = dupstr + str[i];
                    }
                }
            }
            int a = dupstr.Length;
            if (a==0)
            {
                Console.WriteLine("Tekrarlayan Karakterler Yok ");
            }
            else
            Console.WriteLine("Tekrarlayan Karakterler Var Bunlarda : " + dupstr);
        }
        //7.String’deki bütün boşluk karakterlerini tire ile değiştirin.
        static void CharsChanging(string str)
        {
            str = str.Replace(" ", "tire");
            Console.WriteLine(str);
        }

        //8.2 Integer Array’deki sayıları ayrı ayrı toplatın, array toplamlarını birbirinden çıkartın.
        static void ArrayAdd()
        {
            
            int[] dizi1 = { 5, 6, 7, 8, 78, 45, 0, 30 };
            int tplm1 = 0;
            int[] dizi2 = { 34, 20, 60, 7, 23, 5, 17, 30 };
            int tplm2 = 0;
            for (int i = 0; i < dizi1.Length; i++)
            {
                tplm1 += dizi1[i];
            }
            for (int i = 0; i < dizi2.Length; i++)
            {
                tplm2 += dizi2[i];
            }
            Console.WriteLine("Birinci dizi toplamı : " + tplm1 + " İkinci dizi toplamı : " + tplm2 + " farkları : " + (tplm1 - tplm2));
        }

        //9.Array’i büyükten küçüğe sıralayın.
        static void ArraySort()
        {
            int[] arry= { 3, 2, 6, 7 ,23,5,17};
            Array.Sort(arry);
            Array.Reverse(arry);
           
            foreach (var item in arry)
            {
                Console.Write(item + ",");
            }
        }
        //10.Integer Array’deki sıfırları, array’in sonuna taşıyın.
        static void ArryChanging()
        {
            int[] arry1 = { 5, 6, 7, 8,0, 78, 45, 0, 30 };
            for (int i = 0; i < arry1.Length; i++)
            {
              

                for (int j = 1; j < arry1.Length; j++)
                {
                    if (arry1[j - 1] == 0)
                    {
                        int tmp = arry1[j - 1];
                        arry1[j - 1] = arry1[j];
                        arry1[j] = tmp;
                    }

                }
                Console.Write(arry1[i] + ",");
            }

        }

        //11.	Geçici değişken kullanmadan 2 numerik değeri birbirleri ile yer değiştirin.
        static void DegiskenDegistirme(int a,int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("İlk Değişken : " + a);
            Console.WriteLine("İkinci değişken : " + b);

        }
        //12 soru
        public static void BubbleSort()
        {
            int[] dizi = { 3, 2, 6, 7, 23, 5, 17, 5 };

            for (int i = 0; i < dizi.Length; i++)
            {
                for (int j = 1; j < dizi.Length; j++)
                {
                    if (dizi[j - 1] > dizi[j])
                    {
                        int tmp = dizi[j - 1];
                        dizi[j - 1] = dizi[j];
                        dizi[j] = tmp;
                    }

                }
                Console.Write(dizi[i]+ ",");

            }

        }
    }
}
