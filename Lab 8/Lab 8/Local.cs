using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Local
    {
        string name, name_Dueno, horario;
        int num;

        public Local(string name, string name_Dueno, string horario, int num)
        {
            Name = name;
            Name_Dueno = name_Dueno;
            Horario = horario;
            Num = num;
        }

        public string Name { get => name; set => name = value; }
        public string Name_Dueno { get => name_Dueno; set => name_Dueno = value; }
        public string Horario { get => horario; set => horario = value; }
        public int Num { get => num; set => num = value; }
        
        public string Show()
        {
            string s = "Nombre: " + this.Name +"\r" + "Nombre Dueño: " + this.Name_Dueno +"\r" + "Horario:" + this.Horario;
            return s;
        }
    }
}
