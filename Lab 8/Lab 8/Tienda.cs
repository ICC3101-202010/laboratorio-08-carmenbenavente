using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Tienda
    {
        string name_Dueno, horario;
        int num;
        List<string> categoria;

        public Tienda(string name_Dueno, string horario, int num, List<string> categoria)
        {
            Name_Dueno = name_Dueno;
            Horario = horario;
            Num = num;
            Categoria = categoria;
        }

        public string Name_Dueno { get => name_Dueno; set => name_Dueno = value; }
        public string Horario { get => horario; set => horario = value; }
        public int Num { get => num; set => num = value; }
        public List<string> Categoria { get => categoria; set => categoria = value; }
    }
}
