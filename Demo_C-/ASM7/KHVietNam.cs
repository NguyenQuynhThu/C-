using System;
using System.Collections.Generic;
using System.Xml;

namespace ASM7
{
    public class KHVietNam : iHoaDon
    {
        public int maKH;
        public string hoten;
        public string doituong;
        public string ngayraHD;
        public int soluong;

        int[] dinhmuc = {1000, 1200, 1500, 2000};

        public KHVietNam()
        {
        }

        public KHVietNam(int maKh, string hoten, string doituong, string ngayraHd, int soluong)
        {
            maKH = maKh;
            this.hoten = hoten;
            this.doituong = doituong;
            ngayraHD = ngayraHd;
            this.soluong = soluong;
        }

        public int MaKh
        {
            get => maKH;
            set => maKH = value;
        }

        public string Hoten
        {
            get => hoten;
            set => hoten = value;
        }

        public string Doituong
        {
            get => doituong;
            set => doituong = value;
        }

        public string NgayraHd
        {
            get => ngayraHD;
            set => ngayraHD = value;
        }

        public int Soluong
        {
            get => soluong;
            set => soluong = value;
        }

        public int[] Dinhmuc
        {
            get => dinhmuc;
            set => dinhmuc = value;
        }

        public int ThanhTien()
        {
            int thanhtien;
            if (soluong <= 50)
            {
                thanhtien = soluong * dinhmuc[0];
            }
            else if (soluong <= 100)
            {
                thanhtien = 50 * dinhmuc[0] + (soluong - 50) * dinhmuc[1];
            }
            else if (soluong <= 200)
            {
                thanhtien = 50 * dinhmuc[0] + (soluong - 50) * dinhmuc[1] + (soluong - 100) * dinhmuc[2];
            }
            else
            {
                thanhtien = 50 * dinhmuc[0] + (soluong - 50) * dinhmuc[1] + (soluong - 100) * dinhmuc[2] +
                            (soluong - 200) * dinhmuc[3];
            }

            return thanhtien;
        }

        List<KHVietNam> khvnList = new List<KHVietNam>();

        public void NhapKH()
        {
            Console.WriteLine("Vui long nhap thong tin khach hang");
            Console.WriteLine("Ma khach hang:");
            int maKH = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ho ten:");
            string hoten = Console.ReadLine();
            Console.WriteLine("Doi tuong:");
            string doituong = Console.ReadLine();
            Console.WriteLine("Ngay ra hoa don:");
            string ngayraHD = Console.ReadLine();
            Console.WriteLine("Luong dien tieu thu:");
            int soluong = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------------");

            KHVietNam khvn1 = new KHVietNam(maKH, hoten, doituong, ngayraHD, soluong);
            khvnList.Add(khvn1);
        }

        public void XuatHD()
        {
            Console.WriteLine("Thong tin hoa don cua ban nhu sau:");
            Console.WriteLine("Ma khach hang: " + maKH);
            Console.WriteLine("Ho ten: " + hoten);
            Console.WriteLine("Doi tuong: " + doituong);
            Console.WriteLine("Luong dien tieu thu: " + soluong);
            if (soluong <= 50)
            {
                Console.WriteLine("Luong dien don gia 1000: " + soluong);
            }
            else if (soluong <= 100)
            {
                Console.WriteLine("Luong dien don gia 1000: " + 50);
                Console.WriteLine("Luong dien don gia 1200: " + (soluong - 50));
            }
            else if (soluong <= 200)
            {
                Console.WriteLine("Luong dien don gia 1000: " + 50);
                Console.WriteLine("Luong dien don gia 1200: " + 50);
                Console.WriteLine("Luong dien don gia 1500: " + (soluong - 100));

            }
            else
            {
                Console.WriteLine("Luong dien don gia 1000: " + 50);
                Console.WriteLine("Luong dien don gia 1200: " + 50);
                Console.WriteLine("Luong dien don gia 1500: " + 100);
                Console.WriteLine("Luong dien don gia 2000: " + (soluong - 100));
            }

            Console.WriteLine("Thanh tien: " + ThanhTien());
            Console.WriteLine("----------------------------");
        }

        public void SoluongKH()
        {
            Console.WriteLine("So luong khach hang Viet Nam la: {0}" + khvnList.Count);
        }

        public void XuatHD012019()
        {
            DateTime dtXuatHD = DateTime.Parse(ngayraHD);
            
            foreach (KHVietNam khvn in khvnList)
            {
                if (dtXuatHD.Year == 2019 && dtXuatHD.Month  == 1){
                    XuatHD();
                }
            }
        }

        public abstract void TrungBinhThanhTien();
    }
}
