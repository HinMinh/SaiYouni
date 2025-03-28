# Bài Tập Thực Hành: Vòng Lặp For

## Giới Thiệu

Vòng lặp **For** là một trong những cấu trúc lặp cơ bản và được sử dụng phổ biến nhất trong lập trình. Vòng lặp này giúp thực hiện một đoạn mã nhiều lần dựa trên điều kiện cho trước. Dưới đây là 20 bài tập giúp bạn rèn luyện kỹ năng sử dụng vòng lặp **For** trong nhiều tình huống khác nhau.

## 20 Bài Tập Thực Hành Về For

### Bài Tập 1: In Các Số Từ 1 Đến 100

Viết một chương trình sử dụng vòng lặp **For** để in các số từ 1 đến 100.
for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(i);
}

### Bài Tập 2: Tính Tổng Các Số Từ 1 Đến 50

Viết một chương trình sử dụng vòng lặp **For** để tính tổng các số từ 1 đến 50.
int sum = 0;
for (int i = 1; i <= 50; i++)
{
    sum += i;
}
Console.WriteLine("Tổng từ 1 đến 50 là: " + sum);

### Bài Tập 3: In Các Số Chẵn Từ 1 Đến 100

Viết một chương trình sử dụng vòng lặp **For** để in tất cả các số chẵn từ 1 đến 100.
for (int i = 2; i <= 100; i += 2)
{
    Console.WriteLine(i);
}

### Bài Tập 4: Tính Tích Các Số Từ 1 Đến 10

Viết một chương trình sử dụng vòng lặp **For** để tính tích của các số từ 1 đến 10.
long product = 1;
for (int i = 1; i <= 10; i++)
{
    product *= i;
}
Console.WriteLine("Tích từ 1 đến 10 là: " + product);

### Bài Tập 5: Tìm Số Lớn Nhất Trong Một Mảng

Viết một chương trình sử dụng vòng lặp **For** để tìm số lớn nhất trong một mảng số nguyên.
int[] arr = { 3, 7, 2, 9, 5, 12, 8 };
int max = arr[0];
for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] > max)
        max = arr[i];
}
Console.WriteLine("Số lớn nhất trong mảng là: " + max);

### Bài Tập 6: Tính Tổng Các Số Lẻ Từ 1 Đến 100

Viết một chương trình sử dụng vòng lặp **For** để tính tổng các số lẻ từ 1 đến 100.
int sumOdd = 0;
for (int i = 1; i <= 100; i += 2)
{
    sumOdd += i;
}
Console.WriteLine("Tổng các số lẻ từ 1 đến 100 là: " + sumOdd);

### Bài Tập 7: Đảo Ngược Chuỗi

Viết một chương trình sử dụng vòng lặp **For** để đảo ngược một chuỗi.
string str = "Hello World";
string reversed = "";
for (int i = str.Length - 1; i >= 0; i--)
{
    reversed += str[i];
}
Console.WriteLine("Chuỗi đảo ngược: " + reversed);

### Bài Tập 8: In Ra Bảng Cửu Chương

Viết một chương trình sử dụng vòng lặp **For** để in ra bảng cửu chương của một số bất kỳ (từ 1 đến 10).
int n = 5; // Số cần in bảng cửu chương
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{n} x {i} = {n * i}");
}

### Bài Tập 9: Đếm Các Số Nguyên Dương Trong Mảng

Viết một chương trình sử dụng vòng lặp **For** để đếm số lượng các số nguyên dương trong một mảng số nguyên.
int[] numbers = { -3, 5, -1, 8, 0, 4, 7 };
int countPositive = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
        countPositive++;
}
Console.WriteLine("Số lượng số nguyên dương trong mảng: " + countPositive);

### Bài Tập 10: In Tam Giác Số

Viết một chương trình sử dụng vòng lặp **For** để in ra một tam giác số như sau:
1
12
123
1234
12345
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(j);
    }
    Console.WriteLine();
}

### Bài Tập 11: Tìm Phần Tử Nhỏ Nhất Trong Mảng

Viết một chương trình sử dụng vòng lặp **For** để tìm phần tử nhỏ nhất trong một mảng số nguyên.
int[] array = { 4, 2, 9, 1, 5, 6 };
int min = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] < min)
        min = array[i];
}
Console.WriteLine("Phần tử nhỏ nhất trong mảng: " + min);

