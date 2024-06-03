using System;

class Max{
    static void Main(string[] args)
    {   
        int a,b,c;
        Console.WriteLine("Enter a,b,c:");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());
        int max = a;
        if(b > max)
        {
            max = b;
        }
        if(c > max)
        {
            max = c;
        }
        Console.WriteLine("Max value is {0}", max);
        Console.ReadLine();
    }
}