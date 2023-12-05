using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            Item_usefull Pen = new Item_usefull { X_ = 0, Y_ = 0, Name_ = "Ручка", Discription_ = "Самый важный инструмент после собственной головы" };
            Item_useless Pechenka = new Item_useless { X_ = 1, Y_ = 0, Name_ = "Печенье", Discription_ = "Выглядит вкусно" };
            Item_usefull Zapisi = new Item_usefull { X_ =9, Y_=0,Name_ = "Записи", Discription_ = "То немногое, что Вадим успел записать за все лекции, на которых он был (целых 2)" };
            NPC Vadim = new NPC {X_ =1, Y_ = 0, Name_ = "Вадим", item_ = Zapisi, Answer_ = 1 };


            Locations.All_items(Pen);
            Locations.All_items(Pechenka);
            Locations.All_NPCs(Vadim);

            textBox1.Text = "Времени осталось: " + player.Time_.ToString();
            pictureBox1.Image = Properties.Resources.L_0;
            richTextBox1.Text = "Я проснулся в 7 часов утра в предвкушении замечательного дня...\n\rОднако я совсем забыл, " +
                "что сегодня экзамен! Так я ещё и не готов!\n\rМне нужно найти: канцелярию, студенческий билет и как можно больше конспектов";
        }

        private void button1_Click_1(object sender, EventArgs e) //Комната
        {
            int x = 0, y = 0;
            if (player.Check_X_Y(x, y))
                player.Travel(x, y);
            textBox1.Clear();
            textBox1.Text = "Времени осталось: " + player.Time_.ToString();
            pictureBox1.Image = Properties.Resources.L_0; //фото
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
            
        }
        
        private void button12_Click(object sender, EventArgs e) // реплика 1
        {
            player.Time_ = player.Time_ - 1;
            textBox1.Text = "Времени осталось: " + player.Time_.ToString();
            int Code = 1;
            if (Locations.Ask_for_item(player.X_, player.Y_, player, Code) == 2)
                richTextBox1.Text += "\n\rМне что-то передали!";
            else if (Locations.Ask_for_item(player.X_, player.Y_, player, Code) == 1)
                richTextBox1.Text += "\n\rМы уже всё обсудили";
            else if (Locations.Ask_for_item(player.X_, player.Y_, player, Code) == 4)
                richTextBox1.Text += "\n\rМне следует подобрать другие слова";
        }

        private void button13_Click(object sender, EventArgs e) // реплика 2
        {
            player.Time_ = player.Time_ - 1;
            textBox1.Text = "Времени осталось: " + player.Time_.ToString();
            int Code = 2;
            if (Locations.Ask_for_item(player.X_, player.Y_, player, Code) == 2)
                richTextBox1.Text += "\n\rМне что-то передали!";
            else if (Locations.Ask_for_item(player.X_, player.Y_, player, Code) == 1)
                richTextBox1.Text += "\n\rМы уже всё обсудили";
            else if (Locations.Ask_for_item(player.X_, player.Y_, player, Code) == 4)
                richTextBox1.Text += "\n\rМне следует подобрать другие слова";
        }

        private void button14_Click(object sender, EventArgs e) // реплика 3
        {
            player.Time_ = player.Time_ - 1;
            textBox1.Text = "Времени осталось: " + player.Time_.ToString();
            int Code = 3;
            if (Locations.Ask_for_item(player.X_, player.Y_, player, Code) == 2)
                richTextBox1.Text += "\n\rМне что-то передали!";
            else if (Locations.Ask_for_item(player.X_, player.Y_, player, Code) == 1)
                richTextBox1.Text += "\n\rМы уже всё обсудили";
            else if (Locations.Ask_for_item(player.X_, player.Y_, player, Code) == 4)
                richTextBox1.Text += "\n\rМне следует подобрать другие слова";
        }

        private void button15_Click(object sender, EventArgs e) //реплика 4
        {
            player.Time_ = player.Time_ - 1;
            textBox1.Text = "Времени осталось: " + player.Time_.ToString();
            int Code = 4;
            if (Locations.Ask_for_item(player.X_, player.Y_, player, Code) == 2)
                richTextBox1.Text += "\n\rМне что-то передали!";
            else if (Locations.Ask_for_item(player.X_, player.Y_, player, Code) == 1)
                richTextBox1.Text += "\n\rМы уже всё обсудили";
            else if (Locations.Ask_for_item(player.X_, player.Y_, player, Code) == 4)
                richTextBox1.Text += "\n\rМне следует подобрать другие слова";
        }
    }
}
