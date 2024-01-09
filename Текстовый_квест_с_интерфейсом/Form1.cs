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
        FileWorker FW = new FileWorker();
        Player player = new Player {X_ =0, Y_ = 0, Inventory = new List<Item>()};
        Stuff Locations = new Stuff();
        public Form1(List<NPC> npcs, List<Item> items )
        {
            InitializeComponent();
            Hide_dialogs();
            button16.Visible = false;
            pictureBox2.Visible = false;

            foreach (NPC N in npcs)
            {
                Locations.All_NPCs(N);
            }
            foreach (Item I in items)
            {
                Locations.All_items(I);
            }


            textBox1.Text = "Времени осталось: " + player.Time_.ToString();
            pictureBox1.Image = Properties.Resources.L_0;
            richTextBox1.Text = "Я проснулся в 7 часов утра в предвкушении замечательного дня...\n\rОднако я совсем забыл, " +
                "что сегодня экзамен! Так я ещё и не готов!\n\rМне нужно найти: канцелярию, студенческий билет и как можно больше конспектов\n\rСейчас я в своей комнате";
            this.Text = "Текстовый_квест";
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
            Hide_dialogs();
        }

        private void button1_Click(object sender, EventArgs e) // Зал
        {
            int x = 1, y = 0;
            if (player.Check_X_Y(x, y))
                player.Travel(x, y);
            textBox1.Clear();
            textBox1.Text = "Времени осталось: " + player.Time_.ToString();
            pictureBox1.Image = Properties.Resources.L_1;//фото
            Hide_dialogs();
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
            Hide_dialogs();
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
            Hide_dialogs();
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
            Hide_dialogs();
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
            Hide_dialogs();
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
            Hide_dialogs();
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
            Hide_dialogs();
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
            Hide_dialogs();
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
            if (Locations.NPC_near(player.X_, player.Y_) != -1 )
            {
                richTextBox1.Text += "\n\rТут можно поговорить c " + Locations.NPC_name(player.X_, player.Y_);
                button12.Visible = true;
                button12.Text = player.Frases[Locations.NPC_near(player.X_, player.Y_), 0];
                button13.Visible = true;
                button13.Text = player.Frases[Locations.NPC_near(player.X_, player.Y_), 1];
                button14.Visible = true;
                button14.Text = player.Frases[Locations.NPC_near(player.X_, player.Y_), 2];
                button15.Visible = true;
                button15.Text = player.Frases[Locations.NPC_near(player.X_, player.Y_), 3];
            }
            else
                richTextBox1.Text += "\n\rЗдесь никого нет";
            richTextBox1_TextChanged();
        }
        
        private void button12_Click(object sender, EventArgs e) // реплика 1
        {
            Speech(1);
        }

        private void button13_Click(object sender, EventArgs e) // реплика 2
        {
            Speech(2);
        }

        private void button14_Click(object sender, EventArgs e) // реплика 3
        {
            Speech(3);
        }

        private void button15_Click(object sender, EventArgs e) //реплика 4
        {
            Speech(4);
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
                }
                if ((Count > 0) && (Count < 3))
                {
                    richTextBox1.Text += "\n\rНу что это такое?! Меня просто завалили!!! Я же был готов на все... хотя не был я готов даже на троечку";
                    richTextBox1_TextChanged();
                    Thread.Sleep(3000);
                    pictureBox2.Image = Properties.Resources.E_1;
                }
                if (Count == 3)
                {
                    richTextBox1.Text += "\n\rТройка тоже сойдёт. Главное - что теперь можно слова полежать";
                    richTextBox1_TextChanged();
                    Thread.Sleep(3000);
                    pictureBox2.Image = Properties.Resources.E_2;
                }
                if (Count == 4)
                {
                    richTextBox1.Text += "\n\rЯ не такой уж и глупый! Четвёрка - это хорошо, но в следующий раз надо будет подготовиться на пятёрку";
                    richTextBox1_TextChanged();
                    Thread.Sleep(3000);
                    pictureBox2.Image = Properties.Resources.E_3;
                }
                if (Count == 5)
                {
                    richTextBox1.Text += "\n\rКакой же я молодец! Надо позвонить родителям, порадую их своей пятёркой";
                    richTextBox1_TextChanged();
                    Thread.Sleep(3000);
                    pictureBox2.Image = Properties.Resources.E_4;
                }
                if (Count > 5)
                {
                    richTextBox1.Text += "\n\rЯ - сверхразум";
                    richTextBox1_TextChanged();
                    Thread.Sleep(3000);
                    pictureBox2.Image = Properties.Resources.E_5;
                }
            }
            else 
            {
                richTextBox1_TextChanged();
                richTextBox1.Text += "\n\rЯ НЕ УСПЕЕЕЕЕЕЕЛ";
                Thread.Sleep(3000);
                pictureBox2.Image = Properties.Resources.E_Loser;
            }
            pictureBox2.Visible = true;
        }

        private void button17_Click(object sender, EventArgs e) // Рестарт игры
        {
            Form3 form3 = new Form3();
            form3.Show();//подтверждение
        }


        private void richTextBox1_TextChanged()
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }

        private void Hide_dialogs()
        {
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
        }

        private void Speech(int Number)
        {
            player.Time_ = player.Time_ - 1;
            textBox1.Text = "Времени осталось: " + player.Time_.ToString();

            richTextBox1.Text += Locations.Ask_for_item(player.X_, player.Y_, player, Number);
            richTextBox1_TextChanged();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            FW.Write_to_JSON_player(player);
            richTextBox1.Text += "\n\rПрогресс сохранён";
            richTextBox1_TextChanged();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            player.X_ = FW.Read_the_JSON_player().X_;
            player.Y_ = FW.Read_the_JSON_player().Y_;
            player.Time_ = FW.Read_the_JSON_player().Time_;
            player.Inventory = FW.Read_the_JSON_player().Inventory;
            richTextBox1.Text += "\n\rПрогресс загружен";
            textBox1.Text = "Времени осталось: " + player.Time_.ToString();
            richTextBox1_TextChanged();
        }
    }
}
