using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;

namespace ASM7
{
    public class KHNuocNgoai : iHoaDon
    {
        public int maKH;
        public string hoten;
        public string quoctich;
        public string ngayraHD;
        public int soluong;
        
        public int dinhmuc = 2000;

        public KHNuocNgoai()
        {
        }

        public KHNuocNgoai(int maKh, string hoten, string quoctich, string ngayraHd, int soluong)
        {
            maKH = maKh;
            this.hoten = hoten;
            this.quoctich = quoctich;
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

        public string Quoctich
        {
            get => quoctich;
            set => quoctich = value;
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
        
        public int ThanhTien() {
            int thanhtien = soluong * 2000;
            return thanhtien;
        }

        List<KHNuocNgoai> khnnList = new List<KHNuocNgoai>();
        
        public void NhapKH()
        {
            Console.WriteLine("Vui long nhap thong tin khach hang");
            Console.WriteLine("Ma khach hang:");
            int maKH = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ho ten:");
            string hoten = Console.ReadLine();
            Console.WriteLine("Quoc tich:");
            string doituong = Console.ReadLine();
            Console.WriteLine("Ngay ra hoa don:");
            string ngayraHD = Console.ReadLine();
            Console.WriteLine("Luong dien tieu thu:");
            int soluong = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------------");

            KHNuocNgoai khnn1 = new KHNuocNgoai(maKH, hoten, quoctich, ngayraHD, soluong);
            khnnList.Add(khnn1);
        }

        public void XuatHD()
        {
            Console.WriteLine("Thong tin hoa don cua ban nhu sau:");
            Console.WriteLine("Ma khach hang: " + maKH);
            Console.WriteLine("Ho ten: " + hoten);
            Console.WriteLine("Quoc tich: " + quoctich);
            Console.WriteLine("Luong dien tieu thu: " + soluong);
            Console.WriteLine("Thanh tien: " + ThanhTien());
            Console.WriteLine("----------------------------");
        }

        public void SoluongKH()
        {
            Console.WriteLine("So luong khach hang nuoc ngoai la: {0}" + khnnList.Count);
            
        }

        public void TrungBinhThanhTien() {
            float tongcong;
            float tbtt;
            foreach (KHNuocNgoai khnn in khnnList)
            {
                tbtt = (tongcong =+ thanhtien()) / SoLuongKH();
            }

        }
        
        public void XuatHD012019()
        {
            DateTime dtXuatHD = DateTime.Parse(ngayraHD);           
                                                        
            foreach (KHNuocNgoai khnn in khnnList)                    
            {                                                       
                if (dtXuatHD.Year == 2019 && dtXuatHD.Month  == 1){ 
                    XuatHD();                                       
                }                                                   
            }                                                       
        }
    }
}