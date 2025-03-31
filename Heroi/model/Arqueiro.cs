using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Heroi.Interface;

namespace Heroi.model
{
    public class Arqueiro : IAtacante {

        public string atacar;
        public string especial;

        public Arqueiro(string atacar, string especial)
        {
            this.atacar = atacar;
            this.especial = especial;
        }
        
        public void Atacar() {
        Console.WriteLine("Arqueiro dispara flechas!");
        }
        public void Especial() {
        Console.WriteLine("Arqueiro dispara um chuva de flechas!");
        }
    }
}