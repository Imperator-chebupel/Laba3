using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Текстовый_квест_с_интерфейсом
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<NPC> npcs = new List<NPC>();
            List<Item> items = new List<Item>();

            Item_usefull Pen = new Item_usefull { X_ = 0, Y_ = 0, Name_ = "Ручка", Discription_ = "Самый важный инструмент после собственной головы", Index = "1" };
            Item_useless Pechenka = new Item_useless { X_ = 1, Y_ = 0, Name_ = "Печенье", Discription_ = "Выглядит вкусно", Index = "2" };
            Item_usefull Zapisi = new Item_usefull { X_ = 9, Y_ = 0, Name_ = "Записи", Discription_ = "То немногое, что Вадим успел записать за 2 лекции, на которых он был", Index = "1"};
            NPC Vadim = new NPC { X_ = 1, Y_ = 0, Name_ = "Вадим", item_ = Zapisi, Answer_ = 1, Advice_ = "Я забыл свой учебник на скамейке, принеси пожалуйста",Index_=0 };
            Item_useless Nosok = new Item_useless { X_ = 2, Y_ = 0, Name_ = "Носок", Discription_ = "Левый... Осталось найти правый", Index = "2" };
            Item_usefull Bilet = new Item_usefull { Name_ = "Студенческий билет", Discription_ = "Удостоверение студенческой личности", Index = "1" };
            NPC Zina = new NPC { X_ = 2, Y_ = 0, Name_ = "Зинаида", Answer_ = 4, item_ = Bilet, Advice_ = "Иногда студенческий билет важнее паспорта", Index_ = 1 };
            Item_usefull Ksiva = new Item_usefull { Name_ = "Ксива", Discription_ = "Какая-то важная бумажка. Не знаю, как она оказалась у кота", Index = "1" };
            NPC Cat = new NPC { X_ = 1, Y_ = 1, Name_ = "Кот", Answer_ = 3, item_ = Ksiva, Advice_ = "Мяу", Index_ = 2 };
            Item_useless Konfeta = new Item_useless { X_ = 0, Y_ = 1, Name_ = "Конфета", Discription_ = "Обычная конфета с пола", Index = "2" };
            Item_useless Pelmeni = new Item_useless { Name_ = "Пачка пельменей", Discription_ = "Продукт с непредсказуемой начинкой, лучше скушаю вечером", Index = "2" };
            NPC Kassir = new NPC { X_ = 0, Y_ = 1, Name_ = "Ашот", Answer_ = 2, item_ = Pelmeni, Advice_ = "Ты никуда не опаздываешь?", Index_ = 3 };
            Item_usefull Book = new Item_usefull { Name_ = "Учебник", Discription_ = "Что-то на умном и для умных - ещё не скоро смогу прочитать", X_ = 2, Y_ = 1, Index = "1" };
            Item_usefull Spisok = new Item_usefull { Name_ = "С.Ж.В.", Discription_ = "Список жёстких вопросов с экзамена, на них чаще всего валят студентов", Index = "1" };
            NPC Ohrannik = new NPC { X_ = 0, Y_ = 2, Name_ = "Охранник", Answer_ = 1, item_ = Spisok, Advice_ = "Ты ничего не забыл в своей комнате?", Index_ = 4 };
            Item_usefull Str = new Item_usefull { X_ = 1, Y_ = 2, Name_ = "Стиралка", Discription_ = "Нлавное - не продырявить листок во время стирания своих каракулей", Index = "1" };
            Item_timer Clock = new Item_timer { Name_ = "Странные часы", Discription_ = "Они идут в обратную сторону?!", X_ = 0, Y_ = 0, TIME_ = 15, Index = "3" };
            Item_timer Sand_clock = new Item_timer { Name_ = "Песочные часы", Discription_ = "Треснувшие песочные часы на 30 минут", X_ = 2, Y_ = 1, TIME_ = -30, Index = "3" };

            npcs.Add(Vadim);
            npcs.Add(Zina);
            npcs.Add(Cat);
            npcs.Add(Kassir);
            npcs.Add(Ohrannik);

            items.Add(Pen);
            items.Add(Pechenka);
            items.Add(Nosok);
            items.Add(Konfeta);
            items.Add(Book);
            items.Add(Str);
            items.Add(Clock);
            items.Add(Sand_clock);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(npcs, items));
            
        }





    }
}
