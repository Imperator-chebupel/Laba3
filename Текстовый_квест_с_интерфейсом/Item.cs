using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Текстовый_квест_с_интерфейсом
{
    public abstract class Item
    {
        string Name;
        string Discription;

        public string Name_
        {
            get { return Name; }
            set { Name = value; }
        }

        public string Discription_ 
        {
            get { return Discription; } 
            set { Discription = value; } 
        }

        public abstract string Write();
        
    }
}
