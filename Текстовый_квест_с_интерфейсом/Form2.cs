using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Текстовый_квест_с_интерфейсом
{

    public partial class Form2 : Form
    {
        //public Player player;

        public Form2(Player player_)
        {
            InitializeComponent();
            richTextBox1.Text = player_.Write_inventory();
        }

        
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
