# Bài Tập Thực Hành: Câu Lệnh If

## Giới Thiệu

Câu lệnh **if** là một trong những cấu trúc điều kiện quan trọng trong lập trình, cho phép thực hiện các khối lệnh khi điều kiện cho trước là đúng. Dưới đây là 20 bài tập giúp bạn luyện tập kỹ năng sử dụng câu lệnh **if** để kiểm tra điều kiện và xử lý các tình huống khác nhau.

## 20 Bài Tập Thực Hành Về If

### Bài Tập 1: Kiểm Tra Số Dương, Âm Hoặc Bằng 0

Viết chương trình kiểm tra xem một số nguyên nhập từ bàn phím là số **dương**, **âm**, hay **bằng 0**.
using System;

class Program
{
    static void Main()
    {
        // Bài 1: Kiểm tra số dương, âm hoặc bằng 0
        Console.Write("Nhập một số nguyên: ");
        int num = int.Parse(Console.ReadLine());

        if (num > 0)
            Console.WriteLine("Số dương");
        else if (num < 0)
            Console.WriteLine("Số âm");
        else
            Console.WriteLine("Số bằng 0");
    }
}
### Bài Tập 2: Kiểm Tra Số Chẵn Hay Lẻ

Viết chương trình kiểm tra xem một số nguyên nhập từ bàn phím là **chẵn** hay **lẻ**.
using System;

