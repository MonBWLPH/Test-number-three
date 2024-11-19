using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        string[] arr = new string[100];
        arr[0] = "Orange";
        arr[1] = "Green";
        arr[2] = "Purple";
        arr[3] = "Green";
        arr[4] = "Black";
        arr[5] = "White";
        arr[6] = "White";
        arr[8] = "Yellow";
        arr[9] = "Red";
        arr[10] = "Orange";
        arr[11] = "Blue";
        arr[12] = "Pink";
        arr[13] = "Green";
        arr[14] = "Violet";
        arr[15] = "White";
        arr[16] = "Yellow";
        arr[17] = "Black";
        arr[18] = "Purple";
        arr[19] = "Magenta";
        arr[20] = "Red";
        arr[21] = "Pink";
        arr[22] = "Green";
        arr[23] = "Blue";
        arr[24] = "Black";
        arr[25] = "White";
        arr[26] = "Violet";
        arr[27] = "Yellow";
        arr[28] = "Green";
        arr[29] = "Orange";
        arr[30] = "Purple";
        arr[31] = "Blue";
        arr[32] = "Black";
        arr[33] = "Pink";
        arr[34] = "Magenta";
        arr[35] = "White";
        arr[36] = "Yellow";
        arr[37] = "Green";
        arr[38] = "Red";
        arr[39] = "Purple";
        arr[40] = "Blue";
        arr[41] = "White";
        arr[42] = "Black";
        arr[43] = "Green";
        arr[44] = "Pink";
        arr[45] = "Violet";
        arr[46] = "Yellow";
        arr[47] = "Orange";
        arr[48] = "Blue";
        arr[49] = "Green";
        arr[50] = "Magenta";
        arr[51] = "White";
        arr[52] = "Pink";
        arr[53] = "Black";
        arr[54] = "Red";
        arr[55] = "Yellow";
        arr[56] = "Violet";
        arr[57] = "Green";
        arr[58] = "Blue";
        arr[59] = "White";
        arr[60] = "Black";
        arr[61] = "Purple";
        arr[62] = "Pink";
        arr[63] = "Magenta";
        arr[64] = "Magenta";
        arr[65] = "Blue";
        arr[66] = "Yellow";
        arr[67] = "Magenta";
        arr[68] = "Black";
        arr[69] = "Blue";
        arr[70] = "Blue";
        arr[71] = "Pink";
        arr[72] = "Blue";
        arr[73] = "Red";
        arr[74] = "Blue";
        arr[75] = "White";
        arr[76] = "Blue";
        arr[77] = "Blue";
        arr[78] = "Blue";
        arr[79] = "PinBluek";
        arr[80] = "Blue";
        arr[81] = "Blue";
        arr[82] = "Green";
        arr[83] = "White";
        arr[84] = "Yellow";
        arr[85] = "Black";
        arr[86] = "Red";
        arr[87] = "Green";
        arr[88] = "Blue";
        arr[89] = "Pink";
        arr[90] = "White";
        arr[91] = "Violet";
        arr[92] = "Yellow";
        arr[93] = "Orange";
        arr[94] = "Magenta";
        arr[95] = "Magenta";
        arr[96] = "Blue";
        arr[97] = "Magenta";
        arr[98] = "Pink";
        arr[99] = "Blue";



        var result = ColorMax(arr);

        Console.WriteLine($"There are the most {result.Item1} , with {result.Item2} times.");
        Console.ReadLine();
    }

    public static Tuple<string, int> ColorMax(string[] arr)
    {
        //เก็บค่า
        Dictionary<string, int> colorCount = new Dictionary<string, int>();
        //เช็กจำนวนแต่ละสี
        foreach (var color in arr)
        {
            if (color != null)
            {   //ตรวจสอบว่ามีสีนี้หรือไม่ใน colorCount ถ้ามีให้บวกเข้าไปทีละ 1 ของสีนี้
                if (colorCount.ContainsKey(color))
                    colorCount[color]++;
                //ถ้ายังไม่มีสีนี้ใน colorCount ให้เพิ่มเป็นสีใหม่ใน colorCount กำหนดให้นับเป็นหนึ่ง
                else
                    colorCount[color] = 1;
            }
        }
        //สร้างตัวแปรชื่อสีและจำนวนที่พบบ่อยๆ
        string colorName = null;
        int colorNumber = 0;
        //หาสีที่มีจำนวนมากที่สุด
        foreach (var most in colorCount)
        {
            //หาจำนวนสีที่มากกว่า most และอัพเดต
            if (most.Value > colorNumber)
            {
                
                    colorName = most.Key;
                    colorNumber = most.Value;
                
            }
        }

        return new Tuple<string, int>(colorName, colorNumber);

    }

}
