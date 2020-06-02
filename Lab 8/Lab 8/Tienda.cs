using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Tienda : Local
    {
        List<string> categoria;

        public Tienda(string name, string name_Dueno, string horario, int num, List<string> categoria) : base(name, name_Dueno, horario, num)
        { 
            Categoria = categoria;
        }

        public List<string> Categoria { get => categoria; set => categoria = value; }
        public override string Show()
        {
            string s = "Nombre: " + this.Name + "\r" + "Nombre Dueño: " + this.Name_Dueno + "\r" + "Horario:" + this.Horario;
            s += "Categorías: ";
            foreach (string t in this.categoria)
            {
                s += t;
            }
            return s;
        }
    }
}
