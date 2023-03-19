//Сделать простое консольное приложение, которое находит второй наибольший элемент в массиве целых чисел (int).
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Укажите размер массива в виде числа. Количество элементов в массиве должно быть больше или равно двум.");
        int sizeOfMassive = 0;
        while (sizeOfMassive < 2)
        {
            sizeOfMassive = ReadInt();
            if (sizeOfMassive < 2) //тк второго наименьшего не существует в одноэлементном массиве!!!
                Console.WriteLine("Введите число >=2");
        }

        Console.WriteLine("Отлично, теперь введите все элементы массива");

        int[] massive = new int[sizeOfMassive];

        for (int i  = 0; i < massive.Length; i++)
        { massive[i] = ReadInt();}

        //поиск второго наибольшего элемента массива
        int max1 = -2147483648;
        int max2 = 0;
        for (int i = 0; i < massive.Length; i++)
        {
            if (massive[i] > max1)
            {
                max2 = max1;
                max1 = massive[i];
            }

        }

        Console.WriteLine($"Второе наибольшее значение вашего массива {max2}");
    }

    //Мне помог очень хороший человек, тут можно сделать так, как я и хотела: чтобы пользователь пи вводе некорректного значения вводил его снова, а не вылезало исключение. И без потери количества элементов, где они преобразуются в 0, как описано у меня выше. А Юрий отлично игнорит)
    public static int ReadInt()
    {
        int num = 0;
        bool isformatright = false;

        while(!isformatright)
        {
            try
            {
                num = Int32.Parse(Console.ReadLine());
                isformatright = true;
            }
            catch (Exception)
            {
                Console.WriteLine("Введите число");
                continue;
            }
        }
        return num;
    }
}