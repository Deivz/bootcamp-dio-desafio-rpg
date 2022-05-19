using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootcamp_dio_desafio_rpg.src.Entities
{
    public abstract class Heroi
    {
        public string Nome { get; protected set; }
        public int Level { get; protected set; }
        public string Classe { get; protected set; }

        protected Heroi()
        {
        }

        public abstract string Ataque();

    }
}
