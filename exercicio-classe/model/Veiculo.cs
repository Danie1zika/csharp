using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_classe.model
{
    public class Veiculo
    {
    string marca;
    string modelo;
    int ano;
    public Veiculo(string marca, string modelo, int ano)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.ano = ano;
    }

    public void Acelerar()
    {
        Console.WriteLine($"{marca} {modelo} ano {ano} acelera muito rápido.");
    }
    public void Freiar()
    {
        Console.WriteLine($"{marca} {modelo} ano {ano} freia muito rápido.");
    }
    }
}
