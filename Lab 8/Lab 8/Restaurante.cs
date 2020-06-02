using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Restaurante : Local
    {

        bool mesas;

        public Restaurante(string name, string name_Dueno, string horario, int num, bool mesas) : base(name, name_Dueno, horario, num)
        {
            Mesas = mesas;
        }
       

        public bool Mesas { get => mesas; set => mesas = value; }

    }
}
