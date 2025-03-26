using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_Personagem.model
{
    public class MagoDeGelo
    {
        private int vida;
    private int ataque;
    private int defesa;
    protected int velocidade;
    private string genero;
    private string especial;
    public MagoDeGelo(int vida, int ataque, int defesa, int velocidade, string genero, string especial)
    {
        this.vida = vida;
        this.ataque = ataque;
        this.defesa = defesa;
        this.velocidade = velocidade;
        this.genero = genero;
        this.especial = especial;
    }
    ////////////////////////////////////////////////////////////////
    public int GetVida()
    {
        return vida;
    }
    public void SetVida(int vida)
    {
        this.vida = vida;
    }

////////////////////////////////////////////////////////////////
        public int GetAtaque()
    {
        return ataque;
    }
    public void SetAtaque(int ataque)
    {
        this.ataque = ataque;
    }

////////////////////////////////////////////////////////////////
        public int GetDefesa()
    {
        return defesa;
    }
    public void SetDefesa(int defesa)
    {
        this.defesa = defesa;
    }

////////////////////////////////////////////////////////////////

        public int GetVelocidade()
    {
        return velocidade;
    }
    public void SetVelocidade(int velocidade)
    {
        this.velocidade = velocidade;
    }

////////////////////////////////////////////////////////////////

        public string GetGenero()
    {
        return genero;
    }
    public void SetGenero(string genero)
    {
        this.genero = genero;
    }

////////////////////////////////////////////////////////////////
    
    public string GetEspecial()
    {
        return especial;
    }
    public void SetEspecial(string especial)
    {
        this.especial = especial;
    }

////////////////////////////////////////////////////////////////

    public virtual void Status(int vida, int defesa, int ataque, int velocidade, string genero, string especial)
    {
        Console.WriteLine($"");
    }
    public void Status()
        {
            Console.WriteLine($"vida: {vida}");
            Console.WriteLine($"ataque: {ataque}");
            Console.WriteLine($"defesa: {defesa}");
            Console.WriteLine($"velocidade: {velocidade}");
            Console.WriteLine($"genero: {genero}");
            Console.WriteLine($"especial: {especial}");
            Console.WriteLine("");
        }
    }
}