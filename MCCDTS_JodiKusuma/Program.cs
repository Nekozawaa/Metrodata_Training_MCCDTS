using System;

namespace MCCDTS_JodiKusuma
{
    class Program
    {
        static void Main(string[] args)
        {
            int pilihan = 0;
            do //looping menggunakan do while
            {
                Console.WriteLine("Sistem Pendaftaran Penempatan Kerja");
                Console.WriteLine("1. Input Data Pegawai");
                Console.WriteLine("2. Keluar Dari Sistem");
                Console.WriteLine("-----------------------");
                Console.Write("Masukkan Pilihan : ");
                pilihan = Convert.ToInt32(Console.ReadLine());

                if ((pilihan == 1) || (pilihan == 2)) //decision menggunakan if
                {
                    switch (pilihan) //decision menggunakan switch case
                    {
                        case 1:
                            Console.Clear();
                            InputData();
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Berhasil Keluar !!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Inputan tidak sesuai !!!");
                    Console.Clear();
                }
            } while (pilihan != 2);
        }

        public static void InputData()
        {
            Console.Write("Masukkan ID                     : ");
            string id = Console.ReadLine();  
            Console.Write("Masukkan Nama                   : ");
            string nama = Console.ReadLine();  
            Console.Write("Masukkan Alamat                 : ");
            string alamat = Console.ReadLine();  
            Console.Write("Masukkan NoTelpon               : ");
            string notelp = Console.ReadLine();
            Console.Write("Masukkan Jenis Kelamin [L/P]    : ");
            string email = Console.ReadLine();
            Console.Write("Masukkan Grade Pegawai [A/B/C]  : ");
            string grade = Console.ReadLine();

            Program program = new Program();
            string gaji = program.GradeToGaji(grade);
            Console.WriteLine("Gaji Karyawan Berdasarkan Grade : Rp " + gaji);
            Console.WriteLine();

            Console.Write("Masukkan Nama Perusahaan        : ");
            string perusahaan = Console.ReadLine();
            Console.Write("Masukkan Provinsi Perusahaan    : ");
            string provinsi = Console.ReadLine();

            string[] dataPegawai = {id, nama, alamat, notelp, email, grade, gaji, perusahaan, provinsi};

            Console.Clear();
            Console.WriteLine("Data Berhasil Diinput !");
            Console.WriteLine("");

            Console.Write("Lihat data yang telah diinputkan ? [Y/N] : ");
            string confirm = Console.ReadLine();
            if(confirm == "Y")
            {
                Console.WriteLine("--------------------------------------");
                ViewData(dataPegawai);
                Console.WriteLine("--------------------------------------");
            }
            else
            {
                Console.Clear();
            }
        }

        string GradeToGaji(string grade)
        {
            if (grade == "A")
            {
                return("6.000.000");
            } else if (grade == "B")
            {
                return("5.000.000");
            } else if (grade == "C")
            {
                return ("4.000.000");
            }
            else
            {
                return ("Grade yang dimasukkan salah !");
            }
        }

        public static void ViewData(string[] dataPegawai)
        {
            foreach (var item in dataPegawai)
            {
                Console.WriteLine(item);
            }
        }
    }
}
