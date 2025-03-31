using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Heroi.Interface;

namespace Heroi.model
{
    public class Guerreiro : IAtacante {

        public string atacar;
        public string especial;

        public Guerreiro(string atacar, string especial)
        {
            this.atacar = atacar;
            this.especial = especial;
        }
        
        public void Atacar() {
        Console.WriteLine("Guerreiro ataca com espada!");
        }
        public void Especial() {
        Console.WriteLine("Guerreiro cria um escudo!");
        Console.WriteLine("");
        }
    }
}