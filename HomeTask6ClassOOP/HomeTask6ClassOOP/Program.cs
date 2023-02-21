using HomeTask7ClassOOP;
using System.Text;

namespace HomeTask6ClassOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // HomeTask after LESSON6-7

            //Phone phone = new Phone();
            Phone iphone = new Phone(1023345,"iPhone", 150);
            Phone samsung = new Phone(2034456,"Samsung", 160);
            Phone xiaomi = new Phone(3045567,"Xiaomi", 140);

            Phone lg = new Phone(123456789, "LG");

            iphone.Characteristics(); //создал 3 экземпляра класса Phone
            samsung.Characteristics(); 
            xiaomi.Characteristics();

            lg.Characteristics();

            lg.SendMessage(555000555);

            //Console.Write("\nEnter the name: "); 
            iphone.ReceiveCall("Katya"); //вызов метода ReceiveCall
            xiaomi.ReceiveCall("Alex", 375295575);
            Console.WriteLine("\nНомер iphone  " + iphone.GetNumber());
            Console.WriteLine("Номер samsung  " + samsung.GetNumber());
            Console.WriteLine("Номер xiaomi  " + xiaomi.GetNumber());

            Console.WriteLine("Номер lg  " + lg.GetNumber());

            Console.WriteLine("\n------------------------------------------------------------------\n");


            //CreditCard HomeTask after LESSON7

            CreditCard mastercard = new CreditCard(345678, 1000);
            CreditCard visa = new CreditCard(123321, 2500);
            CreditCard unionpay = new CreditCard(987654, 5000);

            mastercard.Sum1();
            visa.Sum1();
            unionpay.Difference1();

            mastercard.CurrentInfo1();
            visa.CurrentInfo1();
            unionpay.CurrentInfo1();
        }
    }
}