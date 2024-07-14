using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Text.Json;
using System.Xml;

public static class JsonHelper
{
    public static bool WriteJsonFileFromDictionary_Newtonsoft(string filePath, Dictionary<string, object> data)
    {
        try
        {
            string jsonString = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(filePath, jsonString);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public static bool WriteJsonFileFromDictionary_SystemTextJson(string filePath, Dictionary<string, object> data)
    {
        try
        {
            string jsonString = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, jsonString);
            return true;
        }
        catch
        {
            return false;
        }
    }
}

class Bai63
{
    static void Main(string[] args)
    {
        Dictionary<string, object> data = new Dictionary<string, object>
        {
            { "name", "John Doe" },
            { "age", 35 },
            { "email", "john.doe@example.com" }
        };

        while (true)
        {
            Console.WriteLine("Chọn phương thức ghi file JSON:");
            Console.WriteLine("1. Sử dụng Newtonsoft.Json");
            Console.WriteLine("2. Sử dụng System.Text.Json");
            Console.WriteLine("3. Thoát");

            Console.Write("Nhập lựa chọn (1-3): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    bool success1 = JsonHelper.WriteJsonFileFromDictionary_Newtonsoft("output1.json", data);
                    Console.WriteLine($"Ghi file output1.json thành công: {success1}");
                    break;
                case "2":
                    bool success2 = JsonHelper.WriteJsonFileFromDictionary_SystemTextJson("output2.json", data);
                    Console.WriteLine($"Ghi file output2.json thành công: {success2}");
                    break;
                case "3":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }

            Console.WriteLine();
        }
    }
}