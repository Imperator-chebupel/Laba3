using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Текстовый_квест_с_интерфейсом
{
    [Serializable] public abstract class Item
    {/*
        string Name;
        string Discription;
        int X;
        int Y;*/

        public string Index { get; set; }

        public int X_
        {
            get;// { return X; }
            set;// { X = value; }
        }

        public int Y_
        {
            get;// { return Y; }
            set;// { Y = value; }
        }

        public string Name_
        {
            get;// { return Name; }
            set;// { Name = value; }
        }

        public string Discription_ 
        {
            get;// { return Discription; } 
            set;// { Discription = value; } 
        }

        public /*virtual*/abstract string Write();  //{ return ""; }
        
    }
}
