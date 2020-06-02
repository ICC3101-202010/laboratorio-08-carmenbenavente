using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Restaurante
    {
        string name_Dueno, horario;
        int num;
        bool mesas;

        public Restaurante(string name_Dueno, string horario, int num, bool mesas)
        {
            Name_Dueno = name_Dueno;
            Horario = horario;
            Num = num;
            Mesas = mesas;
        }

        public string Name_Dueno { get => name_Dueno; set => name_Dueno = value; }
        public string Horario { get => horario; set => horario = value; }
        public int Num { get => num; set => num = value; }
        public bool Mesas { get => mesas; set => mesas = value; }
    }
}
