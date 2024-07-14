using System;
using System.Collections.Generic;
using System.IO;

class Bai65
{
    static void Main(string[] args)
    {
        // Tạo một Dictionary<string, double>
        Dictionary<string, double> data = new Dictionary<string, double>
        {
            { "Đỗ Văn A", 123.456 },
            { "Lê Thị B", 789.012 },
            { "Nguyễn Văn C", 345.678 },
            { "Hoàng Thị D", 901.234 }
        };

        // Gọi hàm để ghi Dictionary ra file CSV
        WriteToCSV("output.csv", data);

        Console.WriteLine("Đã ghi file CSV thành công!");
    }

    static void WriteToCSV(string fileName, Dictionary<string, double> data)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                // Ghi header
                writer.WriteLine("Name,Value");

                // Duyệt qua từng cặp key-value trong Dictionary
                foreach (var kvp in data)
                {
                    // Ghi dữ liệu vào file, mỗi cặp key-value ngăn cách bởi dấu phẩy
                    writer.WriteLine($"{kvp.Key},{kvp.Value}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi khi ghi file CSV: {ex.Message}");
        }
    }
}