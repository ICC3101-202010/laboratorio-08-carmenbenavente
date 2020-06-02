using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
   public class Recreacional : Local
    {


        public Recreacional(string name, string name_Dueno, string horario, int num) : base(name, name_Dueno, horario, num)
        {
           
        }

        public override string Show()
        {
            string s = "Nombre: " + this.Name + "\r" + "Nombre Dueño: " + this.Name_Dueno + "\r" + "Horario:" + this.Horario;
            s += "No tiene información adicional";
            return s;
        }

    }
}
