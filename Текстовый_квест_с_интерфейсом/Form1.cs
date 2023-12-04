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


            Item_usefull Pen = new Item_usefull { X_ = 0, Y_ = 0, Name_ = "Ручка", Discription_ = "Самый важный инструмент после собственной головы" };
            Item_useless Pechenka = new Item_useless { X_ = 1, Y_ = 0, Name_ = "Печенье", Discription_ = "Выглядит вкусно" };
            Locations.All_items(Pen);
            Locations.All_items(Pechenka);


            //Item_usefull Zapisi = new Item_usefull { Name_ = "Записи", Discription_ = "То немногое, что Вадим успел записать за все лекции, на которых он был (целых 2)" };
            //NPC Vadim = new NPC {X_ =1, Y_ = 0, Name_ = "Вадим", item_ = Zapisi };
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
            button10.Text = "Pogovorit s Vadimom";
        }

        private void button2_Click(object sender, EventArgs e) // Первый этаж общежития
        {
            int x = 2, y = 0;
            if (player.Check_X_Y(x, y))
                player.Travel(x, y);
            textBox1.Clear();
            textBox1.Text = "Времени осталось: " + player.Time_.ToString();
            pictureBox1.Image = Properties.Resources.L_2;//фото
        }

        private void button3_Click(object sender, EventArgs e) // магазин
        {
            int x = 0, y = 1;
            if (player.Check_X_Y(x, y))
                player.Travel(x, y);
            textBox1.Clear();
            textBox1.Text = "Времени осталось: " + player.Time_.ToString();
            pictureBox1.Image = Properties.Resources.L_3;//фото
        }

        private void button4_Click(object sender, EventArgs e) // гаражи
        {
            int x = 1, y = 1;
            if (player.Check_X_Y(x, y))
                player.Travel(x, y);
            textBox1.Clear();
            textBox1.Text = "Времени осталось: " + player.Time_.ToString();
            pictureBox1.Image = Properties.Resources.L_4;//фото
        }

        private void button5_Click(object sender, EventArgs e) // скамейка 
        {
            int x = 2, y = 1;
            if (player.Check_X_Y(x, y))
                player.Travel(x, y);
            textBox1.Clear();
            textBox1.Text = "Времени осталось: " + player.Time_.ToString();
            pictureBox1.Image = Properties.Resources.L_5;//фото
        }

        private void button6_Click(object sender, EventArgs e) // холл корпуса
        {
            int x = 0, y = 2;
            if (player.Check_X_Y(x, y))
                player.Travel(x, y);
            textBox1.Clear();
            textBox1.Text = "Времени осталось: " + player.Time_.ToString();
            pictureBox1.Image = Properties.Resources.L_6;//фото
        }

        private void button7_Click(object sender, EventArgs e) // столовая
        {
            int x = 1, y = 2;
            if (player.Check_X_Y(x, y))
                player.Travel(x, y);
            textBox1.Clear();
            textBox1.Text = "Времени осталось: " + player.Time_.ToString();
            pictureBox1.Image = Properties.Resources.L_7;//фото
            //button10.Text += "tetei";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int x = 2, y = 2;
            if (player.Check_X_Y(x, y))
                player.Travel(x, y);
            textBox1.Clear();
            textBox1.Text = "Времени осталось: " + player.Time_.ToString();
            pictureBox1.Image = Properties.Resources.L_8;//фото
            //button10.Text += "prepodovatelem";
        }

        private void button9_Click(object sender, EventArgs e)//показ инвентаря
        {
            Form2 Inventory = new Form2(player);
            Inventory.Show();

        }

        private void button11_Click(object sender, EventArgs e) // осмотр локации
        {
            if (Locations.Search_item(player.X_, player.Y_, player))
                richTextBox1.Text += "\n\rЯ что-то нашёл!";
            else
                richTextBox1.Text += "\n\rТут ничего нет";
        }
    }
}
