using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Текстовый_квест_с_интерфейсом
{
    public class NPC
    {
        int X;
        int Y;
        string Name;
        Item item;
        int Answer;
        int Index;
        string Advice; 

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

        public int Index_
        {
            get { return Index; }
            set { Index = value; }
        }

    }
}
