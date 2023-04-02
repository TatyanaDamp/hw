/*Создайте классы врачей и пациентов. 
У каждого врача и пациента должны быть набор свойств и методов (минимум 3 свойства и 2 метода) 
У врача должен быть метод взаимодействия с пациентом. 
В классе Program продемонстрируйте взаимодействие моделей врачей и пациентов. Проявите креатив) 
При проектировании учитывайте принципы SOLID и DRY.  

Например: " У вас есть в вашей больнице 3 врача: терапевт, окулист и невролог, каждый из них имеет стаж, специализацию, имя, возраст и 
метод Cure, который принимает пациента и, например, меняет у пациента случайным образом статус на "Здоров" или "Болен". У пациента, соответственно,
в свойствах модели есть имя, возраст, адрес проживания и статус - здоров или болен". */

using HW3;

class Program
{
    public static void Main()
    {
        Doctor doc1 = new Doctor("Джон", 32, 7, "Гинеколог");
        Doctor doc2 = new Doctor("Эмма Уотсон", 45, 6, "Мед сестра");
        Doctor doc3 = new Doctor("Шакира", 27, 2, "Хирург");
        Doctor doc4 = new Doctor("Карлайл Каллен", 383, 300, "Хирург");

        Patient patient1 = new Patient("Райан Гослинг", 60, true, "Аппендицит");
        Patient patient2 = new Patient("Охлобыстин", 22, true, "Запор");
        Patient patient3 = new Patient("Джулия Робертс", 52, true, "Хламидиоз");
        Patient patient4 = new Patient("Студент СибГМУ", 19, false, "Воспаление хитрости");

        /*Вот тут я использую интерфейс!!!!!
        doc1.DisplayInfo(); 
        doc1.Cure(patient4);
        doc1.Cure(patient3);
        */
        List<Doctor> doctors = new List<Doctor>();
        doctors.Add(doc1);  
        doctors.Add(doc2);
        doctors.Add(doc3);
        doctors.Add(doc4);

        List<Patient> patients = new List<Patient>();
        patients.Add(patient4);
        patients.Add(patient1);
        patients.Add(patient2);
        patients.Add(patient3);


        foreach (Patient patient in patients)
        {
            if (patient.AmISick == false) 
            {
                Console.WriteLine($"Ах ты бездельник {patient.Name}, топай учиться!!!\n");
                continue;
            }
            patient.Complaint();

            foreach (Doctor doctor in doctors)
            {
                doctor.Cure(patient);
                if (patient.AmISick == false)
                {
                    patient.SayThankYou();
                    break;
                }
            }

        }

    }
}