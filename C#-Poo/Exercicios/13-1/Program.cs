namespace _13_1;

class Program
{
    static void Main(string[] args)
    { //Classe Base
        Pagamento p = new Pagamento();
        Pagamento pb = new PagamentoBoleto();
        Pagamento pc = new PagamentoCartaoCredito();
        Pagamento pp = new PagamentoPix();
        //Metodos alterados com base na classe Pagamento
        p.ProcessarPagamento(50);
        pb.ProcessarPagamento(50);
        pc.ProcessarPagamento(50);
        pp.ProcessarPagamento(50);
    }
}
