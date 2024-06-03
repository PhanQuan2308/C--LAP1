using System;

class Student{
    static void Main(string[] args){
        string name, address, phone;

        Console.Write("Enter your name: ");
        name = Console.ReadLine();

        Console.Write("Enter your address: ");
        address = Console.ReadLine();

        Console.Write("Enter your phone number: ");
        phone = Console.ReadLine();

        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Address: {0}", address);
        Console.WriteLine("Phone number: {0}", phone);

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey(true);  
    }
}    