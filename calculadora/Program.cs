//Aprendendo hojee Console.Read e Console.ReadLine

/*{Console.Clear();


Console.WriteLine("Iremos trabalhar com uma calculadora, então digite o primeiro numero ai: ");
Double n1 = Double.Parse(Console.ReadLine());
Console.WriteLine("Agora o segundo:");
Double n2 = Double.Parse(Console.ReadLine());
//Double soma = n1 + n2;//
Console.WriteLine("O resultado da soma e " + (n1 + n2));

Console.WriteLine($"A soma entre os numeros e {n1 + n2}");*/

//A ideia desse projeto aqui é aprender os fundamentos do c#, e com ele, criaremos hoje uma calculadora


Console.WriteLine("Bem vindo a nossa calculadora!");
string resp = "nao";
double n1, n2, total;
Console.WriteLine("Digite o primeiro numero:");
/*if (!(double.TryParse(Console.ReadLine(), out n1))) //o OUT é utilizado pra guardar a info dentro de n1
{
    Console.WriteLine("letra pode não po, manda outro numero ai!: ");
}*/
n1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ta, agora digite outro numero: ");
/*if (!(double.TryParse(Console.ReadLine(), out n2)))
{
    Console.WriteLine("Ai nao ne, letra ou simbolo nao rola, tenta de novo: ");
}*/
n2 = double.Parse(Console.ReadLine());
do
{
    Console.WriteLine("Das opções abaixo, digite o numero da operação a ser utilizada:");
    Console.WriteLine("1-Adição");
    Console.WriteLine("2-Subtração");
    Console.WriteLine("3-Multiplicação");
    Console.WriteLine("4-Divisão");
    resp = Console.ReadLine();
    switch (resp)
    {
        case "1":
            n1 = somadois(n1, n2);
            break;
        case "2":
            n1 = sub(n1, n2);
            break;
        case "3":
            n1 = mux(n1, n2);
            break;
        case "4":
            n1 = div(n1, n2);
            break;
        default:
            Console.WriteLine("Opção Inválida");
            break;
    }
    Console.WriteLine($"O resultado do processo de {resp} é: {n1}");
    Console.WriteLine("Deseja adicionar outro número?");
    resp = Console.ReadLine();
    if (resp == "sim" || resp == "SIM")
    {
        Console.WriteLine("Escolha o proximo numero: ");
        n2 = double.Parse(Console.ReadLine());
    }
}
while (resp == "sim" || resp == "SIM");




//Funções da nossa calculadora 

//SOMA
static double somadois(double a, double b)
{ return a + b; }
//SUBTRAÇÃO
static double sub(double a, double b)
{ return a - b; }
//MULTIPLICAÇÃO
static double mux(double a, double b)
{ return a * b; }
//DIVISÃO
static double div(double a, double b)
{ return a / b; }


