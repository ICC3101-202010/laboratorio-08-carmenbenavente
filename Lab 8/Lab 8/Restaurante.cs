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

        public override string Show()
        {
            string s = "Nombre: " + this.Name + "\r" + "Nombre Dueño: " + this.Name_Dueno + "\r" + "Horario:" + this.Horario;
            if (mesas)
            {
                s += "Sí contiene mesas exclusivas";
            }
            else
            {
                s += "No contiene mesas exclusivas";
            }
            return s;
        }
    }
}
