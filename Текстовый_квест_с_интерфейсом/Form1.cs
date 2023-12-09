using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Текстовый_квест_с_интерфейсом
{
    public partial class Form1 : Form
    {
        Player player = new Player {X_ =0, Y_ = 0 };
        Stuff Locations = new Stuff();
        public Form1()
        {
            InitializeComponent();
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            pictureBox2.Visible = false;
            Item_usefull Pen = new Item_usefull { X_ = 0, Y_ = 0, Name_ = "Ручка", Discription_ = "Самый важный инструмент после собственной головы" };
            Item_useless Pechenka = new Item_useless { X_ = 1, Y_ = 0, Name_ = "Печенье", Discription_ = "Выглядит вкусно" };
            Item_usefull Zapisi = new Item_usefull { X_ =9, Y_=0,Name_ = "Записи", Discription_ = "То немногое, что Вадим успел записать за 2 лекции, на которых он был" };
            NPC Vadim = new NPC {X_ =1, Y_ = 0, Name_ = "Вадим", item_ = Zapisi, Answer_ = 1, Advice_ = "Я забыл свой учебник на скамейке, принеси пожалуйста" };
            Item_useless Nosok = new Item_useless { X_ = 2, Y_ = 0, Name_ = "Носок", Discription_ = "Левый... Осталось найти правый" };
            Item_usefull Bilet = new Item_usefull { Name_ = "Студенческий билет", Discription_ = "Удостоверение студенческой личности" };
            NPC Zina = new NPC { X_ = 2, Y_ = 0, Name_ = "Зинаида", Answer_ = 4, item_ = Bilet };
            Item_usefull Ksiva = new Item_usefull {Name_ = "Ксива", Discription_ = "Какая-то важная бумажка. Не знаю, как она оказалась у кота" };
            NPC Cat = new NPC {X_=1, Y_=1, Name_ = "Кот", Answer_ = 3, item_ = Ksiva, Advice_ = "Мяу" };
            Item_useless Konfeta = new Item_useless { X_ = 0, Y_ = 1, Name_ = "Конфета", Discription_ = "Обычная конфета с пола" };
            Item_useless Pelmeni = new Item_useless {Name_ = "Пачка пельменей", Discription_ = "Продукт с непредсказуемой начинкой, лучше скушаю вечером" };
            NPC Kassir = new NPC {X_=0, Y_ = 1, Name_ = "Ашот", Answer_ = 2, item_ = Pelmeni, Advice_ = "Ты никуда не опаздываешь?" };
            Item_usefull Book = new Item_usefull { Name_ = "Учебник", Discription_ = "Что-то на умном и для умных - ещё не скоро смогу прочитать",X_ = 2, Y_ = 1 };
            Item_usefull Spisok = new Item_usefull {Name_ = "С.Ж.В.", Discription_ = "Список жёстких вопросов с экзамена, на них чаще всего валят студентов" };
            NPC Ohr = new NPC { X_ = 0, Y_ = 2, Name_ = "Охранник", Answer_ = 1, item_ = Spisok, Advice_ = "Ты ничего не забыл в своей комнате?" };
            Item_usefull Str = new Item_usefull {X_ =1, Y_=2, Name_ = "Стиралка", Discription_ = "Нлавное - не продырявить листок во время стирания своих каракулей" };
            Item_timer Clock = new Item_timer {Name_ = "Странные часы", Discription_ = "Они идут в обратную сторону?!", X_ = 0, Y_=0, TIME_ = 15 };
            Item_timer Sand_clock = new Item_timer { Name_ = "Песочные часы", Discription_ = "Треснувшие песочные часы на 30 минут", X_ = 2, Y_ = 1, TIME_ = -30};



            Locations.All_items(Pen);
            Locations.All_items(Pechenka);
            Locations.All_NPCs(Vadim);
            Locations.All_items(Nosok);
            Locations.All_NPCs(Zina);
            Locations.All_NPCs(Cat);
            Locations.All_items(Konfeta);
            Locations.All_NPCs(Kassir);
            Locations.All_items(Book);
            Locations.All_NPCs(Ohr);
            Locations.All_items(Str);
            Locations.All_items(Clock);
            Locations.All_items(Sand_clock);


            textBox1.Text = "Времени осталось: " + player.Time_.ToString();
            pictureBox1.Image = Properties.Resources.L_0;
            richTextBox1.Text = "Я проснулся в 7 часов утра в предвкушении замечательного дня...\n\rОднако я совсем забыл, " +
                "что сегодня экзамен! Так я ещё и не готов!\n\rМне нужно найти: канцелярию, студенческий билет и как можно больше конспектов\n\rСейчас я в своей комнате";
        }

        private void button1_Click_1(object sender, EventArgs e) //Комната
        {
            int x = 0, y = 0;
            if (player.Check_X_Y(x, y))
                player.Travel(x, y);
            textBox1.Clear();
            textBox1.Text = "Времени осталось: " + player.Time_.ToString();
            pictureBox1.Image = Properties.Resources.L_0; //фото
            richTextBox1.Text += "\n\rМоя комната";
            richTextBox1_TextChanged();
        }

        private void button1_Click(object sender, EventArgs e) // Зал
        {
            int x = 1, y = 0;
            if (player.Check_X_Y(x, y))
                player.Travel(x, y);
            textBox1.Clear();
            textBox1.Text = "Времени осталось: " + player.Time_.ToString();
            pictureBox1.Image = Properties.Resources.L_1;//фото
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            richTextBox1.Text += "\n\rЗал общежития";
            richTextBox1_TextChanged();
        }

        private void button2_Click(object sender, EventArgs e) // Первый этаж общежития
        {
            int x = 2, y = 0;
            if (player.Check_X_Y(x, y))
                player.Travel(x, y);
            textBox1.Clear();
            textBox1.Text = "Времени осталось: " + player.Time_.ToString();
            pictureBox1.Image = Properties.Resources.L_2;//фото
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            richTextBox1.Text += "\n\rПервый этаж общежития";
            richTextBox1_TextChanged();
        }

        private void button3_Click(object sender, EventArgs e) // магазин
        {
            int x = 0, y = 1;
            if (player.Check_X_Y(x, y))
                player.Travel(x, y);
            textBox1.Clear();
            textBox1.Text = "Времени осталось: " + player.Time_.ToString();
            pictureBox1.Image = Properties.Resources.L_3;//фото
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            richTextBox1.Text += "\n\rМагазин 'Троечка'";
            richTextBox1_TextChanged();
        }

        private void button4_Click(object sender, EventArgs e) // гаражи
        {
            int x = 1, y = 1;
            if (player.Check_X_Y(x, y))
                player.Travel(x, y);
            textBox1.Clear();
            textBox1.Text = "Времени осталось: " + player.Time_.ToString();
            pictureBox1.Image = Properties.Resources.L_4;//фото
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            richTextBox1.Text += "\n\rСтарые гаражи";
            richTextBox1_TextChanged();
        }

        private void button5_Click(object sender, EventArgs e) // скамейка 
        {
            int x = 2, y = 1;
            if (player.Check_X_Y(x, y))
                player.Travel(x, y);
            textBox1.Clear();
            textBox1.Text = "Времени осталось: " + player.Time_.ToString();
            pictureBox1.Image = Properties.Resources.L_5;//фото
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            richTextBox1.Text += "\n\rСкамейка. Просто скамейка";
            richTextBox1_TextChanged();
        }

        private void button6_Click(object sender, EventArgs e) // холл корпуса
        {
            int x = 0, y = 2;
            if (player.Check_X_Y(x, y))
                player.Travel(x, y);
            textBox1.Clear();
            textBox1.Text = "Времени осталось: " + player.Time_.ToString();
            pictureBox1.Image = Properties.Resources.L_6;//фото
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            richTextBox1.Text += "\n\rХолл учебного корпуса";
            richTextBox1_TextChanged();
        }

        private void button7_Click(object sender, EventArgs e) // столовая
        {
            int x = 1, y = 2;
            if (player.Check_X_Y(x, y))
                player.Travel(x, y);
            textBox1.Clear();
            textBox1.Text = "Времени осталось: " + player.Time_.ToString();
            pictureBox1.Image = Properties.Resources.L_7;//фото
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            richTextBox1.Text += "\n\rМоя любимая столовка";
            richTextBox1_TextChanged();
        }

        private void button8_Click(object sender, EventArgs e) // кабинет
        {
            int x = 2, y = 2;
            if (player.Check_X_Y(x, y))
                player.Travel(x, y);
            textBox1.Clear();
            textBox1.Text = "Времени осталось: " + player.Time_.ToString();
            pictureBox1.Image = Properties.Resources.L_8;//фото
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button10.Visible = false;
            button16.Visible = true;
            richTextBox1.Text += "\n\rКабинет преподавателя";
            richTextBox1_TextChanged();
        }

        private void button9_Click(object sender, EventArgs e)//показ инвентаря
        {
            Form2 Inventory = new Form2(player);
            Inventory.Show();

        }

        private void button11_Click(object sender, EventArgs e) // осмотр локации
        {
            player.Time_  = player.Time_ - 1;
            textBox1.Text = "Времени осталось: " + player.Time_.ToString();
            if (Locations.Search_item(player.X_, player.Y_, player))
                richTextBox1.Text += "\n\rЯ что-то нашёл!";
            else
                richTextBox1.Text += "\n\rТут ничего нет";
            richTextBox1_TextChanged();
        }

        private void button10_Click(object sender, EventArgs e) // разговор с нпс
        {
            if (Locations.NPC_near(player.X_, player.Y_))
            {
                richTextBox1.Text += "\n\rТут можно с кем-то поговорить";
                button12.Visible = true;
                button13.Visible = true;
                button14.Visible = true;
                button15.Visible = true;
            }
            else
                richTextBox1.Text += "\n\rЗдесь никого нет";
            richTextBox1_TextChanged();
        }
        
        private void button12_Click(object sender, EventArgs e) // реплика 1
        {
            player.Time_ = player.Time_ - 1;
            textBox1.Text = "Времени осталось: " + player.Time_.ToString();
            int Code = 1;
            if (Locations.Ask_for_item(player.X_, player.Y_, player, Code) == 2)
            {
                richTextBox1.Text += "\n\rМне что-то передали!";
                richTextBox1.Text +="\n\r" + Locations.NPC_Advice(player.X_, player.Y_);
            }
            else if (Locations.Ask_for_item(player.X_, player.Y_, player, Code) == 1)
                richTextBox1.Text += "\n\rМы уже всё обсудили";
            else if (Locations.Ask_for_item(player.X_, player.Y_, player, Code) == 4)
                richTextBox1.Text += "\n\rМне следует подобрать другие слова";
            richTextBox1_TextChanged();
        }

        private void button13_Click(object sender, EventArgs e) // реплика 2
        {
            player.Time_ = player.Time_ - 1;
            textBox1.Text = "Времени осталось: " + player.Time_.ToString();
            int Code = 2;
            if (Locations.Ask_for_item(player.X_, player.Y_, player, Code) == 2)
            {
                richTextBox1.Text += "\n\rМне что-то передали!";
                richTextBox1.Text += "\n\r" + Locations.NPC_Advice(player.X_, player.Y_);
            }
            else if (Locations.Ask_for_item(player.X_, player.Y_, player, Code) == 1)
                richTextBox1.Text += "\n\rМы уже всё обсудили";
            else if (Locations.Ask_for_item(player.X_, player.Y_, player, Code) == 4)
                richTextBox1.Text += "\n\rМне следует подобрать другие слова";
            richTextBox1_TextChanged();
        }

        private void button14_Click(object sender, EventArgs e) // реплика 3
        {
            player.Time_ = player.Time_ - 1;
            textBox1.Text = "Времени осталось: " + player.Time_.ToString();
            int Code = 3;
            if (Locations.Ask_for_item(player.X_, player.Y_, player, Code) == 2)
            {
                richTextBox1.Text += "\n\rМне что-то передали!";
                richTextBox1.Text += "\n\r" + Locations.NPC_Advice(player.X_, player.Y_);
            }
            else if (Locations.Ask_for_item(player.X_, player.Y_, player, Code) == 1)
                richTextBox1.Text += "\n\rМы уже всё обсудили";
            else if (Locations.Ask_for_item(player.X_, player.Y_, player, Code) == 4)
                richTextBox1.Text += "\n\rМне следует подобрать другие слова";
            richTextBox1_TextChanged();
        }

        private void button15_Click(object sender, EventArgs e) //реплика 4
        {
            player.Time_ = player.Time_ - 1;
            textBox1.Text = "Времени осталось: " + player.Time_.ToString();
            int Code = 4;
            if (Locations.Ask_for_item(player.X_, player.Y_, player, Code) == 2)
            {
                richTextBox1.Text += "\n\rМне что-то передали!";
                richTextBox1.Text += "\n\r" + Locations.NPC_Advice(player.X_, player.Y_);
            }
            else if (Locations.Ask_for_item(player.X_, player.Y_, player, Code) == 1)
                richTextBox1.Text += "\n\rМы уже всё обсудили";
            else if (Locations.Ask_for_item(player.X_, player.Y_, player, Code) == 4)
                richTextBox1.Text += "\n\rМне следует подобрать другие слова";
            richTextBox1_TextChanged();
        }

        private void button16_Click(object sender, EventArgs e) //тут будет сдача экзамена
        {
            if (player.Time_ > 0)
            {
                int Count = player.Pass_exam();
                if (Count == 0)
                {
                    richTextBox1.Text += "\n\rИ чем я только думал, когда шёл на экзамен как на праздник???";
                    richTextBox1_TextChanged();
                    Thread.Sleep(3000);
                    pictureBox2.Image = Properties.Resources.E_0;
                    pictureBox2.Visible = true;
                }
                if ((Count > 0) && (Count < 3))
                {
                    richTextBox1.Text += "\n\rНу что это такое?! Меня просто завалили!!! Я же был готов на все... хотя не был я готов даже на троечку";
                    richTextBox1_TextChanged();
                    Thread.Sleep(3000);
                    pictureBox2.Image = Properties.Resources.E_1;
                    pictureBox2.Visible = true;
                }
                if (Count == 3)
                {
                    richTextBox1.Text += "\n\rТройка тоже сойдёт. Главное - что теперь можно слова полежать";
                    richTextBox1_TextChanged();
                    Thread.Sleep(3000);
                    pictureBox2.Image = Properties.Resources.E_2;
                    pictureBox2.Visible = true;
                }
                if (Count == 4)
                {
                    richTextBox1.Text += "\n\rЯ не такой уж и глупый! Четвёрка - это хорошо, но в следующий раз надо будет подготовиться на пятёрку";
                    richTextBox1_TextChanged();
                    Thread.Sleep(3000);
                    pictureBox2.Image = Properties.Resources.E_3;
                    pictureBox2.Visible = true;
                }
                if (Count == 5)
                {
                    richTextBox1.Text += "\n\rКакой же я молодец! Надо позвонить родителям, порадую их своей пятёркой";
                    richTextBox1_TextChanged();
                    Thread.Sleep(3000);
                    pictureBox2.Image = Properties.Resources.E_4;
                    pictureBox2.Visible = true;
                }
                if (Count > 5)
                {
                    richTextBox1.Text += "\n\rЯ - сверхразум";
                    richTextBox1_TextChanged();
                    Thread.Sleep(3000);
                    pictureBox2.Image = Properties.Resources.E_5;
                    pictureBox2.Visible = true;
                }
            }
            else 
            {
                richTextBox1_TextChanged();
                richTextBox1.Text += "\n\rЯ НЕ УСПЕЕЕЕЕЕЕЛ";
                Thread.Sleep(3000);
                pictureBox2.Image = Properties.Resources.E_Loser;
                pictureBox2.Visible = true;
            }

        }

        private void button17_Click(object sender, EventArgs e) // Рестарт игры
        {
            Application.Restart();
        }


        private void richTextBox1_TextChanged()
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }
    }
}
