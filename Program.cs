using System;

namespace diziler_array_sinifi_metodları
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sort
            int[] sayiDizisi = {23,22,13,43,5,76,17,11};

            System.Console.WriteLine(" *** Sırasız Dizi");
            foreach (var sayi in sayiDizisi)
            System.Console.WriteLine(sayi);

            System.Console.WriteLine(" *** Sıralı Dizi");

            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            System.Console.WriteLine(sayi);

            // clear

            System.Console.WriteLine(" *** Array Clear *** ");

            // sayiDizisi elemanlarını kullanarak 2.index ten itibaren 2 tane elemanı 0'lar.

            Array.Clear(sayiDizisi,2,2);
            foreach (var sayi in sayiDizisi)
            System.Console.WriteLine(sayi);

            // Reverse
        
            System.Console.WriteLine(" *** Array Reverse *** ");

            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            System.Console.WriteLine(sayi);

            //IndexOf
            System.Console.WriteLine(" *** Array IndexOf *** ");

            Console.WriteLine(Array.IndexOf(sayiDizisi,11));


            System.Console.WriteLine(" *** Array Resize *** ");

            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8] =  98;

            foreach (var sayi in sayiDizisi)
            System.Console.WriteLine(sayi);


           
            
        }
    }
}
