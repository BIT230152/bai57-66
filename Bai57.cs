using System;
using Newtonsoft.Json;

public class CircleInfo
{
    public double dien_tich { get; set; }
    public double chu_vi { get; set; }
    public double duong_kinh { get; set; }
}

public class Bai57
{
    public static string CalculateCircleInfo(double r)
    {
        if (r <= 0)
            throw new ArgumentException("Bán kính phải lớn hơn 0.");

        double dien_tich = Math.PI * r * r;
        double chu_vi = 2 * Math.PI * r;
        double duong_kinh = 2 * r;

        var circleInfo = new CircleInfo
        {
            dien_tich = dien_tich,
            chu_vi = chu_vi,
            duong_kinh = duong_kinh
        };

        return JsonConvert.SerializeObject(circleInfo);
    }

    public static void Main(string[] args)
    {
        double r;
        while (true)
        {
            Console.Write("Nhập bán kính r (>0): ");
            if (double.TryParse(Console.ReadLine(), out r) && r > 0)
            {
                break;
            }
            Console.WriteLine("Giá trị bán kính không hợp lệ. Vui lòng nhập lại.");
        }

        try
        {
            string jsonResult = CalculateCircleInfo(r);
            Console.WriteLine(jsonResult);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}