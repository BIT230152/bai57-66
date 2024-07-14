using System;
using System.IO;

class Bai64
{
    static void Main(string[] args)
    {
        // Tạo mảng 2 chiều các số thực 4 byte
        float[,] data = {
            { 1.23f, 4.56f, 7.89f },
            { 2.34f, 5.67f, 8.90f },
            { 3.45f, 6.78f, 9.01f }
        };

        // Gọi hàm để ghi mảng ra file CSV
        WriteToCSV("output.csv", data);

        Console.WriteLine("Đã ghi file CSV thành công!");
    }

    static void WriteToCSV(string fileName, float[,] data)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                // Duyệt qua từng dòng của mảng
                for (int i = 0; i < data.GetLength(0); i++)
                {
                    // Tạo một chuỗi chứa các giá trị trong dòng, ngăn cách bởi dấu phẩy
                    string line = string.Join(",", data[i, 0], data[i, 1], data[i, 2]);
                    writer.WriteLine(line);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi khi ghi file CSV: {ex.Message}");
        }
    }
}