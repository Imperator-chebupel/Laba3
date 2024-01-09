using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Текстовый_квест_с_интерфейсом
{
    public class Item_usefull : Item
    {
        //new string Index = "1";
        public override string Write()
        {
            return (Name_ + "\r\n" + Discription_ + "\r\n" + "Необходимый для зачёта предмет" + "\r\n");
        }
    }
}
