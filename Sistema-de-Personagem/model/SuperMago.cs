using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_Personagem.model
{
    public class SuperMago : Personagem
    {
        private string genero;
        private string especial;

        public SuperMago(int vida, int ataque, int defesa, int velocidade, string genero, string especial) : base (vida, ataque, defesa, velocidade)
        {
            this.genero = genero;
            this.especial = especial;
        }

        public string GetGenero()
        {
            return genero;
        }

        public void SetGenero(string genero)
        {
            this.genero = genero;
        }

        public string GetEspecial()
        {
            return especial;
        }

        public void SetEspecial(string especial)
        {
            this.especial = especial;
        }





        public override void Status()
        {
            Console.WriteLine($"Dados do personagem:");
            Console.WriteLine($"Vida: {GetVida()}");
            Console.WriteLine($"Ataque: {GetAtaque()}");
            Console.WriteLine($"Defesa: {GetDefesa()}");
            Console.WriteLine($"Genero: {GetGenero()}");
            Console.WriteLine($"Ataque especial: {GetEspecial()}");
            Console.WriteLine("");
        }
    }
}