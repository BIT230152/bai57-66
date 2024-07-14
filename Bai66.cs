using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Bai66
{
    static void Main(string[] args)
    {
        // Gọi hàm đọc file CSV và lưu kết quả vào mảng 2 chiều
        double[][] data = ReadCSVToArray("data.csv");

        // In ra dữ liệu từ mảng 2 chiều
        foreach (var row in data)
        {
            Console.WriteLine(string.Join(", ", row));
        }
    }

    static double[][] ReadCSVToArray(string fileName)
    {
        List<double[]> rows = new List<double[]>();

        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                // Đọc dòng đầu tiên để kiểm tra xem có header hay không
                string headerLine = reader.ReadLine();
                bool hasHeader = !string.IsNullOrWhiteSpace(headerLine);

                // Đọc các dòng còn lại
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        // Tách dữ liệu trên mỗi dòng thành các số thực
                        double[] rowData = line.Split(',')
                            .Select(double.Parse)
                            .ToArray();

                        // Thêm dòng dữ liệu vào danh sách
                        rows.Add(rowData);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi khi đọc file CSV: {ex.Message}");
        }

        // Trả về mảng 2 chiều
        return rows.ToArray();
    }
}