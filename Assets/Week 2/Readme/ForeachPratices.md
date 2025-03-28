# Bài Tập Thực Hành: Vòng Lặp Foreach

## Giới Thiệu

Vòng lặp **foreach** trong lập trình được sử dụng để duyệt qua các phần tử của một tập hợp (ví dụ như mảng, danh sách, hay tập hợp). Vòng lặp này giúp duyệt qua từng phần tử mà không cần biết đến chỉ số cụ thể, giúp mã dễ đọc và ngắn gọn hơn. Dưới đây là 20 bài tập giúp bạn rèn luyện kỹ năng sử dụng vòng lặp **foreach**.

## 20 Bài Tập Thực Hành Về Foreach

### Bài Tập 1: In Tất Cả Các Phần Tử Trong Mảng

Viết một chương trình sử dụng vòng lặp **foreach** để in tất cả các phần tử của một mảng số nguyên.
using System;

class Program {
    static void Main() {
        int[] numbers = {1, 2, 3, 4, 5};
        foreach (int num in numbers) {
            Console.Write(num + " ");
        }
    }
}

### Bài Tập 2: Tính Tổng Các Phần Tử Trong Mảng

Viết một chương trình sử dụng vòng lặp **foreach** để tính tổng tất cả các phần tử trong một mảng số nguyên.
using System;

class Program {
    static void Main() {
        int[] numbers = {1, 2, 3, 4, 5};
        int sum = 0;
        foreach (int num in numbers) {
            sum += num;
        }
        Console.WriteLine("Tổng: " + sum);
    }
}

### Bài Tập 3: Tìm Phần Tử Lớn Nhất Trong Mảng

Viết một chương trình sử dụng vòng lặp **foreach** để tìm phần tử lớn nhất trong một mảng số nguyên.
using System;

class Program {
    static void Main() {
        int[] numbers = {3, 7, 2, 8, 5};
        int max = numbers[0];
        foreach (int num in numbers) {
            if (num > max) max = num;
        }
        Console.WriteLine("Số lớn nhất: " + max);
    }
}

### Bài Tập 4: Đếm Số Lượng Số Chẵn Trong Mảng

Viết một chương trình sử dụng vòng lặp **foreach** để đếm số lượng các phần tử chẵn trong một mảng số nguyên.
using System;

class Program {
    static void Main() {
        int[] numbers = {2, 7, 6, 9, 10};
        int count = 0;
        foreach (int num in numbers) {
            if (num % 2 == 0) count++;
        }
        Console.WriteLine("Số lượng số chẵn: " + count);
    }
}

### Bài Tập 5: In Tất Cả Các Chuỗi Trong Danh Sách

Viết một chương trình sử dụng vòng lặp **foreach** để in tất cả các chuỗi trong một danh sách các chuỗi.
using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        List<string> names = new List<string> {"Alice", "Bob", "Charlie"};
        foreach (string name in names) {
            Console.WriteLine(name);
        }
    }
}

### Bài Tập 6: Tìm Chuỗi Dài Nhất Trong Danh Sách

Viết một chương trình sử dụng vòng lặp **foreach** để tìm chuỗi dài nhất trong một danh sách các chuỗi.
using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        List<string> words = new List<string> {"apple", "banana", "watermelon"};
        string longest = words[0];
        foreach (string word in words) {
            if (word.Length > longest.Length) longest = word;
        }
        Console.WriteLine("Chuỗi dài nhất: " + longest);
    }
}

### Bài Tập 7: Tính Tổng Các Số Lẻ Trong Mảng

Viết một chương trình sử dụng vòng lặp **foreach** để tính tổng tất cả các phần tử lẻ trong một mảng số nguyên.
using System;

class Program {
    static void Main() {
        int[] numbers = {1, 4, 7, 10, 15};
        int sum = 0;
        foreach (int num in numbers) {
            if (num % 2 != 0) sum += num;
        }
        Console.WriteLine("Tổng số lẻ: " + sum);
    }
}

### Bài Tập 8: In Các Số Chẵn Trong Mảng

Viết một chương trình sử dụng vòng lặp **foreach** để in tất cả các số chẵn trong một mảng số nguyên.
using System;

class Program {
    static void Main() {
        int[] numbers = {1, 2, 3, 4, 5, 6};
        foreach (int num in numbers) {
            if (num % 2 == 0) Console.Write(num + " ");
        }
    }
}

### Bài Tập 9: Kiểm Tra Sự Tồn Tại Của Một Phần Tử Trong Mảng

Viết một chương trình sử dụng vòng lặp **foreach** để kiểm tra xem một phần tử cụ thể có tồn tại trong một mảng số nguyên hay không.
using System;

class Program {
    static void Main() {
        int[] numbers = {5, 8, 12, 20};
        int search = 8;
        bool exists = false;
        foreach (int num in numbers) {
            if (num == search) {
                exists = true;
                break;
            }
        }
        Console.WriteLine("Tồn tại? " + exists);
    }
}

### Bài Tập 10: Đếm Số Phần Tử Âm Trong Mảng

Viết một chương trình sử dụng vòng lặp **foreach** để đếm số lượng các phần tử âm trong một mảng số nguyên.
using System;

class Program {
    static void Main() {
        int[] numbers = {-3, -1, 4, -2, 5};
        int count = 0;
        foreach (int num in numbers) {
            if (num < 0) count++;
        }
        Console.WriteLine("Số phần tử âm: " + count);
    }
}

### Bài Tập 11: In Các Số Lớn Hơn 10 Trong Mảng

