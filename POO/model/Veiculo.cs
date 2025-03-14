using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.model
{
    public class Veiculo
    {
    private string marca;
    private string modelo;
    private int ano;
    protected double velocidadeAtual;
    public Veiculo(string marca, string modelo, int ano, double velocidadeAtual)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.ano = ano;
        this.velocidadeAtual = velocidadeAtual;
    }
    ////////////////////////////////////////////////////////////////
    public string GetMarca()
    {
        return marca;
    }
    public void SetMarca(string marca)
    {
        this.marca = marca;
    }

////////////////////////////////////////////////////////////////
        public string GetModelo()
    {
        return modelo;
    }
    public void SetModelo(string modelo)
    {
        this.modelo = modelo;
    }

////////////////////////////////////////////////////////////////
        public int GetAno()
    {
        return ano;
    }
    public void SetAno(int ano)
    {
        this.ano = ano;
    }

////////////////////////////////////////////////////////////////

        public double GetVelocidadeAtual()
    {
        return velocidadeAtual;
    }
    public void SetVelocidadeAtual(double velocidadeAtual)
    {
        this.velocidadeAtual = velocidadeAtual;
    }

////////////////////////////////////////////////////////////////

    public void Acelerar()
    {
        Console.WriteLine($"{marca} {modelo} ano {ano} está à {velocidadeAtual} km/h.");
    }
    public void Freiar()
    {
        Console.WriteLine($"{marca} {modelo} ano {ano} freia muito rápido.");
    }
    }
}