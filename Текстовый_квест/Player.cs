using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Текстовый_квест
{
    internal class Player
    {
        int Time_left = 90;

        public int Time_left_
        {
            get { return Time_left; }
            set { Time_left = value; }
        }



        List <Objects> inventoty = new List<Objects>();
        string[][] dialogs = new string[][] { };

        public void Add_obj(Objects O)
        {
            inventoty.Add(O);
        }


        public void To_Do()
        {
            
        }
    }
}
