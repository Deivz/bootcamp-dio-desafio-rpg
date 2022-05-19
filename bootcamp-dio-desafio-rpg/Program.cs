using bootcamp_dio_desafio_rpg.src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootcamp_dio_desafio_rpg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var guerreiro1 = new Guerreiro("Ajax", 30);
            var mago1 = new Mago("Deivz", 32);
            var chefe1 = new Boss("Sylvanas", 65);

            Console.WriteLine(guerreiro1.Ataque());
            Console.WriteLine(mago1.Ataque());

            Console.WriteLine(chefe1.Ataque());
            Console.WriteLine(chefe1.Ataque(guerreiro1));
            Console.WriteLine(chefe1.FeiticoEmArea(40));

            Console.ReadLine();
        }
    }
}
