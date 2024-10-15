using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IfStatementPractise : MonoBehaviour
{
    public float diemTB = 8.0f;
    public int soThuNhat = 5;
    public int soThuHai = 8;
    public int soThuBa = 6;
    public float soTienNguoiMua = 5;
    public float giaSanPham = 10;
    public int nam = 13;
    public int tuoi = 18;
    public float luongCoDinh = 500000;
    public float soGioLam = 20;
    public int age = 12;
    public bool MemberShip;
    public float soDien = 100;
    public int soNam = 3;
    public bool danhGia;
    public float donHang = 1000.000f;
    public float income = 2000;
    public int hang = 10; 
    public bool kho;
    public bool hasCompletedBasicCourse; 
    public float overallScore = 8; 
    public bool hasRecommendationLetter;

    private void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Kiểm tra số dương, âm, hoặc bằng 0
        //2
        int number = 7;
        BaiTap2(number); // Kiểm tra số chẵn hay lẻ
        BaiTap3(); // Kiểm tra điều kiện thi đ

        BaiTap4(); // Tìm số lớn nhất trong hai số
        BaiTap5(); // Kiểm tra điều kiện mua hàng
        BaiTap6(); // Kiểm tra năm nhuận
        BaiTap7(); // Tính giá vé xem phim
        BaiTap8(); // Kiểm tra học sinh xuất sắc
        BaiTap9(); // So sánh ba số
        BaiTap10(); // Tính tiền lương
        BaiTap11(); // Kiểm tra điều kiện vào câu lạc bộ
        BaiTap12();// Phân loại học sinh
        BaiTap13(); // Tính tiền điện
        BaiTap14(); // Kiểm tra điều kiện thăng chức
        BaiTap15(); // Kiểm tra điều kiện miễn phí vận chuyển
        BaiTap16(); // Tính thuế thu nhập cá nhân
        BaiTap17(); // Tính điểm trung bình của môn học
        BaiTap18(); // Kiểm tra điều kiện nhập hàng
        BaiTap19(); // Tìm số lớn hơn 10
        BaiTap20(); // Kiểm tra điều kiện đăng ký khóa học
    }

    // Bài Tập 1: Kiểm Tra Số Dương, Âm Hoặc Bằng 0
    void BaiTap1()
    {
        int number;
        Debug.Log("vui Nhập một số từ bàn phím");
        number = 0;
        if (number > 0) Debug.Log("so" + number + "số dương");
        else if (number < 0) Debug.Log("so" + number + "số âm");
        else Debug.Log("la so o");

    }

    // Bài Tập 2: Kiểm Tra Số Chẵn Hay Lẻ
    void BaiTap2(int number)
    {
        if (number % 2 == 0) Debug.Log(number + "so chan");
        else Debug.Log(number + "so le");
    }

    // Bài Tập 3: Kiểm Tra Điều Kiện Thi Đỗ
    void BaiTap3()
    {
        // Nhập điểm trung bình của học sinh từ bàn phím
        // Kiểm tra nếu điểm trung bình >= 5.0 thì học sinh đỗ, ngược lại thì trượt
        if (diemTB >= 5.0f)
        {
            Debug.Log("pass");
        }
        else
        {
            Debug.Log("truot");
        }
    }


    // Bài Tập 4: Tìm Số Lớn Nhất Trong Hai Số
    void BaiTap4()
    {
        int soLonNhat = (soThuNhat > soThuHai) ? soThuNhat : soThuHai;
        Debug.Log("Số lớn nhất giữa " + soThuNhat + " và " + soThuHai + " là: " + soLonNhat);
    }

    // Bài Tập 5: Kiểm Tra Điều Kiện Mua Hàng
    void BaiTap5()
    {
        if (soTienNguoiMua >= giaSanPham)
        {
            Debug.Log("Bạn có thể mua sản phẩm.");
        }
        else
        {
            Debug.Log("Bạn không đủ tiền để mua sản phẩm.");
        }
    }

    // Bài Tập 6: Kiểm Tra Năm Nhuận
    void BaiTap6()
    {
        if (IsNamNhuan(nam))
        {
            Debug.Log(nam + " là năm nhuận.");
        }
        else
        {
            Debug.Log(nam + " không phải là năm nhuận.");
        }
    } bool IsNamNhuan(int nam)
    {
        if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
        {
            return true;
        }
        return false;
    }

    // Bài Tập 7: Tính Giá Vé Xem Phim
    void BaiTap7()
    {
        int giaVe = TinhGiaVeTuoi(tuoi);
        Debug.Log("Giá vé xem phim cho người " + tuoi + " tuổi là: " + giaVe);
    }

    int TinhGiaVeTuoi(int tuoi)
    {
        if (tuoi < 18)
        {
            return 50000;
        }
        else
        {
            return 100000;
        }
    }

    // Bài Tập 8: Kiểm Tra Học Sinh Xuất Sắc
    void BaiTap8()
    {
        if (diemTB >= 9.0f)
        {
            Debug.Log("Học sinh đạt danh hiệu xuất sắc.");
        }
        else
        {
            Debug.Log("Học sinh không đạt danh hiệu xuất sắc.");
        }
    }

    // Bài Tập 9: So Sánh Ba Số
    void BaiTap9()
    {
        int soLonNhat = TimSoLonNhat(soThuNhat, soThuHai, soThuBa);

        Debug.Log("Số lớn nhất trong ba số " + soThuNhat + ", " + soThuHai + ", " + soThuBa + " là: " + soLonNhat);
    }
    int TimSoLonNhat(int a, int b, int c)
    {
        // Sử dụng Math.Max để tìm số lớn nhất
        return Mathf.Max(a, Mathf.Max(b, c));
    }

    // Bài Tập 10: Tính Tiền Lương
    void BaiTap10()
    {
        float tongTienLuong = TinhLuong(soGioLam);
        Debug.Log("Tổng tiền lương của nhân viên là: " + tongTienLuong + " đồng.");
    }
    float TinhLuong(float soGio)
    {
        if (soGio > 40)
        {
            float soGioLamThem = soGio - 40; // Số giờ làm thêm
            return luongCoDinh + (soGioLamThem * (luongCoDinh / 40)); // Lương cho giờ làm thêm gấp đôi
        }
        else
        {
            return luongCoDinh; // Chỉ tính mức lương cố định
        }
    }
    // Bài Tập 11: Kiểm Tra Điều Kiện Vào Câu Lạc Bộ
    void BaiTap11()
    {
        if (age > 18 && MemberShip)
        {
            Debug.Log("Bạn đủ điều kiện vào câu lạc bộ!");
        }
        else if (age <= 18)
        {
            Debug.Log("Bạn không đủ tuổi để vào câu lạc bộ.");
        }
        else if (!MemberShip)
        {
            Debug.Log("Bạn cần có thẻ thành viên để vào câu lạc bộ.");
        }
    }

    // Bài Tập 12: Phân Loại Học Sinh
    void BaiTap12()
    {
        if (diemTB >= 9.0f)
        {
            Debug.Log("Học sinh đạt loại Xuất sắc.");
        }
        else if (diemTB >= 8.0f)
        {
            Debug.Log("Học sinh đạt loại Giỏi.");
        }
        else if (diemTB >= 7.0f)
        {
            Debug.Log("Học sinh đạt loại Khá.");
        }
        else if (diemTB >= 5.0f)
        {
            Debug.Log("Học sinh đạt loại Trung bình.");
        }
        else
        {
            Debug.Log("Học sinh đạt loại Yếu.");
        }

    }

    // Bài Tập 13: Tính Tiền Điện
    void BaiTap13()
    {
        float bill = (soDien <= 100)
            ? soDien * 1500
            : (100 * 1500) + ((soDien - 100) * 2000);

        Debug.Log("Số tiền điện phải trả: " + bill + " đồng.");
    }

    // Bài Tập 14: Kiểm Tra Điều Kiện Thăng Chức
    void BaiTap14()
    {
        bool isEligibleForPromotion = CheckPromotionEligibility(soNam, danhGia);

        if (isEligibleForPromotion)
            Debug.Log("Nhân viên đủ điều kiện thăng chức.");
        else
            Debug.Log("Nhân viên không đủ điều kiện thăng chức.");
    }

    bool CheckPromotionEligibility(int years, bool goodEvaluation)
    {
        return years > 5 && goodEvaluation; // Kiểm tra điều kiện thăng chức
    } 


    // Bài Tập 15: Kiểm Tra Điều Kiện Miễn Phí Vận Chuyển
    void BaiTap15()
    {
        bool isFreeShipping = CheckFreeShipping(donHang);

        if (isFreeShipping)
            Debug.Log("Đơn hàng được miễn phí vận chuyển.");
        else
            Debug.Log("Đơn hàng không được miễn phí vận chuyển.");
    }

    bool CheckFreeShipping(float value)
    {
        return value >= 500000; 
    }

    // Bài Tập 16: Tính Thuế Thu Nhập Cá Nhân
    void BaiTap16()
    {
        float tax = CalculateIncomeTax(income);
        Debug.Log("Thuế thu nhập cá nhân phải trả: " + tax + " đồng.");
    }
    float CalculateIncomeTax(float income)
    {
        float taxRate;

        if (income <= 10000000) 
            taxRate = 0.05f; 
        else if (income <= 20000000) 
            taxRate = 0.10f; 
        else
            taxRate = 0.20f; 

        return income * taxRate; 
    }

    // Bài Tập 17: Tính Điểm Trung Bình Của Môn Học
    void BaiTap17()
    {
        float averageScore = CalculateAverageScore(soThuNhat, soThuHai, soThuBa);
        Debug.Log("Điểm trung bình: " + averageScore);

        if (averageScore >= 5.0f)
            Debug.Log("Học sinh đạt.");
        else
            Debug.Log("Học sinh không đạt.");

    }
    float CalculateAverageScore(float s1, float s2, float s3)
    {
        return (s1 + s2 + s3) / 3; 
    }

    // Bài Tập 18: Kiểm Tra Điều Kiện Nhập Hàng
    void BaiTap18()
    {
        bool canImportStock = CheckImportCondition(hang,kho);

        if (canImportStock)
            Debug.Log("Cửa hàng có thể nhập thêm hàng.");
        else
            Debug.Log("Cửa hàng không thể nhập thêm hàng.");
    }
    bool CheckImportCondition(int stock, bool space)
    {
        return stock < 100 && space; 
    }

    // Bài Tập 19: Tìm Số Lớn Hơn 10
    void BaiTap19()
    {
        // Nhập một số từ bàn phím
        // Kiểm tra xem số đó có lớn hơn 10 hay không
    }

    // Bài Tập 20: Kiểm Tra Điều Kiện Đăng Ký Khóa Học
    void BaiTap20()
    {
        bool isEligibleForAdvancedCourse = CheckEligibility(hasCompletedBasicCourse, overallScore, hasRecommendationLetter);

        if (isEligibleForAdvancedCourse)
            Debug.Log("Học sinh đủ điều kiện đăng ký khóa học nâng cao.");
        else
            Debug.Log("Học sinh không đủ điều kiện đăng ký khóa học nâng cao.");
    }
    bool CheckEligibility(bool completedBasic, float score, bool hasLetter)
    {
        // Kiểm tra các điều kiện
        return completedBasic && score >= 7.0f && hasLetter;
    }
}
