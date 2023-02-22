using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask6ClassOOP
{
    public class Phone
    {
        int number;
        string model;
        int weight;

        string name;

        public Phone(int initNumber, string initModel, int initWeight) : this(initNumber, initModel)
        {
            weight = initWeight;
        }

        public Phone(int initNumber, string initModel) ////конструктор с двумя параметрами
        {
            number = initNumber;
            model = initModel;
        }

        public void Characteristics()
        {
            Console.WriteLine($"Номер телефона {number}, модель телефона {model}, вес телефона {weight}");
        }
        
        public void ReceiveCall(string initName)
        {
            name = initName; 
            Console.WriteLine($"\nCalling {name}");
        }

        public void ReceiveCall(string initName, int initNumber)
        {
            name = initName;
            number = initNumber;
            Console.WriteLine($"\nCalling +{number} {name}");
        }

        public int GetNumber() 
        {
            return number;
        }
        
        public void SendMessage(int initNumber)
        {
            number = initNumber;
            Console.WriteLine($"\nMessage from {number}");
        }
        

        
        //public Phone()   //конструктор без параметров 
        //{         
            

        //}










    }
}
