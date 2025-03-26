using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_Personagem.model
{
    public abstract class Personagem
    {
    private int vida;
    private int ataque;
    private int defesa;
    protected int velocidade;
    public Personagem(int vida, int ataque, int defesa, int velocidade)
    {
        this.vida = vida;
        this.ataque = ataque;
        this.defesa = defesa;
        this.velocidade = velocidade;
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

    public virtual void Status(int vida, int defesa, int ataque, int velocidade)
    {
        Console.WriteLine($"{vida} {ataque} {defesa} {velocidade}");
    }
    public abstract void Status()
        {
            Console.WriteLine("");
        }
    }
}