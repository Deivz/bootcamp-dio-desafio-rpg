using bootcamp_dio_desafio_rpg.src.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootcamp_dio_desafio_rpg.src.Entities
{
    internal class Boss : Heroi, IBoss
    {
        public Boss(string nome, int level)
        {
            Nome = nome;
            Classe = "Boss";
            Level = level;
        }

        public override string Ataque()
        {
            return Nome + " atirou uma flecha.";
        }

        public string Ataque(Heroi heroi)
        {
            return Nome + " atirou uma flecha em " + heroi.Nome;
        }
        public string FeiticoEmArea(int dano)
        {
            return Nome + " lançou um feitiço em área causando " + dano + " de dano";
        }
    }
}
