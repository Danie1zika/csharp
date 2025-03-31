using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Heroi.Interface;

namespace Heroi.model
{
    public class Mago : IAtacante {

        public string atacar;
        public string especial;

        public Mago(string atacar, string especial)
        {
            this.atacar = atacar;
            this.especial = especial;
        }
        
        public void Atacar() {
        Console.WriteLine("Mago usa um feitiço!");
        }
        public void Especial() {
        Console.WriteLine("Mago conjura um Dragão!");
        Console.WriteLine("");
        }
    }
}