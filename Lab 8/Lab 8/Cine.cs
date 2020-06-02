using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
   public class Cine : Local
    {
        decimal  num_salas;

        public Cine(string name, string name_Dueno, string horario, int num, decimal num_salas) : base (name, name_Dueno, horario, num)
        {
            Num_salas = num_salas;
        }

        public decimal Num_salas { get => num_salas; set => num_salas = value; }
    }
}
