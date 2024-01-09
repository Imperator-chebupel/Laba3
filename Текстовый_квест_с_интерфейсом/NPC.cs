using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Текстовый_квест_с_интерфейсом
{
    [Serializable] public class NPC
    {
        int X;
        int Y;
        string Name;
        Item item;
        int Answer;
        int F_Number;
        string Advice;

        public string Index { get; set; }
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

        public string Name_
        {
            get { return Name; }
            set { Name = value; }
        }

        public string Advice_
        {
            get { return Advice; }
            set { Advice = value; }
        }


        public Item item_
        {
            get { return item; }
            set { item = value;}
        }

        public int Answer_
        {
            get { return Answer; }
            set { Answer = value; }
        }

        public int F_Number_
        {
            get { return F_Number; }
            set { F_Number = value; }
        }

        public void NoItem()
        {
            Item_useless A = new Item_useless {Name_ = "Nothing" };
            item = A;
        }
    }
}
