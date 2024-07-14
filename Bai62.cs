using System;
using System.Text.Json;

public static class JsonHelper
{
    public static Dictionary<string, object> ReadJsonFileToDictionary(string filePath)
    {
        // Cách 1: Sử dụng Newtonsoft.Json
        //string jsonString = File.ReadAllText(filePath);
        //return JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonString);

        // Cách 2: Sử dụng System.Text.Json
        string jsonString = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<Dictionary<string, object>>(jsonString);
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Chọn cách đọc file JSON:");
            Console.WriteLine("1. Sử dụng Newtonsoft.Json");
            Console.WriteLine("2. Sử dụng System.Text.Json");
            Console.WriteLine("3. Thoát");

            Console.Write("Nhập lựa chọn (1-3): ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 3)
            {
                Console.WriteLine("Đã thoát chương trình.");
                break;
            }

            Console.Write("Nhập đường dẫn file JSON: ");
            string filePath = Console.ReadLine();

            Dictionary<string, object> jsonData;
            if (choice == 1)
            {
                jsonData = ReadJsonFileToDictionary(filePath);
            }
            else
            {
                jsonData = ReadJsonFileToDictionary(filePath);
            }

            Console.WriteLine("Dữ liệu JSON đọc được:");
            foreach (var kvp in jsonData)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            Console.WriteLine();
        }
    }
}