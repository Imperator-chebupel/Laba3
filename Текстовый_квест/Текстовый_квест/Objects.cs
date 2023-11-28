using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Текстовый_квест
{
    internal class Objects
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

        public void Read()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Discription);
        }
    }
}
