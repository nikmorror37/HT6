using System.Text;

namespace HomeTask6ClassOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Phone phone = new Phone();
            Phone iphone = new Phone(1023345,"iPhone", 150);
            Phone samsung = new Phone(2034456,"Samsung", 160);
            Phone xiaomi = new Phone(3045567,"Xiaomi", 140);

            iphone.Characteristics(); //создал 3 экземпляра класса Phone
            samsung.Characteristics(); 
            xiaomi.Characteristics();

            //Console.Write("\nEnter the name: "); 
            //iphone.ReceiveCall(Console.ReadLine()); //вызов метода ReceiveCall

            Console.WriteLine("\nНомер iphone  " + iphone.GetNumber());
            Console.WriteLine("Номер samsung  " + samsung.GetNumber());
            Console.WriteLine("Номер xiaomi  " + xiaomi.GetNumber());






        }
    }
}