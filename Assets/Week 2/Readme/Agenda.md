# Agenda Phát Triển Game Week 2

## 1. Kể Tên 3 Hàm Màu Xanh (Blue) Mà Unity Sẽ Tự Động Gọi
- Start()
- Update()
- FixedUpdate()
## 2. Kể Tên 5 Loại Giải Thuật Sắp Xếp Khác Nhau
- Bubble Sort
- Selection Sort
- Insertion Sort
- Merge Sort
- Quick Sort
## 3. Dùng Một Giải Thuật Sắp Xếp Khác Để Thay Cho Giải Thuật Trong Buổi Học
- Selection Sort
## 4. Thực Hiện Random Cho Current HP

- Sử dụng code để thực hiện random cho giá trị **Current HP** của nhân vật hoặc đối tượng trong game.
 int currentHP = Random.Range(50, 101); // HP ngẫu nhiên từ 50 đến 100

## 5. Tìm Enemy Có Current HP Nhỏ Nhất

- Viết code tìm đối tượng enemy có **Current HP** nhỏ nhất trong danh sách enemy.
Enemy FindWeakestEnemy(List<Enemy> enemies)
{
    return enemies.OrderBy(e => e.CurrentHP).FirstOrDefault();
}

## 6. Tìm Enemy Có Current HP Lớn Nhất

- Viết code tìm đối tượng enemy có **Current HP** lớn nhất trong danh sách enemy.
Enemy FindStrongestEnemy(List<Enemy> enemies)
{
    return enemies.OrderByDescending(e => e.CurrentHP).FirstOrDefault();
}

## 7. Bài Tập Về If Để Thực Hành

- Đọc IFStatementPractices.md

## 8. Bài Tập Về Foreach Để Thực Hành

- Đọc ForeachPractices.md

## 9. Bài Tập Về For Để Thực Hành

- Đọc ForPractices.md
