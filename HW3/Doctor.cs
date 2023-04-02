namespace HW3
{
    public class Doctor : IPerson //Вот тут я использую интерфейс!!!!!
    {

        public int Experience { get; set; }
        public string Job { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Doctor(string name, int age, int experience, string job)
        {
            Name = name;
            Age = age;
            Experience = experience;
            Job = job;
        }


        public void DisplayInfo()
        {
            Console.WriteLine($"Имя: {Name}, возраст: {Age}, стаж: {Experience}, специализация: {Job}.");
        }



        public void Cure(Patient patient)
        {
            Console.WriteLine($"Привет, {patient.Name}. Я {Name}, я работаю здесь как {Job}.");

            if (patient.Diagnosis == "Аппендицит" && Job == "Хирург"
                || patient.Diagnosis == "Хламидиоз" && Job == "Гинеколог"
                || patient.Diagnosis == "Запор" && Job == "Мед сестра")
            {
                if (Experience > 5)
                {
                    Console.WriteLine($"У вас действительно {patient.Diagnosis}. Я могу вам помочь.");
                    patient.AmISick = false;
                    patient.Diagnosis = "";
                }
                else
                {
                    Console.WriteLine("У меня не хватает опыта, что бы вылечить тебя :(\n");
                }
            } 
            else { Console.WriteLine("И что ты ко мне пришел? Иди к другому врачу!\n"); }
        }
    }
}