### Bài Tập 12: In Dãy Fibonacci

Viết một chương trình sử dụng vòng lặp **For** để in ra dãy Fibonacci từ 1 đến n (n là số nhập từ người dùng).
int num = 10; // Số lượng phần tử Fibonacci cần in
int a = 0, b = 1, temp;
Console.Write(a + " " + b + " ");
for (int i = 2; i < num; i++)
{
    temp = a + b;
    Console.Write(temp + " ");
    a = b;
    b = temp;
}

### Bài Tập 13: Tính Giai Thừa Của Một Số

Viết một chương trình sử dụng vòng lặp **For** để tính giai thừa của một số nguyên dương n.
int num = 5;
long factorial = 1;
for (int i = 1; i <= num; i++)
{
    factorial *= i;
}
Console.WriteLine($"Giai thừa của {num} là: {factorial}");

### Bài Tập 14: In Ra Các Số Nguyên Từ n Đến 1

Viết một chương trình sử dụng vòng lặp **For** để in ra các số nguyên từ n đến 1, với n là số nhập từ người dùng.
int n = 10;
for (int i = n; i >= 1; i--)
{
    Console.WriteLine(i);
}

### Bài Tập 15: Tính Tổng Các Phần Tử Trong Mảng

Viết một chương trình sử dụng vòng lặp **For** để tính tổng các phần tử trong một mảng số nguyên.
int[] arr = { 3, 5, 7, 2, 8 };
int total = 0;
for (int i = 0; i < arr.Length; i++)
{
    total += arr[i];
}
Console.WriteLine("Tổng các phần tử trong mảng: " + total);

### Bài Tập 16: Kiểm Tra Số Nguyên Tố

Viết một chương trình sử dụng vòng lặp **For** để kiểm tra xem một số nguyên có phải là số nguyên tố hay không.
int num = 17;
bool isPrime = true;
if (num < 2) isPrime = false;
for (int i = 2; i <= Math.Sqrt(num); i++)
{
    if (num % i == 0)
    {
        isPrime = false;
        break;
    }
}
Console.WriteLine($"{num} là số nguyên tố: {isPrime}");

### Bài Tập 17: In Ra Dãy Số Chia Hết Cho 3

Viết một chương trình sử dụng vòng lặp **For** để in ra các số từ 1 đến 100 chia hết cho 3.
for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0)
    {
        Console.WriteLine(i);
    }
}

### Bài Tập 18: Tìm Tổng Các Số Chẵn Trong Mảng

Viết một chương trình sử dụng vòng lặp **For** để tính tổng các phần tử chẵn trong một mảng số nguyên.
int[] numbers = { 3, 6, 8, 1, 4, 7 };
int evenSum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        evenSum += numbers[i];
    }
}
Console.WriteLine("Tổng các số chẵn trong mảng: " + evenSum);

### Bài Tập 19: Tính Trung Bình Cộng Của Mảng

Viết một chương trình sử dụng vòng lặp **For** để tính trung bình cộng của các phần tử trong một mảng số nguyên.
int[] arr = { 2, 4, 6, 8, 10 };
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    sum += arr[i];
}
double avg = (double)sum / arr.Length;
Console.WriteLine("Trung bình cộng của mảng: " + avg);

### Bài Tập 20: Đếm Số Ký Tự Hoa Trong Chuỗi

Viết một chương trình sử dụng vòng lặp **For** để đếm số lượng ký tự hoa trong một chuỗi.
string str = "Hello WORLD!";
int countUpper = 0;
for (int i = 0; i < str.Length; i++)
{
    if (char.IsUpper(str[i]))
    {
        countUpper++;
    }
}
Console.WriteLine("Số ký tự hoa trong chuỗi: " + countUpper);

## Kết Luận

Các bài tập trên giúp bạn rèn luyện kỹ năng sử dụng vòng lặp **For** để giải quyết các bài toán cơ bản và nâng cao trong lập trình. Thực hành nhiều sẽ giúp bạn hiểu sâu hơn về cấu trúc vòng lặp và cách áp dụng chúng vào các bài toán thực tế.
