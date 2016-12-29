using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem
{
    class Program
    {
        static void Main(string[] args)
        {
           
            CRUDTeacher intr = new CRUDTeacher();
            BACK:
            Console.Clear();
            Console.WriteLine("=====================================");
            Console.WriteLine("==Aplikasi HR SMKN 1 Cikarang Barat==");
            Console.WriteLine("=====================================");
            Console.WriteLine("Pilih menu yang tersedia!");
            Console.WriteLine("1. Input Data Guru");
            Console.WriteLine("2. Lihat Data Guru");
            Console.WriteLine("3. Input Data Absen Guru");
            Console.WriteLine("4. Hapus Data");
            Console.WriteLine("5. Keluar");
            Console.Write("Masukkan nomer: ");
            var nomer = Console.ReadLine();
            if (nomer == "1")
            {
                intr.inputTeacher();
                goto BACK;
            }
            else if (nomer == "2")
            {
                intr.printTeacher();
                goto BACK;
            }
            else if (nomer == "3")
            {
                intr.inputAbsen();
                goto BACK;
            }
            else if (nomer == "4")
            {
                intr.hapusData();
                goto BACK;
            }
            else if (nomer == "5")
            {
                return;
            }else
            {
                Console.Clear();
                Console.WriteLine("Input Salah");
                Console.ReadLine();
                goto BACK;
            }

            

        }

        



    }
}
