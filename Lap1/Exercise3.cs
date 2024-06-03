using System;

class ReferenceType{
    public int valueVal;
}

class TestReference{
    public static void Main(string[] args)
    {
        ReferenceType refer = new ReferenceType();
        refer.valueVal = 5;
        Test(refer);
        Console.WriteLine(refer.valueVal);
        Console.ReadLine();
        static void Test(ReferenceType refer){
            int temp = 5;
            refer.valueVal = temp * 2;
        }
    }
}
  
