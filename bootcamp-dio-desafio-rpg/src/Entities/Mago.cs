using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootcamp_dio_desafio_rpg.src.Entities
{
    public class Mago : Heroi
    {
        public Mago(string nome, int level)
        {
            Nome = nome;
            Level = level;
            Classe = "Mago";
        }

        public override string Ataque()
        {
            return Nome + " lançou uma magia!";
        }
    }
}
