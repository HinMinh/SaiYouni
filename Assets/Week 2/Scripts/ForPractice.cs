using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForPractise : MonoBehaviour
{
    [Header("bai 12 :")]
    public int input12 = 10;
    [Header("bai 13 :")]
    public int input13 = 10;
    [Header("bai 14 :")]
    public int input14 = 10;
    [Header("bai 16 :")]
    public int input16 = 7;
    private void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // In tất cả các phần tử trong mảng
        BaiTap2(); // Tính tổng các phần tử trong mảng
        BaiTap3(); // Tìm phần tử lớn nhất trong mảng
        BaiTap4(); // Đếm số lượng số chẵn trong mảng
        BaiTap5(); // In tất cả các chuỗi trong danh sách
        BaiTap6(); // Tìm chuỗi dài nhất trong danh sách
        BaiTap7(); // Tính tổng các số lẻ trong mảng
        BaiTap8(); // In các số chẵn trong mảng
        BaiTap9(); // Kiểm tra sự tồn tại của một phần tử trong mảng
        BaiTap10(); // Đếm số phần tử âm trong mảng
        BaiTap11(); // In các số lớn hơn 10 trong mảng
        BaiTap12(input12); // Tìm chuỗi có độ dài ngắn nhất trong danh sách
        BaiTap13(input13); // Nhân đôi tất cả các phần tử trong mảng
        BaiTap14(input14); // Tìm số lớn thứ hai trong mảng
        BaiTap15(); // Tìm chuỗi bắt đầu bằng chữ cái A
        BaiTap16(input16); // Kiểm tra danh sách có chứa chuỗi "Hello" không
        BaiTap17(); // In tất cả các phần tử âm trong mảng
        BaiTap18(); // Đếm số lần xuất hiện của một phần tử trong mảng
        BaiTap19(); // Tạo danh sách mới từ các phần tử lớn hơn 10
        BaiTap20(); // In các chuỗi có độ dài lớn hơn 5 ký tự
    }

    // Bài Tập 1: In Tất Cả Các Phần Tử Trong Mảng
    void BaiTap1()
    {
        for (int i = 1; i <= 100; i++)
        {
            Debug.Log(i);
        }
    }

    // Bài Tập 2: Tính Tổng Các Phần Tử Trong Mảng
    void BaiTap2()
    {
        int sum = 0;
        for (int i = 1; i <= 5; i++)
        {
            sum += i;
        }
        Debug.Log("tong cac so tu 1 den 50 : " + sum);
    }

    // Bài Tập 3: Tìm Phần Tử Lớn Nhất Trong Mảng
    void BaiTap3()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0) Debug.Log(i);
        }
    }

    // Bài Tập 4: Đếm Số Lượng Số Chẵn Trong Mảng
    void BaiTap4()
    {
        int tich = 1;
        for (int i = 1; i <= 10; i++)
        {
            tich *= i;
        }
        Debug.Log("tich cac so tu 1 den 10 la : " + tich);
    }

    // Bài Tập 5: In Tất Cả Các Chuỗi Trong Danh Sách
    void BaiTap5()
    {
        int[] a = new int[7] { 5, 1, 2, 4, 6, 7, 3 };
        int max = a[0];
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] > max) max = a[i];
        }
        Debug.Log("so lon nhat trong mang : " + max);
    }

    // Bài Tập 6: Tìm Chuỗi Dài Nhất Trong Danh Sách
    void BaiTap6()
    {
        int tongLe = 0;
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 1) tongLe += i;
        }
        Debug.Log("tong cac so le tu 1 den 100 : " + tongLe);
    }

    // Bài Tập 7: Tính Tổng Các Số Lẻ Trong Mảng
    void BaiTap7()
    {
        string s = "Tung";
        char[] sArr = s.ToCharArray();
        for (int i = 0; i < s.Length / 2; i++)
        {
            char temp = s[i];
            sArr[i] = sArr[s.Length - 1 - i];
            sArr[s.Length - 1 - i] = temp;
        }
        s = new string(sArr);
        Debug.Log("chuoi dao nguoc la : " + s);
    }

    // Bài Tập 8: In Các Số Chẵn Trong Mảng
    void BaiTap8()
    {
        int n = UnityEngine.Random.Range(1, 11);
        for (int i = 1; i <= 10; i++)
        {
            Debug.Log(n + " * " + i + " = " + (n * i));
        }
    }

    // Bài Tập 9: Kiểm Tra Sự Tồn Tại Của Một Phần Tử Trong Mảng
    void BaiTap9()
    {
        int[] a = new int[7] { 5, 1, 2, 4, 6, 7, 3 };
        int dem = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] > 0) dem++;
        }
        Debug.Log("so so nguyend duong trong mang la : " + dem);
    }

    // Bài Tập 10: Đếm Số Phần Tử Âm Trong Mảng
    void BaiTap10()
    {
        for (int i = 1; i <= 5; i++)
        {
            string s = "";
            for (int j = 1; j <= i; j++)
            {
                s += j;
            }
            Debug.Log(s);
        }
    }

    // Bài Tập 11: In Các Số Lớn Hơn 10 Trong Mảng
    void BaiTap11()
    {
        int[] a = new int[7] { 5, 1, 2, 4, 6, 7, 3 };
        int min = a[0];
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] < min) min = a[i];
        }
        Debug.Log("phan tu nho nhat mang la : " + min);
    }

    // Bài Tập 12: Tìm Chuỗi Có Độ Dài Ngắn Nhất Trong Danh Sách
    void BaiTap12(int n)
    {
        int a = 0;
        int b = 1;
        for (int i = 0; i < n; i++)
        {
            Debug.Log(a);
            int next = a + b;
            a = b;
            b = next;
        }
    }

    // Bài Tập 13: Nhân Đôi Tất Cả Các Phần Tử Trong Mảng
    void BaiTap13(int n)
    {
        int giaiThua = 1;
        for (int i = 1; i <= n; i++)
        {
            giaiThua *= i;
        }
        Debug.Log("giai thua cua " + n + " la : " + giaiThua);

    }

    // Bài Tập 14: Tìm Số Lớn Thứ Hai Trong Mảng
    void BaiTap14(int n)
    {
        for (int i = n; i >= 1; i--)
        {
            Debug.Log(i);
        }
    }

    // Bài Tập 15: Tìm Chuỗi Bắt Đầu Bằng Chữ Cái A
    void BaiTap15()
    {
        int[] a = new int[6] { 1, 2, 12, 23, 44, 24 };
        int sum = 0;
        for (int i = 0; i < a.Length; i++)
        {
            sum += a[i];
        }
        Debug.Log("tong cac phan tu trong mang : " + sum);
    }

    // Bài Tập 16: Kiểm Tra Xem Danh Sách Có Chứa Một Chuỗi Cụ Thể Không
    void BaiTap16(int n)
    {
        bool check = true;
        if (n < 2)
        {
            check = false;
        }
        for (int i = 2; i < Mathf.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                check = false;
                break;
            }
        }
        if (check == true) Debug.Log(n + " la so nguyen to");
        else Debug.Log(n + " khong phai so nguyen to");
    }

    // Bài Tập 17: In Tất Cả Các Phần Tử Âm Trong Mảng
    void BaiTap17()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0) Debug.Log(i);
        }
    }

    // Bài Tập 18: Đếm Số Lần Xuất Hiện Của Một Phần Tử Trong Mảng
    void BaiTap18()
    {
        int[] a = new int[6] { 1, 2, 12, 23, 44, 24 };
        int tongChan = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] % 2 == 0) tongChan += a[i];
        }
        Debug.Log("tong cac phan tu chan : " + tongChan);
    }

    // Bài Tập 19: Tạo Một Danh Sách Mới Từ Các Phần Tử Lớn Hơn 10 Trong Mảng
    void BaiTap19()
    {
        int[] a = new int[7] { 5, 1, 2, 4, 6, 7, 3 };
        int sum = 0;
        for (int i = 0; i < a.Length; i++)
        {
            sum += a[i];
        }
        float TBC = (float)sum / a.Length;
        Debug.Log("trung binh cong : " + TBC);
    }

    // Bài Tập 20: In Các Chuỗi Có Độ Dài Lớn Hơn 5 Ký Tự
    void BaiTap20()
    {
        string s = "TranVanTung";
        int dem = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] >= 'A' && s[i] <= 'Z')
            {
                dem++;
            }
        }
        Debug.Log("so ki tu hoa la : " + dem);
    }
}
