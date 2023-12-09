using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Текстовый_квест_с_интерфейсом
{
    public class Player
    {
        int Time = 90;
        int X; 
        int Y;
        List<Item> Inventory = new List<Item>();

        public int Time_
        {
            get { return Time; }
            set { Time = value; }
        }

        public int X_
        {
            get { return X; }
            set { X = value; }
        }

        public int Y_
        {
            get { return Y; }
            set { Y = value; }
        }

        public bool Check_X_Y(int x, int y)
        {
            if ((X == x) && (Y == y))
                    return false;
            else
                return true;
        }


        public void Travel(int x, int y) //вычет времени игрока в зависимости от перемещений
        {
            Time_ = Time - Math.Abs(x - X) * 3 - Math.Abs(y - Y) * 5;
            X = x;
            Y = y;
        }

        public string Write_inventory()
        {
            string result = "";
            int i = 1;
            foreach (Item I in Inventory)
            {
                result = result + i + ") " + I.Write();
                i++;
            }
            return result;
        }

        public void Pick_up(Item item)
        {
            Inventory.Add(item);
        }


        public int Pass_exam()
        {
            int count = 0;
            foreach (Item item in Inventory)
            {
                if (item is Item_usefull)
                    count++;
            }
            return count;
        }

        // Тут будет изменение времени
        public int Change_Time () 
        {
            int T = 0;
            foreach (Item item in Inventory)
            {
                if (item is Item_timer) 
                {
                    T = ((Item_timer)item).TIME_;
                    Inventory.Remove(item);
                    return T;
                }
            }
            return 0;
        }
    }
}
