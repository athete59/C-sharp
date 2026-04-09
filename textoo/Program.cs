Menu();

static void Menu()
{
    Console.WriteLine("Ola! O que ce quer?");
    Console.WriteLine("1 - Abrir Arquivo");
    Console.WriteLine("2- Criar um arquivo");
    Console.WriteLine("0 - Sair");
    short opcao = short.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            System.Environment.Exit(0);
            break;
        case 1:
            Abrir();
            break;
        case 2:
            editar();
            break;

    }
}

static void Abrir()
{
    Console.WriteLine("Digite qual arq ce quer acessar e onde: ");
    var path = Console.ReadLine();
    using (var arq = new StreamReader(path)) // O using()Garante que abre e fecha arquivo 
    {
        string text = arq.ReadToEnd(); //Ler o texto até o finaL
        Console.WriteLine(text);
    }
    //StreamReader Ler arq
    //StreamWriter Abrir arq

    Console.WriteLine(" ");
    Menu();


}

static void editar()
{
    Console.WriteLine("Digite o que ce quer em seu texto: (Digite ESC para sair) ");
    Console.WriteLine("--------------------------------------");
    String text = " ";
    ConsoleKeyInfo tecla;
    do
    {
        tecla = Console.ReadKey();
        if (tecla.Key == ConsoleKey.Escape)
            break;

        if (tecla.Key == ConsoleKey.Enter)
        {
            text += Environment.NewLine; //Pra adicionar a quebra de linha
            Console.WriteLine();
        }
        else
        {
            text += tecla.KeyChar; //Aqui guarda letra por letra que ce digita
        }

    }
    while (true); //Aqui diz que só rola a repetição enquanto digitamos um caracter diferente de ESC 

    salvar(text);

}

static void salvar(String text)
{
    Console.WriteLine("Onde tu vai salvar o arquivo?");
    var path = Console.ReadLine(); // Cria uma váriavel pra descrever o local do arquivo

    using (var arq = new StreamWriter(path)) // O using()Garante que abre e fecha arquivo 
    {
        arq.Write(text);
    }
    //StreamReader Ler arq
    //StreamWriter Abrir arq

    Console.WriteLine($"Deu bom! {path} Arq salvo");
    Menu();
}