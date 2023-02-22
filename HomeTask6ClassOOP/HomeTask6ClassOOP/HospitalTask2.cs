using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask7ClassOOP
{
    public class Doctor
    {
        public virtual void Treatment()
        {
            //наследуемый метод лечения пациента
        } 
    }

    public class Surgeon : Doctor
    {
        public override void Treatment()
        {
            Console.WriteLine("Вас будет лечить хирург");
        }
    }
    public class Dentist : Doctor
    {
        public override void Treatment()
        {
            Console.WriteLine("Вас будет лечить стоматолог");
        }
    }
    public class Therapist : Doctor
    {
        public override void Treatment()
        {
            Console.WriteLine("Вам назначит лечение терапевт");
        }
    }

    public class Patient
    {
        public Plan PlanForPatient { get; set; }

        public Patient(int codeTreatment)
        {
            PlanForPatient = new Plan(codeTreatment);
        }

        public void SelectDoctor()
        {
            int codeTreatment = PlanForPatient.Code;

            switch (codeTreatment)
            {
                case 1:
                    var surgeon = new Surgeon();
                    surgeon.Treatment();
                    break;
                case 2:
                    var dentist = new Dentist();
                    dentist.Treatment();
                    break;
                default:
                    var therapist = new Therapist();
                    therapist.Treatment();
                    break;
            }
        }
    }
    public class Plan
    {
        public int Code { get; set; }

        public Plan(int codeTreatment)
        {
            Code = codeTreatment;
        }
    }





}

