using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Текстовый_квест
{
    internal class Player
    {
        public
        int time_h = 7;
        public
        int time_m = 0;
        float time_speed = 1.0f;
        List <Objects> inventoty = new List<Objects>();
        string[][] dialogs = new string[][] { };

        public void To_Do()
        {
            
        }
    }
}
