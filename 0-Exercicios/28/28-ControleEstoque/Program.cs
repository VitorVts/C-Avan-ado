namespace _28_ControleEstoque
{
    public class Produto
    {
        public string codigo = "0";
        public string nomeProduto = "";
        public int quantidade = 0;
        public double preco = 0;

        public void AdicionarEstoque()
        {
            Console.Clear();

            int adiciona = 0;
            Console.WriteLine(
                "Atualmente este produto {0} tem {1} em estoque: ",
                nomeProduto,
                quantidade
            );
            do
            {
                Console.WriteLine(
                    "Digite a quantidade a ser adicionada ao estoque atual {0}: ",
                    quantidade
                );
            } while (!int.TryParse(Console.ReadLine(), out adiciona) || adiciona < 0);
            quantidade += adiciona;
            Console.WriteLine("{0} agora tem {1} no estoque", nomeProduto, quantidade);
        }

        public void RemoverEstoque()
        {
            Console.Clear();

            int remove = 0;
            Console.WriteLine(
                "Atualmente este produto {0} tem {1} em estoque: ",
                nomeProduto,
                quantidade
            );
            do
            {
                Console.WriteLine(
                    "Digite a quantidade a ser removida do estoque atual {0}: ",
                    quantidade
                );
            } while (
                !int.TryParse(Console.ReadLine(), out remove) || remove < 0 || remove > quantidade
            );
            quantidade -= remove;
            Console.WriteLine("{0} agora tem {1} no estoque", nomeProduto, quantidade);
        }

        public void ExibirInfo()
        {
            Console.Clear();
            Console.WriteLine("Informações do produto:");
            Console.WriteLine("Código do Produto: {0}", codigo);
            Console.WriteLine("Nome do Produto: {0}", nomeProduto);
            Console.WriteLine("Quantidade em estoque: {0}", quantidade);
            Console.WriteLine("Preço: {0}", preco);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Produto celular = new Produto
            {
                codigo = "1",
                nomeProduto = "iPhone 11",
                quantidade = 1,
                preco = 1500.00
            };
            Produto notebook = new Produto
            {
                codigo = "2",
                nomeProduto = "Lenovo Yoga",
                quantidade = 1,
                preco = 3000.00
            };

            Produto produtoSelect = null;

            Console.Clear();
            Console.WriteLine(
                "Digite o código do produto que deseja gerenciar no Estoque (1 para celular, 2 para notebook): "
            );
            string codigoProduto = Console.ReadLine();

            if (codigoProduto == "1")
            {
                produtoSelect = celular;
            }
            else if (codigoProduto == "2")
            {
                produtoSelect = notebook;
            }
            else
            {
                Console.WriteLine("Digite um código válido.");
                return;
            }

            string option = "";
            do
            {
                Console.WriteLine(
                    "\nDigite (A) para adicionar, (R) para remover, (E) para exibir informações do produto, ou (X) para sair"
                );
                option = Console.ReadLine().ToUpper();
                switch (option)
                {
                    case "A":
                        produtoSelect.AdicionarEstoque();
                        break;
                    case "R":
                        produtoSelect.RemoverEstoque();
                        break;
                    case "E":
                        produtoSelect.ExibirInfo();
                        break;
                    case "X":
                        Console.WriteLine("Saindo do controle de estoque.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            } while (option != "X");
        }
    }
}
