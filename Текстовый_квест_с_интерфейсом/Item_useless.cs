using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Текстовый_квест_с_интерфейсом
{
    public class Item_useless : Item
    {
        public override string Write()
        {
            return (Name_ + "\r\n" + Discription_ + "\r\n" + "Никто не знает, понадобится ли эта штука на экзамене..." + "\r\n");
        }
    }
}
