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

        public Phone(int initNumber, string initModel, int initWeight) 
        {
            number = initNumber; 
            model = initModel; 
            weight = initWeight;
                
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
        
        public int GetNumber() 
        {
            return number;
        }
        
        
        
        
        
        //public Phone()   //конструктор без параметров 
        //{         
            

        //}










    }
}
