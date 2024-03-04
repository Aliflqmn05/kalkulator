using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            Console.WriteLine("Pilih menu calculator:");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Pembagian");
            cons
            Console.Write("Input nomor menu [1..4]: ");

            int pilihan = int.Parse(Console.ReadLine());
            
            if (pilihan == 1)
            {
                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine()); // proses casting

                Console.Write("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine()); // proses casting

                Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            }

            if (pilihan == 2)
            {
                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine()); // proses casting

                Console.Write("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine()); // proses casting

                Console.WriteLine("Hasil Pengurangan  {0} - {1} = {2}", a, b, Pengurangan(a, b));
            }

            if (pilihan == 3)
            {
                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine()); // proses casting

                Console.Write("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine()); // proses casting

                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            }

            if (pilihan == 4)
            {
                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine()); // proses casting

                Console.Write("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine()); // proses casting

                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
            }

            // int a = 10; //deklarasi variabel a, dg nilai awal 10;
            // int b = 6;  //deklarasi variabel b, dg nilai awal 6;

  

            Console.WriteLine(); // tambahkan baris kosong

 

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static float Pembagian(float a, float b)
        {
            return a / b;
        }

    }
}
