using System;

namespace baistruct
{
    class Program
    {
        public struct sinhvien
        {
            public string maso226;
            public string hoten226;
            public double diemtoan226;
            public gioitinh gioitinh226;
            public double diemly226;
            public double diemhoa226;
        }
        public enum gioitinh
        {
            Nam,
            Nu
        };
        public enum hocluc
        {
            Yeu,
            TrungBinh,
            Kha,
            Gioi
        };
        public static void nhapDS(ref sinhvien[] sv, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap sinh vien thu " + (i + 1));
                Console.Write("Ho ten: ");
                string ht226 = Console.ReadLine();
                Console.Write("Ma sinh vien: ");
                string msv226 = Console.ReadLine();
                Console.Write("Gioi tinh (0: nam  1: nu): ");
                int gt226 = int.Parse(Console.ReadLine());
                Console.Write("Diem toan: ");
                double dt226 = double.Parse(Console.ReadLine());
                Console.Write("Diem ly: ");
                double dl226 = double.Parse(Console.ReadLine());
                Console.Write("Diem hoa: ");
                double dh226 = double.Parse(Console.ReadLine());


                sv[i].hoten226 = ht226;
                sv[i].maso226 = msv226;
                if (gt226 == 0)
                    sv[i].gioitinh226 = gioitinh.Nam;
                else
                    sv[i].gioitinh226 = gioitinh.Nu;
                sv[i].diemtoan226 = dt226;
                sv[i].diemly226 = dl226;
                sv[i].diemhoa226 = dh226;

            }
        }
        public static void xuatDS(sinhvien[] sv, int n)
        {
            int i = 1;
            foreach (sinhvien item226 in sv)
            {
                Console.WriteLine("----- " + i + " -----");
                Console.WriteLine("Ho ten: " + item226.hoten226);
                Console.WriteLine("Ma sinh vien: " + item226.maso226);
                int gt = (int)item226.gioitinh226;
                if (gt == 0)
                    Console.WriteLine("Gioi tinh: Nam");
                else
                    Console.WriteLine("Gioi tinh: Nữ");
                Console.WriteLine("Diem toan: " + item226.diemtoan226);
                Console.WriteLine("Diem ly: " + item226.diemly226);
                Console.WriteLine("Diem hoa: " + item226.diemhoa226);
                int hocluc = (int)diemTB(item226.diemtoan226, item226.diemly226, item226.diemhoa226);
                switch (hocluc)
                {
                    case 0:
                        Console.WriteLine("Hoc luc: Yeu");
                        break;
                    case 1:
                        Console.WriteLine("Hoc luc: Trung Binh");
                        break;
                    case 2:
                        Console.WriteLine("Hoc luc: Kha");
                        break;
                    case 3:
                        Console.WriteLine("Hoc luc:Gioi");
                        break;

                }

                i++;
            }
        }
        public static hocluc diemTB(double toan, double ly, double hoa)
        {
            double dtb = (toan + ly + hoa) / 3;
            if (dtb <= 4)
                return hocluc.Yeu;
            else if (dtb <= 5)
                return hocluc.TrungBinh;
            else if (dtb <= 7)
                return hocluc.Kha;
            else
                return hocluc.Gioi;
        }
        public static void timKiem(sinhvien[] sv, int n, string ht)
        {
            foreach (sinhvien item117 in sv)
            {
                if (item117.hoten226 == ht)
                {
                    Console.WriteLine("Ho ten: " + item117.hoten226);
                    Console.WriteLine("Ma sinh vien: " + item117.maso226);
                    int gt = (int)item117.gioitinh226;
                    if (gt == 0)
                        Console.WriteLine("Gioi tinh: Nam");
                    else
                        Console.WriteLine("Gioi tinh: Nữ");
                    Console.WriteLine("Diem toan: " + item117.diemtoan226);
                    Console.WriteLine("Diem ly: " + item117.diemly226);
                    Console.WriteLine("Diem hoa: " + item117.diemhoa226);
                    int hocluc = (int)diemTB(item117.diemtoan226  , item117.diemly226, item117.diemhoa226);
                    switch (hocluc)
                    {
                        case 0:
                            Console.WriteLine("Hoc luc: Yeu");
                            break;
                        case 1:
                            Console.WriteLine("Hoc luc: Trung Binh");
                            break;
                        case 2:
                            Console.WriteLine("Hoc luc: Kha");
                            break;
                        case 3:
                            Console.WriteLine("Hoc luc:Gioi");
                            break;

                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so sinh vien: ");
            int n226 = int.Parse(Console.ReadLine());
            sinhvien[] sv226 = new sinhvien[n226];
            nhapDS(ref sv226, n226);
            Console.WriteLine("\n\n==========DANH SACH SINH VIEN==========");
            xuatDS(sv226, n226);

            Console.WriteLine("\n==========TIM KIEM SINH VIEN==========");
            Console.Write("Nhap ten sinh vien: ");
            string ht226 = Console.ReadLine();
            timKiem(sv226, n226, ht226);

            Console.ReadLine();
        }
    }
}
