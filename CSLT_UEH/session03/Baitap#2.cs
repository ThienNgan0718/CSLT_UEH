using System;
using System.Globalization;

    class Baitap_2
    {
        enum CurrencyType
        {
            USD = 1,
            EUR = 2,
            JPY = 3,
            GBP = 4
        }
        static void Bai_01()
        {
            Console.Write("Nhập chỉ số điện cũ (kWh): ");
            decimal csd_cu = decimal.Parse(Console.ReadLine());
            decimal csd_moi;
            do
            {
                Console.Write("Nhập chỉ số điện mới (kWh): ");
                csd_moi = decimal.Parse(Console.ReadLine());
                if (csd_moi >= csd_cu)
                    break;
                else
                    Console.WriteLine("Chỉ số mới phải lớn hơn hoặc bằng chỉ số cũ.");
            } while (true);

            decimal tieuThu = csd_moi - csd_cu;
            decimal TienDien = 0;

            if (tieuThu <= 50)
            {
                TienDien = tieuThu * 1806;
            }

            else if (tieuThu <= 100)
            {
                TienDien = 50 * 1806
                          + (tieuThu - 50) * 1866;
            }
            // Bậc 3: 101 - 200 kWh
            else if (tieuThu <= 200)
            {
                TienDien = 50 * 1806
                      + 50 * 1866
                      + (tieuThu - 100) * 2167;
            }
            // Bậc 4: 201 - 300 kWh
            else if (tieuThu <= 300)
            {
                TienDien = 50 * 1806
                      + 50 * 1866
                      + 100 * 2167
                      + (tieuThu - 200) * 2729;
            }
            // Bậc 5: từ 301 kWh trở lên
            else
            {
                TienDien = 50 * 1806
                      + 50 * 1866
                      + 100 * 2167
                      + 100 * 2729
                      + (tieuThu - 300) * 3050;
            }

            decimal vat = TienDien * 0.08m;
            decimal total = TienDien + vat;

            Console.WriteLine($"Số điện tiêu thụ: {tieuThu} kWh");
            Console.WriteLine($"Tiền điện chưa thuế: {TienDien:C} VNĐ");
            Console.WriteLine($"Thuế VAT (8%): {vat:C} VNĐ");
            Console.WriteLine($"Tổng thanh toán: {total:C} VNĐ");
        }
        static void Bai_02()
        {
            Console.Write("Chiều cao (m): ");
            double height = double.Parse(Console.ReadLine());

            Console.Write("Cân nặng (kg): ");
            double weight = double.Parse(Console.ReadLine());

            // Công thức BMI
            double bmi = weight / Math.Pow(height, 2);

            string PhanLoai;

            if (bmi < 18.5)
            {
                PhanLoai = "Gầy (Thiếu cân)";
            }
            else if (bmi < 23.0)
            {
                PhanLoai = "Bình thường (Lý tưởng)";
            }
            else if (bmi < 25.0)
            {
                PhanLoai = "Thừa cân (Tiền béo phì)";
            }
            else
            {
                PhanLoai = "Béo phì";
            }

            // Cân nặng lý tưởng
            double minWeight = 18.5 * Math.Pow(height, 2);
            double maxWeight = 22.9 * Math.Pow(height, 2);

            Console.WriteLine($"Chỉ số BMI của bạn: {bmi:F2}");
            Console.WriteLine($"Phân loại sức khỏe: {PhanLoai}");
            if (bmi < minWeight && bmi < maxWeight)
                Console.WriteLine($"Khuyến nghị: Cân nặng lý tưởng của bạn nên từ {minWeight:F2} kg đến {maxWeight:F2} kg.");

        }
        static void Bai_03()
        {

            Console.Write("Nhập số tiền VND: ");
            decimal vnd = decimal.Parse(Console.ReadLine());

            Console.WriteLine("1 - USD");
            Console.WriteLine("2 - EUR");
            Console.WriteLine("3 - JPY");
            Console.WriteLine("4 - GBP");

            Console.Write("Chọn loại ngoại tệ: ");
            int luaChon = int.Parse(Console.ReadLine());
            if (luaChon < 1 || luaChon > 4)
            {
                Console.WriteLine("Loại ngoại tệ không hợp lệ!");
                return;
            }
            CurrencyType currency = (CurrencyType)luaChon;

            decimal tyGia = 0;
            string tienTe = "";

            switch (currency)
            {
                case CurrencyType.USD:
                    tyGia = 25400;
                    tienTe = "USD";
                    break;

                case CurrencyType.EUR:
                    tyGia = 27200;
                    tienTe = "EUR";
                    break;

                case CurrencyType.JPY:
                    tyGia = 165;
                    tienTe = "JPY";
                    break;

                case CurrencyType.GBP:
                    tyGia = 32100;
                    tienTe = "GBP";
                    break;

            }

            // Phí dịch vụ 0.5%
            decimal fee = vnd * 0.005m;

            // Tiền sau khi trừ phí
            decimal vndAfterFee = vnd - fee;

            // Đổi sang ngoại tệ
            decimal foreignMoney = vndAfterFee / tyGia;

            Console.WriteLine($"Phí dịch vụ (0.5%): {fee:N0} VND");
            Console.WriteLine($"Số tiền VND tính đổi: {vndAfterFee:N0} VND");
            Console.WriteLine($"Số tiền nhận được: {foreignMoney:F2} {tienTe}");
        }
        static void Bai_04()
        {
            Console.Write("Nhập ngày sinh (dd/mm/yyyy): ");
            string input = Console.ReadLine();

            DateTime birthDate;

            bool hopLe = DateTime.TryParseExact(
                input,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out birthDate
            );

            if (hopLe)
            {
            }
            else
            {
                Console.WriteLine("Ngày sinh không hợp lệ!");
                return;
            }

            DateTime today = DateTime.Now.Date;

            int age = today.Year - birthDate.Year;

            if (today < birthDate.AddYears(age))
            {
                age--;
            }

            int totalDays = (int)(today - birthDate).TotalDays;

            DateTime nextBirthday = new DateTime(
                today.Year,
                birthDate.Month,
                birthDate.Day
            );

            if (nextBirthday < today)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }

            int ngayConLai = (int)(nextBirthday - today).TotalDays;

            Console.WriteLine($"Tuổi hiện tại: {age} tuổi");
            Console.WriteLine($"Bạn đã sống tổng cộng: {totalDays:N0} ngày");
            Console.WriteLine($"Sinh nhật tiếp theo còn: {ngayConLai} ngày nữa");
        }
        static void Bai_05()
        {
            Console.Write("C# (4 TC): ");
            double csharp = double.Parse(Console.ReadLine());

            Console.Write("Toán (3 TC): ");
            double Toan = double.Parse(Console.ReadLine());

            Console.Write("Tiếng Anh (2 TC): ");
            double Eng = double.Parse(Console.ReadLine());

            // Tính điểm trung bình có trọng số
            double scoreAvg =
                (csharp * 4 + Toan * 3 + Eng * 2)
                / (4 + 3 + 2);

            char diemChu;
            double gpa;
            string xepLoai;

            if (scoreAvg >= 8.5)
            {
                diemChu = 'A';
                gpa = 4.0;
                xepLoai = "Xuất sắc / Giỏi";
            }
            else if (scoreAvg >= 7.0)
            {
                diemChu = 'B';
                gpa = 3.0;
                xepLoai = "Khá";
            }
            else if (scoreAvg >= 5.5)
            {
                diemChu = 'C';
                gpa = 2.0;
                xepLoai = "Trung bình";
            }
            else if (scoreAvg >= 4.0)
            {
                diemChu = 'D';
                gpa = 1.0;
                xepLoai = "Yếu";
            }
            else
            {
                diemChu = 'F';
                gpa = 0.0;
                xepLoai = "Kém (Trượt)";
            }

            Console.WriteLine($"Điểm TB Thang 10: {scoreAvg:F2}");
            Console.WriteLine($"Điểm Chữ Quy đổi: {diemChu}");
            Console.WriteLine($"Điểm GPA Thang 4: {gpa:F1}");
            Console.WriteLine($"Xếp Loại Học Lực: {xepLoai}");
        }


        public static void  Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Bai_01();
            Bai_02();
            Bai_03();
            Bai_04();
            Bai_05();
        }
}