Viết một chương trình sử dụng vòng lặp **foreach** để in tất cả các số lớn hơn 10 trong một mảng số nguyên.
using System;

class Program {
    static void Main() {
        int[] numbers = {5, 12, 8, 20, 3};
        foreach (int num in numbers) {
            if (num > 10) Console.Write(num + " ");
        }
    }
}

### Bài Tập 12: Tìm Chuỗi Có Độ Dài Ngắn Nhất Trong Danh Sách

Viết một chương trình sử dụng vòng lặp **foreach** để tìm chuỗi có độ dài ngắn nhất trong một danh sách các chuỗi.
using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        List<string> words = new List<string> {"apple", "hi", "cat"};
        string shortest = words[0];
        foreach (string word in words) {
            if (word.Length < shortest.Length) shortest = word;
        }
        Console.WriteLine("Chuỗi ngắn nhất: " + shortest);
    }
}

### Bài Tập 13: Nhân Đôi Tất Cả Các Phần Tử Trong Mảng

Viết một chương trình sử dụng vòng lặp **foreach** để nhân đôi giá trị của tất cả các phần tử trong một mảng số nguyên.
using System;

class Program {
    static void Main() {
        int[] numbers = {1, 2, 3, 4};
        foreach (int num in numbers) {
            Console.Write((num * 2) + " ");
        }
    }
}

### Bài Tập 14: Tìm Số Lớn Thứ Hai Trong Mảng

Viết một chương trình sử dụng vòng lặp **foreach** để tìm phần tử lớn thứ hai trong một mảng số nguyên.
using System;
using System.Linq;

class Program {
    static void Main() {
        int[] numbers = {3, 7, 2, 8, 5};
        int max = numbers.Max();
        int secondMax = numbers.Where(n => n != max).Max();
        Console.WriteLine("Số lớn thứ hai: " + secondMax);
    }
}

### Bài Tập 15: Tìm Chuỗi Bắt Đầu Bằng Chữ Cái A

Viết một chương trình sử dụng vòng lặp **foreach** để in ra tất cả các chuỗi bắt đầu bằng chữ cái 'A' trong một danh sách các chuỗi.
using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        List<string> words = new List<string> {"Apple", "Banana", "Avocado"};
        foreach (string word in words) {
            if (word.StartsWith("A")) Console.WriteLine(word);
        }
    }
}

### Bài Tập 16: Kiểm Tra Xem Danh Sách Có Chứa Một Chuỗi Cụ Thể Không

Viết một chương trình sử dụng vòng lặp **foreach** để kiểm tra xem một danh sách các chuỗi có chứa chuỗi "Hello" hay không.
using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        List<string> words = new List<string> {"Hi", "Hello", "World"};
        Console.WriteLine(words.Contains("Hello"));
    }
}

### Bài Tập 17: In Tất Cả Các Phần Tử Âm Trong Mảng

Viết một chương trình sử dụng vòng lặp **foreach** để in ra tất cả các phần tử âm trong một mảng số nguyên.
using System;

class Program {
    static void Main() {
        int[] numbers = {-5, 3, -1, 7, -9, 0};
        foreach (int num in numbers) {
            if (num < 0) {
                Console.Write(num + " ");
            }
        }
    }
}

Output: -5 -1 -9
### Bài Tập 18: Đếm Số Lần Xuất Hiện Của Một Phần Tử Trong Mảng

Viết một chương trình sử dụng vòng lặp **foreach** để đếm số lần xuất hiện của một phần tử cụ thể trong một mảng số nguyên.
using System;

class Program {
    static void Main() {
        int[] numbers = {1, 3, 5, 3, 7, 3, 9};
        int search = 3;
        int count = 0;
        foreach (int num in numbers) {
            if (num == search) {
                count++;
            }
        }
        Console.WriteLine($"Số {search} xuất hiện {count} lần.");
    }
}

Output: Số 3 xuất hiện 3 lần.
### Bài Tập 19: Tạo Một Danh Sách Mới Từ Các Phần Tử Lớn Hơn 10 Trong Mảng

Viết một chương trình sử dụng vòng lặp **foreach** để tạo một danh sách mới từ các phần tử có giá trị lớn hơn 10 trong một mảng số nguyên.
using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        int[] numbers = {5, 12, 8, 20, 3, 15};
        List<int> greaterThan10 = new List<int>();
        
        foreach (int num in numbers) {
            if (num > 10) {
                greaterThan10.Add(num);
            }
        }
        
        Console.WriteLine("Các số lớn hơn 10: " + string.Join(", ", greaterThan10));
    }
}

Output: Các số lớn hơn 10: 12, 20, 15
### Bài Tập 20: In Các Chuỗi Có Độ Dài Lớn Hơn 5 Ký Tự

Viết một chương trình sử dụng vòng lặp **foreach** để in ra tất cả các chuỗi có độ dài lớn hơn 5 ký tự trong một danh sách các chuỗi.
using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        List<string> words = new List<string> {"Hello", "World", "Programming", "C#", "OpenAI"};
        foreach (string word in words) {
            if (word.Length > 5) {
                Console.WriteLine(word);
            }
        }
    }
}

output:
Programming
OpenAI

## Kết Luận

Các bài tập này sẽ giúp bạn làm quen với việc sử dụng vòng lặp **foreach** để duyệt qua các phần tử trong các tập hợp khác nhau, từ mảng số nguyên đến danh sách các chuỗi. Việc thực hành sẽ giúp bạn hiểu rõ hơn về cú pháp và ứng dụng của vòng lặp **foreach** trong lập trình.
