using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Текстовый_квест_с_интерфейсом
{
    public class Item_timer : Item
    {
        int TIME;
        public int TIME_
        {
            get {return TIME;}
            set { TIME = value;}
        }
        public override string Write()
        {
            return (Name_ + "\r\n" + Discription_ + "\r\n" + "Высшие силы хотят начать игру со временем. Надо быть осторожным" + "\r\n");
        }

    }
}
