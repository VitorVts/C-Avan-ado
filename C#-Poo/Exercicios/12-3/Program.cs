namespace _12_3;

class Program
{
    static void Main(string[] args)
    {
        Produto p = new Produto("celular", 1500, 2);
        ProdutoEletronico pe = new ProdutoEletronico("Notebook", 1500, 10, "lenovo", "12v");

        
        pe.DefinirVoltagem("30V");
        pe.ExibirProdutoEletronico();
    }
}
