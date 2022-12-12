using primeiro_proj.Entity;

internal class Program
{
    private static void Main(string[] args)
    {

        int escolhaUsuario = 0;
        List<Produto> produtosLista = new List<Produto>();
        while (escolhaUsuario != 4 && escolhaUsuario < 5)
        {
            Console.WriteLine(@""" Seja bem vindo a loja virtual do seu roberto
                    O que voçê desejar fazer?
                    1 - Cadastrar produto
                    2 - Listar produtos cadastrados
                    3 - Quantidade total de itens no estoque
                    4 - Sair 
                            """);
            if (escolhaUsuario > 4)
                Console.WriteLine("Valor invalido, insira um valor valido");

            escolhaUsuario = Convert.ToInt32(Console.ReadLine());
            switch (escolhaUsuario)
            {
                case 1:
                    Produto produto = new Produto();
                    Console.WriteLine("Digite o nome do produto");
                    produto.Nome = Console.ReadLine();
                    Console.WriteLine($"Digite a quantidade que deseja adicionar do Produto {produto.Nome}");
                    produto.Quantidade = Convert.ToInt32(Console.ReadLine());
                    AdicionarProduto(produtosLista, produto);
                    Console.WriteLine($"{produto.Nome} cadastrado com sucesso!");
                    break;

                case 2:
                    Console.WriteLine("Lista de produtos Cadastrados:\n");
                    foreach (var item in produtosLista)
                    {
                        Console.WriteLine($" Id: {item.Id} -  Nome:{item.Nome} - Quantidade:{item.Quantidade}");
                        Console.WriteLine("---------------------------------------------");
                    }

                    break;

                case 3:
                    var quantidadeTotal = produtosLista.Sum(x => x.Quantidade);
                    Console.WriteLine($"A quantidade total de produtos em estoque é {quantidadeTotal}");
                    break;

                case 4:
                    break;
            }
        }

    }

    private static void AdicionarProduto(List<Produto> produtosLista, Produto produto)
    {
        var item = new Produto();
        item.Id = DateTime.Now.Millisecond;
        item.Nome = produto.Nome;
        item.Quantidade = produto.Quantidade;
        produtosLista.Add(item);
    }
}