/*Реализовать 3 класса:
Первый класс (Counter) будет считать до 100 используя цикл. При достижении некоторого 
числа (например 77) класс должен сгенерировать событие.
Два других класса (Handler1 и Handler2) будут ждать события, после чего они должны вывести
на консоль фразы в любой последовательности: «Пора действовать, ведь уже 77», «Уже 77, 
давно пора было начать!».
Использование event обязательна

#дз_задание*/


//делегат
public delegate void Message(int n);
public class Programm
{
    //событие
    public static event Message Its77already;
    public static event Message Handler1;
    public static event Message Handler2;

    public static void Main()
    {
        //регистрируем метод в событии
        Its77already += Message1;
        Handler1 += Message2;
        Handler1 += Message3;
        //вызываем событие
        Its77already(77);
        Handler1(77);
        Handler2(77);

    }

    private static void Message1(int n)
    {
        for (int i = 0; i < 101; i++)
        {
            if (i == 77)
            {
                Console.WriteLine(i);
            }
        }
    }

    private static void Message2(int n)
    {
        Console.WriteLine("Пора действовать, ведь уже 77");
    }

    private static void Message3(int n)
    {
        Console.WriteLine("Yже 77, давно пора было начать!");
    }

}