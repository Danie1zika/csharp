// Array
int[] meuArray = {1, 2, 3, 4, 5};

foreach (int numero in meuArray)
{
    Console.WriteLine(numero);
}

// List
List<string> listaNomes = new List<string> {"Wanderson", "Jeane", "Ryan"};
listaNomes.Add("Maria");

foreach (string nomes in listaNomes)
{
    Console.WriteLine(nomes);
}

// remover

listaNomes.Remove("Jeane");

foreach (string nomes in listaNomes)
{
    Console.WriteLine(nomes);
}

// Conjunto Set

HashSet<int> conjunto = new HashSet<int> {1, 2, 3};
conjunto.Add(4);


foreach (int nomes in conjunto)
{
    Console.WriteLine(nomes);
}

Console.WriteLine("");

conjunto.Add(4);

foreach (int i in conjunto)

{
    Console.WriteLine(i);
}
