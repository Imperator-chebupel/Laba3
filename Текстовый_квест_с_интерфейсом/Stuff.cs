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
        List<NPC> NPCs = new List<NPC>();


        public void All_items(Item item)
        {
            Items.Add(item);
        }

        public void All_NPCs(NPC npc)
        {
            NPCs.Add(npc);
        }

        public void Take_item(Item item)
        {
            Items.Remove(item);
        }

        public void Take_item_from(Item item, NPC npc)
        {
            npc.item_ = null;
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
        
        public int Ask_for_item(int x_p, int y_p, Player player, int code)
        {
            foreach (NPC npc in NPCs)
            {
                if ((npc.X_ == x_p) && (npc.Y_ == y_p) && (code == npc.Answer_))
                {
                    if (npc.item_ != null)
                    {
                        player.Pick_up(npc.item_);
                        Take_item_from(npc.item_, npc);
                        return 2;
                    }
                    else
                        return 1;
                }
                else if ((npc.X_ == x_p) && (npc.Y_ == y_p) && (code != npc.Answer_))
                    return 4;
            }
            return 0;
        }

            public bool NPC_near(int x_p, int y_p)
        {
            foreach (NPC npc in NPCs)
            {
                if ((npc.X_ == x_p) && (npc.Y_ == y_p))
                {
                        return true;
                }
            }
            return false;
        }
    }
}
