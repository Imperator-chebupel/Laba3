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
        Player player = new Player();
        Item_usefull amogus = new Item_usefull {Name_ = "asdfg", Discription_ = "Мощная хрень" };
        public Form1()
        {
            InitializeComponent();
            this.player.X_ = 0;
            this.player.Y_ = 0;
            textBox1.Text = "Времени осталось: " + player.Time_.ToString();
            pictureBox1.Image = Properties.Resources.L_0;
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
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int x = 2, y = 2;
            if (player.Check_X_Y(x, y))
                player.Travel(x, y);
            textBox1.Clear();
            textBox1.Text = "Времени осталось: " + player.Time_.ToString();
            pictureBox1.Image = Properties.Resources.L_8;//фото
        }

        private void button9_Click(object sender, EventArgs e)
        {
            player.Pick_up(amogus);
            player.Pick_up(amogus);
            Form2 Inventory = new Form2(player);
            Inventory.Show();

        }
    }
}
