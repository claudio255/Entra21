int indice = 0; string maiorNome = ""; int idade = 0; double menorPeso = 0; string sexo = ""; double maiorAltura = 0; int sexoM = 0;
int sexoF = 0; int quantidadeGols = 0; int menorQuantidadeCartoesAmarelos = 0; int menorQuantidadeCartoesVermelhos = 0;
string nomeMaiorPeso = ""; string nomeMenorPeso = ""; double maiorPeso = 0; double menorAltura = 0; string nomeMaiorAltura = "";
string nomeMenorAltura = ""; string menorNome = "";

while (indice < 22)
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
    if(peso > maiorPeso)
    {
        maiorPeso = peso;
        nomeMaiorPeso = nome;
    }
    if(altura > maiorAltura)
    {
        maiorAltura = altura;
        nomeMaiorAltura = nome;
    }
    if(nome.Lenght )

    indice = indice + 1;
}
Console.WriteLine("O jogador com menor peso é: " + nomeMenorPeso + " com um peso de: " + menorPeso);
