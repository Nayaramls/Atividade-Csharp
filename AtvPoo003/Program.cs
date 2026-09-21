using AtvPoo003;
using System.Globalization;

Produto P =  new Produto();

Console.WriteLine("Entre os daods do produto: ");
Console.Write("Nome : ");
P.Nome = Console.ReadLine();
Console.Write("Preço : ");
P.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.Write("Quantidade no estoque : ");
P.Quantidade = int.Parse(Console.ReadLine());

Console.WriteLine("Dados do produto : " + P);

Console.WriteLine();
Console.WriteLine("Digite o número do produto a ser adicionado ao estoque : ");
int qte = int.Parse(Console.ReadLine());
P.AdicionarProdutos(qte);
Console.WriteLine("Dados atualizados: " + P);

Console.WriteLine();
Console.WriteLine("Digite o número do produto a ser removido ao estoque : ");
qte = int.Parse(Console.ReadLine());
P.RemoverProdutos(qte);
Console.WriteLine("Dados atualizados: " + P);