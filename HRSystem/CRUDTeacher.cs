using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem
{
    class CRUDTeacher
    {
        Program intr = new Program();
        int i;

        public List<Teacher> teachers { get; set;}
        public CRUDTeacher()
        {
            this.teachers = new List<Teacher>();
        }
        public void inputTeacher()
        {
            Console.Clear();
            string nama, id, kelas, tahun;
            Console.Write("Berapa banyak data Guru yang dimasukkan : ");
            string num = Console.ReadLine();

            for (i = 1; i <= Convert.ToInt32(num); i++)
            {
                Console.Clear();
                Console.WriteLine("========= Input Data " + i + " ==========");
                Console.Write("Masukkan Nama : ");
                nama = Console.ReadLine();
                Console.Write("Masukkan ID : ");
                id = Console.ReadLine();
                Console.Write("Masukkan Tahun Gabung : ");
                tahun = Console.ReadLine();
                Console.Write("Wali Kelas : ");
                kelas = Console.ReadLine();
                Teacher t = new Teacher(nama, id, Convert.ToInt32(tahun), kelas);
                this.teachers.Add(t);
            }
            
        }

            public void printTeacher() {
            int num = teachers.Count();
            Console.Clear();
            for(i=0;i<num; i++)
            {
                Console.WriteLine("=========== Data "+(i+1)+" ===========");
                Console.WriteLine("ID Guru     :"+teachers[i].id);
                Console.WriteLine("Nama Guru   :" + teachers[i].name);
                Console.WriteLine("Tahun Masuk :" + teachers[i].yearJoin);
                Console.WriteLine("Wali Kelas  :" + teachers[i].ofClass);
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("Total Absen      :" + teachers[i].getTotalAbsence());
                Console.WriteLine("Gaji Kotor/bln   :" + teachers[i].getSalary());
                Console.WriteLine("Potongan         :" + teachers[i].getDeductedSalary());
                Console.WriteLine("Gaji Bersih/bln  :" + teachers[i].getTotalSalary());
                Console.WriteLine("Lama Kerja       :" + teachers[i].totalTahunKerja());
                Console.WriteLine("Gaji Tahunan     :" + teachers[i].salaryOnYears());
                Console.WriteLine("Bonus Tahunan    :" + teachers[i].getAnnualBonus());
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Tekan keyboard untuk kembali ke menu utama");
            Console.ReadLine();
        }
        public void inputAbsen() {
            Console.Clear();
            Console.Write(" Masukkan ID Guru: ");
            string id = Console.ReadLine();
            int num = teachers.Count(), count = 0;
            for (i = 0; i < num; i++)
            {
                Console.Clear();
                if (teachers[i].id == id)
                {
                    Console.WriteLine("ID Guru     :" + teachers[i].id);
                    Console.WriteLine("Nama Guru   :" + teachers[i].name);
                    Console.WriteLine("Tahun Masuk :" + teachers[i].yearJoin);
                    Console.WriteLine("Wali Kelas  :" + teachers[i].ofClass);
                    Console.Write("Masukan Total Absen  :");
                    string absen = Console.ReadLine();
                    teachers[i].setTotalAbsence(Convert.ToInt32(absen));
                    count++;
                    break;
                }
            }
            if (count == 0)
            {
                Console.Clear();
                Console.WriteLine(" ID Guru yang anda masukkan salah, silahkan masukkan kembali");
                Console.ReadLine();
                inputAbsen();
            }

        }   
        

        public void hapusData()
        {
            Console.Clear();
            Console.Write(" Masukkan ID Guru yang ingin dihapus: ");
            string id = Console.ReadLine();
            int num = teachers.Count(), count = 0;
            for (i = 0; i < num; i++)
            {
                Console.Clear();
                if (teachers[i].id == id)
                {
                    Console.WriteLine("ID Guru     :" + teachers[i].id);
                    Console.WriteLine("Nama Guru   :" + teachers[i].name);
                    Console.WriteLine("Tahun Masuk :" + teachers[i].yearJoin);
                    Console.WriteLine("Wali Kelas  :" + teachers[i].ofClass);
                    Console.WriteLine("Yakin ingin hapus data ? y/n");
                    string hapus = Console.ReadLine();
                    if (hapus == "y")
                    {
                        //teachers.RemoveAt(i);
                        teachers.RemoveAt(i);
                    }
                   
                    count++;
                    break;
                }
            }
            if (count == 0)
            {
                Console.Clear();
                Console.WriteLine(" ID Guru yang anda masukkan salah, silahkan masukkan kembali");
                Console.ReadLine();
                hapusData();
            }


        }
        
            
    }
}

