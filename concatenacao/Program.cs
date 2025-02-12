string nome = "Wanderson";
string nome1 = "João";
int numero = 5;
double numero1 = 03.10;

string saudacao = "Olá, " + nome + "! Bem-vindo";
string saudacao1 = $"Olá, {nome1}! Bem-vindo";
Console.WriteLine(saudacao);
Console.WriteLine(saudacao1);
Console.WriteLine(numero.GetType());
Console.WriteLine(numero1.GetType());
Console.WriteLine(typeof(int));



string valorTexto = "100";
Console.WriteLine("A variável valorTexto é do tipo:" + valorTexto.GetType());

int numero2 = int.Parse(valorTexto);
Console.WriteLine(numero2);
Console.WriteLine("A variável numeroParse é do tipo: " + numero.GetType());



string valorEmTexto1 = "100";
Console.WriteLine("A variável valorTexto é do tipo:" + valorEmTexto1.GetType());

int numeroConvertido = Convert.ToInt32(valorEmTexto1);
Console.WriteLine(numeroConvertido);
Console.WriteLine("A variável numeroConvertido é do tipo:" + numeroConvertido.GetType());



