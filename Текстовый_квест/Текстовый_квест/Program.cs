using System;
using System.Collections;

namespace Текстовый_квест
{
    class Programm
    {
        static void Main(string[] args)
        {
            
            Player player = new Player();
            while (true) 
            {
                Console.WriteLine("Вы готовы начать? Тогда напишите 'Да'");
                string plot = Console.ReadLine();
                if (plot == "Да")
                    break;
                Console.WriteLine("Ясно, тогда попозже");
            }
            Console.Clear();
            Console.WriteLine("Времени осталось: " + player.Time_left_);
            Console.WriteLine("Вы просыпаетесь в своей комнате и понимаете, что сегодня экзамен, к которому Вы не готовы. Что делать?");
            Console.WriteLine("Для сдачи экзамена нужно собрать несколько предметов: канцелярию, пропуск в корпус и несколько конспектов по дисциплине. Ограничение по времени - 90 минут");
            

            
            /*
            Important_object A = new Important_object();
            A.Name_ = "Биба";
            A.Discription_ = "Боба";
            A.Read();*/

        }



    }
}
