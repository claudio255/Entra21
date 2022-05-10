int indice = 0; string maiorNome = ""; int idade = 0; double menorPeso = double.MaxValue; string sexo = ""; double maiorAltura = 0; string sexoM = "";
string sexoF = ""; int quantidadeGols = 0; int menorQuantidadeCartoesAmarelos = int.MaxValue; int menorQuantidadeCartoesVermelhos = int.MaxValue;
string nomeMaiorPeso = ""; string nomeMenorPeso = ""; double maiorPeso = 0; double menorAltura = double.MaxValue; string nomeMaiorAltura = "";
string nomeMenorAltura = ""; string menorNome = ""; string nomeMenorCartoesAmarelos = ""; string nomeMaiorCartoesVermelhos = "";
string nomeMaiorCartoesAmarelos = ""; string nomeMenorCartoesVermelhos = ""; int maiorQuantidadeCartoesVermelhos = 0;
int maiorQuantidadeCartoesAmarelos = 0;

while(indice < 4)
{
    Console.WriteLine("Digite o nome do jogador: ");
    string nome = Console.ReadLine();
    Console.WriteLine("Digite a idade do jogador: ");
    idade = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o peso do jogador: ");
    double peso = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite a altura do jogador: ");
    double altura = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite o sexo do jogador: ");
    sexo = Console.ReadLine();
    Console.WriteLine("Digite a quantidade de gols marcados pelo jogador: ");
    quantidadeGols = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite a quantidade de cartões amarelos recebidos pelo jogador: ");
    int quantidadeCartoesAmarelos = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite a quantidadde de cartões vermelhos recebidos pelo jogador: ");
    int quantidadeCartoesVermelhos = Convert.ToInt32(Console.ReadLine());

    if(peso < menorPeso)
    {
        menorPeso = peso;
        nomeMenorPeso = nome;
    }
    if(altura > maiorAltura)
    {
        maiorAltura = altura;
        nomeMaiorAltura = nome;
    }
    if(nome.Length > maiorNome.Length)
    {
        maiorNome = nome;
    }
    if(sexo == "f")
    {
        sexoF = (sexoF + 1);
    }
    if(sexo == "m")
    {
        sexoM = (sexoM + 1);
    }
    if(quantidadeCartoesAmarelos < menorQuantidadeCartoesAmarelos)
    {
        menorQuantidadeCartoesAmarelos = quantidadeCartoesAmarelos;
        nomeMenorCartoesAmarelos = nome;
    }
    if (nome.Length < menorNome.Length)
    {
        menorNome = nome;
    }
    if(peso > maiorPeso)
    {
        maiorPeso = peso;
        nomeMaiorPeso = nome;
    }
    if(quantidadeCartoesVermelhos > maiorQuantidadeCartoesVermelhos)
    {
        maiorQuantidadeCartoesVermelhos = quantidadeCartoesVermelhos;
        nomeMaiorCartoesVermelhos = nome;
    }
    if(quantidadeCartoesAmarelos > maiorQuantidadeCartoesAmarelos)
    {
        maiorQuantidadeCartoesAmarelos = quantidadeCartoesAmarelos;
        nomeMaiorCartoesAmarelos = nome;
    }
    if(quantidadeCartoesVermelhos < menorQuantidadeCartoesVermelhos)
    {
        menorQuantidadeCartoesVermelhos = quantidadeCartoesVermelhos;
        nomeMenorCartoesVermelhos = nome;
    }

    indice = indice + 1;
}
Console.WriteLine("O jogador com o menor peso é: " + nomeMenorPeso + " com um peso de: " + menorPeso);
Console.WriteLine("O jogador com o maior peso é: " + nomeMaiorPeso + " com um pedo de: " + maiorPeso);
Console.WriteLine("O jogador com a maior altura é: " + nomeMaiorAltura + " com uma altura de: " + maiorAltura);
Console.WriteLine("O jogador com o maior nome é: " + maiorNome);
Console.WriteLine("O jogador com o menor nome é: " + menorNome);
Console.WriteLine("A quantidade de jogadores do sexo feminino é: " + sexoF);
Console.WriteLine("A quantidade de jogadores do sexo masculino é " + sexoM);
Console.WriteLine("O jogador com a menor quantidade de cartões amarelos é " + nomeMenorCartoesAmarelos + " com um total de: " + menorQuantidadeCartoesAmarelos + " cartões amarelos");
Console.WriteLine("O jogador com a maior quantidade de cartões amarelos é " + nomeMaiorCartoesAmarelos + " com um total de: " + maiorQuantidadeCartoesAmarelos + " cartões amarelos");
Console.WriteLine("O jogador com a menor quantidade de cartões vermelhos é " + nomeMenorCartoesVermelhos + " com um total de: " + menorQuantidadeCartoesVermelhos + " cartões vermelhos");
Console.WriteLine("O jogador com a maior quantidade de cartões vermelhos é " + nomeMaiorCartoesVermelhos + " com um total de: " + maiorQuantidadeCartoesVermelhos + " cartões vermelhos");