class Program
{
    static void Main()
    {
        // Bài 2: Kiểm tra số chẵn hay lẻ
        Console.Write("Nhập một số nguyên: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine(num2 % 2 == 0 ? "Số chẵn" : "Số lẻ");
    }
}
### Bài Tập 3: Kiểm Tra Điều Kiện Thi Đỗ

Viết chương trình kiểm tra xem một học sinh có đỗ kỳ thi không nếu **điểm trung bình >= 5.0**.
using System;

class Program
{
    static void Main()
    {
// Bài 3: Kiểm tra điều kiện thi đỗ
        Console.Write("Nhập điểm trung bình: ");
        double diemTB = double.Parse(Console.ReadLine());
        Console.WriteLine(diemTB >= 5.0 ? "Đỗ" : "Trượt");
    }
}
### Bài Tập 4: Tìm Số Lớn Nhất Trong Hai Số

Viết chương trình kiểm tra và in ra số lớn nhất trong hai số nguyên nhập từ bàn phím.
using System;

class Program
{
    static void Main()
    {
        // Bài 4: Tìm số lớn nhất trong hai số
        Console.Write("Nhập số thứ nhất: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhập số thứ hai: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"Số lớn nhất là: {Math.Max(a, b)}");
    }
}
### Bài Tập 5: Kiểm Tra Điều Kiện Mua Hàng

Viết chương trình kiểm tra xem một người có thể mua hàng không nếu **số tiền** của họ lớn hơn hoặc bằng **giá sản phẩm**.
using System;

class Program
{
    static void Main()
    {
        // Bài 5: Kiểm tra điều kiện mua hàng
        Console.Write("Nhập số tiền của bạn: ");
        double soTien = double.Parse(Console.ReadLine());
        Console.Write("Nhập giá sản phẩm: ");
        double giaSanPham = double.Parse(Console.ReadLine());
        Console.WriteLine(soTien >= giaSanPham ? "Có thể mua hàng" : "Không đủ tiền");
    }
}
### Bài Tập 6: Kiểm Tra Năm Nhuận

Viết chương trình kiểm tra xem một năm nhập từ bàn phím có phải là **năm nhuận** hay không (năm nhuận là năm chia hết cho 4 nhưng không chia hết cho 100, hoặc chia hết cho 400).
using System;

class Program
{
    static void Main()
    {
        // Bài 6: Kiểm tra năm nhuận
        Console.Write("Nhập năm: ");
        int year = int.Parse(Console.ReadLine());
        bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        Console.WriteLine(isLeapYear ? "Năm nhuận" : "Không phải năm nhuận");
    }
}
### Bài Tập 7: Tính Giá Vé Xem Phim

Viết chương trình tính giá vé xem phim với điều kiện:

- Nếu người mua **dưới 18 tuổi**, giá vé là 50,000 đồng.
- Nếu người mua **từ 18 tuổi trở lên**, giá vé là 100,000 đồng.
using System;

class Program
{
    static void Main()
    {
        // Bài 7: Tính giá vé xem phim
        Console.Write("Nhập tuổi của bạn: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine(age < 18 ? "Giá vé: 50,000đ" : "Giá vé: 100,000đ");
    }
}
### Bài Tập 8: Kiểm Tra Học Sinh Xuất Sắc

Viết chương trình kiểm tra xem một học sinh có đạt danh hiệu **học sinh xuất sắc** không nếu điểm trung bình của họ lớn hơn hoặc bằng 9.0.
using System;

class Program
{
    static void Main()
    {
        // Bài 8: Kiểm tra học sinh xuất sắc
        Console.Write("Nhập điểm trung bình: ");
        double avg = double.Parse(Console.ReadLine());
        Console.WriteLine(avg >= 9.0 ? "Học sinh xuất sắc" : "Không đạt danh hiệu xuất sắc");
    }
}
### Bài Tập 9: So Sánh Ba Số

Viết chương trình kiểm tra và in ra số lớn nhất trong ba số nguyên nhập từ bàn phím.
using System;

class Program
{
    static void Main()
    {
        // Bài 9: So sánh ba số
        Console.Write("Nhập số thứ nhất: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Nhập số thứ hai: ");
        int y = int.Parse(Console.ReadLine());
        Console.Write("Nhập số thứ ba: ");
        int z = int.Parse(Console.ReadLine());
        Console.WriteLine($"Số lớn nhất là: {Math.Max(x, Math.Max(y, z))}");
    }
}
### Bài Tập 10: Tính Tiền Lương

Viết chương trình tính tiền lương của nhân viên theo công thức:

- Nếu nhân viên làm **trên 40 giờ**, lương được tính là **40 giờ đầu** với mức lương cố định và **số giờ làm thêm** được tính với mức **lương gấp đôi**.
- Nếu làm **dưới hoặc bằng 40 giờ**, lương chỉ được tính với mức lương cố định.
using System;

class Program
{
    static void Main()
    {
        // Bài 10: Tính tiền lương
        Console.Write("Nhập số giờ làm việc: ");
        int hoursWorked = int.Parse(Console.ReadLine());
        Console.Write("Nhập lương mỗi giờ: ");
        double wagePerHour = double.Parse(Console.ReadLine());
        double salary = hoursWorked > 40 ? (40 * wagePerHour) + ((hoursWorked - 40) * wagePerHour * 2) : (hoursWorked * wagePerHour);
        Console.WriteLine($"Tiền lương: {salary}");
    }
}
### Bài Tập 11: Kiểm Tra Điều Kiện Vào Câu Lạc Bộ

Viết chương trình kiểm tra xem một người có thể vào câu lạc bộ không nếu họ **trên 18 tuổi** và có **thẻ thành viên**.
using System;

class Program
{
    static void Main()
    {
        // Bài 11: Kiểm tra điều kiện vào câu lạc bộ
        Console.Write("Nhập tuổi: ");
        int tuoi = int.Parse(Console.ReadLine());
        Console.Write("Có thẻ thành viên không? (yes/no): ");
        string hasCard = Console.ReadLine();
        Console.WriteLine((tuoi > 18 && hasCard.ToLower() == "yes") ? "Được vào CLB" : "Không được vào CLB");
    }
}
### Bài Tập 12: Phân Loại Học Sinh

Viết chương trình phân loại học sinh dựa trên điểm trung bình:

- **Xuất sắc** nếu điểm trung bình >= 9.0
- **Giỏi** nếu điểm trung bình >= 8.0
- **Khá** nếu điểm trung bình >= 7.0
- **Trung bình** nếu điểm trung bình >= 5.0
- **Yếu** nếu điểm trung bình < 5.0

using System;

class Program
{
    static void Main()
    {
        // Bài 12: Phân loại học sinh
        Console.Write("Nhập điểm trung bình: ");
        double dtb = double.Parse(Console.ReadLine());
        if (dtb >= 9.0) Console.WriteLine("Xuất sắc");
        else if (dtb >= 8.0) Console.WriteLine("Giỏi");
        else if (dtb >= 7.0) Console.WriteLine("Khá");
        else if (dtb >= 5.0) Console.WriteLine("Trung bình");
        else Console.WriteLine("Yếu");
    }
}
### Bài Tập 13: Tính Tiền Điện

Viết chương trình tính tiền điện theo công thức:

- Nếu số điện <= 100 kWh, giá điện là 1,500 đồng/kWh.
- Nếu số điện > 100 kWh, giá điện là 2,000 đồng/kWh cho phần vượt quá 100 kWh.

using System;

class Program
{
    static void Main()
    {
        // Bài 13: Tính tiền điện
        Console.Write("Nhập số điện tiêu thụ: ");
        int kwh = int.Parse(Console.ReadLine());
        double bill = kwh <= 100 ? kwh * 1500 : (100 * 1500) + ((kwh - 100) * 2000);
        Console.WriteLine($"Tiền điện: {bill} đồng");
    }
}
### Bài Tập 14: Kiểm Tra Điều Kiện Thăng Chức

Viết chương trình kiểm tra xem một nhân viên có đủ điều kiện thăng chức không nếu họ đã làm việc **trên 5 năm** và có **đánh giá công việc tốt**.
using System;

class Program
{
    static void Main()
    {
        // Bài 14: Kiểm tra điều kiện thăng chức
        Console.Write("Nhập số năm làm việc: ");
        int yearsWorked = int.Parse(Console.ReadLine());
        Console.Write("Có đánh giá tốt không? (yes/no): ");
        string review = Console.ReadLine();
        Console.WriteLine((yearsWorked > 5 && review.ToLower() == "yes") ? "Đủ điều kiện thăng chức" : "Chưa đủ điều kiện");
    }
}
### Bài Tập 15: Kiểm Tra Điều Kiện Miễn Phí Vận Chuyển

Viết chương trình kiểm tra xem một đơn hàng có được miễn phí vận chuyển không nếu giá trị đơn hàng lớn hơn hoặc bằng 500,000 đồng.
using System;

class Program
{
    static void Main()
    {
        // Bài 15: Kiểm tra điều kiện miễn phí vận chuyển
        Console.Write("Nhập giá trị đơn hàng: ");
        double orderValue = double.Parse(Console.ReadLine());
        Console.WriteLine(orderValue >= 500000 ? "Được miễn phí vận chuyển" : "Không được miễn phí");
    }
}
### Bài Tập 16: Tính Thuế Thu Nhập Cá Nhân

Viết chương trình tính thuế thu nhập cá nhân theo công thức:

- Nếu thu nhập <= 10 triệu đồng, thuế suất là 5%.
- Nếu thu nhập > 10 triệu đồng và <= 20 triệu đồng, thuế suất là 10%.
- Nếu thu nhập > 20 triệu đồng, thuế suất là 20%.

using System;

class Program
{
    static void Main()
    {
        // Bài 16: Tính thuế thu nhập cá nhân
        Console.Write("Nhập thu nhập: ");
        double income = double.Parse(Console.ReadLine());

        double tax = income <= 10000000 ? income * 0.05 : income <= 20000000 ? income * 0.10 : income * 0.20;
        Console.WriteLine($"Thuế thu nhập: {tax}");
    }
}
### Bài Tập 17: Tính Điểm Trung Bình Của Môn Học

Viết chương trình tính điểm trung bình của 3 bài kiểm tra và kiểm tra xem học sinh có đạt không (điểm >= 5.0).
using System;

class Program
{
    static void Main()
    {
        // Bài 17: Tính điểm trung bình
        Console.Write("Nhập điểm bài kiểm tra 1: ");
        double test1 = double.Parse(Console.ReadLine());
        Console.Write("Nhập điểm bài kiểm tra 2: ");
        double test2 = double.Parse(Console.ReadLine());
        Console.Write("Nhập điểm bài kiểm tra 3: ");
        double test3 = double.Parse(Console.ReadLine());
        double avgScore = (test1 + test2 + test3) / 3;
        Console.WriteLine(avgScore >= 5.0 ? "Đạt" : "Không đạt");
    }
}
### Bài Tập 18: Kiểm Tra Điều Kiện Nhập Hàng

Viết chương trình kiểm tra xem một cửa hàng có thể nhập thêm hàng hay không nếu **số lượng hàng hiện tại < 100** và **hàng trong kho còn đủ chỗ**.
using System;

class Program
{
    static void Main()
    {
        // Bài 18: Kiểm tra điều kiện nhập hàng
        Console.Write("Nhập số lượng hàng hiện tại: ");
        int stock = int.Parse(Console.ReadLine());
        Console.Write("Kho còn đủ chỗ không? (yes/no): ");
        string hasSpace = Console.ReadLine();
        Console.WriteLine((stock < 100 && hasSpace.ToLower() == "yes") ? "Có thể nhập hàng" : "Không thể nhập hàng");
    }
}
### Bài Tập 19: Tìm Số Lớn Hơn 10

Viết chương trình kiểm tra xem một số nguyên nhập từ bàn phím có lớn hơn 10 hay không.
using System;

class Program
{
    static void Main()
    {
        // Bài 19: Tìm số lớn hơn 10
        Console.Write("Nhập một số: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(number > 10 ? "Lớn hơn 10" : "Không lớn hơn 10");
    }
}
### Bài Tập 20: Kiểm Tra Điều Kiện Đăng Ký Khóa Học

Viết chương trình kiểm tra xem một học sinh có đủ điều kiện đăng ký khóa học nâng cao không nếu họ đã hoàn thành **khóa học cơ bản**, **điểm tổng kết >= 7.0**, và có **thư giới thiệu từ giáo viên**.
using System;

class Program
{
    static void Main()
    {
       // Bài 20: Kiểm tra điều kiện đăng ký khóa học
        Console.Write("Hoàn thành khóa học cơ bản chưa? (yes/no): ");
        string completedBasic = Console.ReadLine();
        Console.Write("Điểm tổng kết: ");
        double finalGrade = double.Parse(Console.ReadLine());
        Console.Write("Có thư giới thiệu không? (yes/no): ");
        string hasLetter = Console.ReadLine();

        Console.WriteLine((completedBasic.ToLower() == "yes" && finalGrade >= 7.0 && hasLetter.ToLower() == "yes") ? "Đủ điều kiện" : "Không đủ điều kiện");
    }
}
## Kết Luận

Các bài tập trên sẽ giúp bạn làm quen với câu lệnh **if** trong lập trình, từ những bài tập cơ bản đến các tình huống điều kiện phức tạp hơn. Việc thực hành nhiều bài tập này sẽ giúp bạn hiểu rõ hơn cách sử dụng câu lệnh điều kiện trong các ứng dụng thực tế.
