using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask7ClassOOP
{
    public class CreditCard
    {
        public int cardNumber { get; set; }
        public int cardBalance { get; set; }

        public CreditCard(int initCardNumber, int initCardBalance) 
        {
            cardNumber = initCardNumber;
            cardBalance = initCardBalance;
        }

        public void Sum1()
        {
            Console.Write($"Введите сумму пополнения счета карты {cardNumber} : ");
            cardBalance += Convert.ToInt32(Console.ReadLine());
        }

        public void Difference1()
        {
            Console.Write($"Введите сумму снятия со счета карты {cardNumber} : ");
            cardBalance -= Convert.ToInt32(Console.ReadLine());
        }

        public void CurrentInfo1() 
        {
            Console.WriteLine("\n------------------------------------------------------");
            Console.WriteLine($"На текущем номере счета {cardNumber} баланс составляет {cardBalance}");
        }


    }
}
