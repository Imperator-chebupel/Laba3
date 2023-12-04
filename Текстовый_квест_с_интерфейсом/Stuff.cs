using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Текстовый_квест_с_интерфейсом
{
    public class Stuff
    {
        List<Item> Items = new List<Item>();



        public void All_items(Item item)
        {
            Items.Add(item);
        }

        public void Take_item(Item item)
        {
            Items.Remove(item);
        }

        public bool Search_item(int x_p, int y_p, Player player)
        {
            bool A; //проверка на существование предмета
            foreach (Item item in Items)
            {
                if ((item.X_ == x_p) && (item.Y_ == y_p))
                {
                    player.Pick_up(item);
                    Take_item(item);
                    return true;
                }
            }
            return false;
        }
    }
}
