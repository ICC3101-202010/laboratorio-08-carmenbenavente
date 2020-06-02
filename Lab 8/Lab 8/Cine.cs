using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
   public class Cine
    {
        string name_Dueno, horario;
        int num, num_salas;

        public Cine(string name_Dueno, string horario, int num, int num_salas)
        {
            Name_Dueno = name_Dueno;
            Horario = horario;
            Num = num;
            Num_salas = num_salas;
        }

        public string Name_Dueno { get => name_Dueno; set => name_Dueno = value; }
        public string Horario { get => horario; set => horario = value; }
        public int Num { get => num; set => num = value; }
        public int Num_salas { get => num_salas; set => num_salas = value; }
    }
}
