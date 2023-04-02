using System.Xml.Linq;

namespace HW3
{
    public class Patient : IPerson
    {
        public bool AmISick { get; set; }
        public bool AmICured { get; set; }
        public string Diagnosis { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Patient(string name, int age, bool amISick, string diagnosis)
        {
            Name = name;
            Age = age;
            AmISick = amISick;
            Diagnosis = diagnosis;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Имя: {Name}, возрест: {Age}, болен: {AmISick}, а чем болен: {Diagnosis}.");
        }

        public void Complaint()
        {
            Console.WriteLine($"Доктор, у меня {Diagnosis}! Помогите, пожалуйста!");
        }


        public void SayThankYou ()
        {
            if (AmISick == false)
            {
                Console.WriteLine($"Господи боже, спасибо, не зря молился и свечки ставил!\n");
            }
            else
            {
                Console.WriteLine("Это все врач виноват :( \n");
            }

        }
    }
}
