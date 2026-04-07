
menu();

static void start(int time)
{
    int currentTime = 0;
    while (currentTime != time)
    {
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);

    }

    Console.WriteLine("StopWatch Terminado");
}

static void menu()
{

    String resp = "1";
    int temp;
    while (resp != "0")
    {
        Console.WriteLine("Escolha em qual tempo tu quer trabalhar: ");
        Console.WriteLine("S = Segundo");
        Console.WriteLine("M = Minuto");
        Console.WriteLine("0 = Sair");
        Console.WriteLine("Ou apenas digite quanto tempo ce gostaria de trabalhar em que 10m e 10 minutos e 1s e 1 segundo: ");
        resp = Console.ReadLine().ToUpper();
        char tipo = char.Parse(resp.Substring(resp.Length - 1, 1));
        if (tipo == 'S' || resp == "SEGUNDO")
        {
            //Console.WriteLine("Quanto tempo tu quer contar? Em SEGUNDOS");
            //temp = int.Parse(Console.ReadLine());
            temp = int.Parse(resp.Substring(0, resp.Length - 1));
            start(temp);
        }
        else if (tipo == 'M' || resp == "MINUTO")
        {
            //Console.WriteLine("Quanto tempo tu quer? Em MINUTOS");
            //temp = int.Parse(Console.ReadLine());
            temp = int.Parse(resp.Substring(0, resp.Length - 1));
            temp = temp * 60;
            start(temp);
        }

        //DICAS 

        //nomevar.Substring (ANALISA TODAS AS SUB PALAVRAS DA VARIÁVEL)
        //nomevar.Lenght (CONTA TODOS OS CARACTER)

    }
}




