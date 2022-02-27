using System;

namespace _24._02._2022_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ad ve soyad daxil edin");
            string FullName = Console.ReadLine();
            Console.WriteLine("Qrup daxil edin");
            string GroupNo = Console.ReadLine();    
            Console.WriteLine("Yas daxil edin");
            int num = Convert.ToInt32(Console.ReadLine());
            Student student = new Student(FullName, GroupNo,num);

        }
    }
}
