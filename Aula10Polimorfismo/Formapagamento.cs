namespace Aula10Polimorfismo
{
    public class Formapagamento
    {
        public virtual void EfetuarPagamento() 
        {
            Console.WriteLine("Pagamento efetuado");
        }
    }


    public class Boleto : Formapagamento 
    {
        public Boleto()
        {
            EfetuarPagamento();
        }

        public override void EfetuarPagamento()
        {
            Console.WriteLine("Pagamento efetuado por boleto");
        }
    }

    public class Pix : Formapagamento
    {
        public Pix()
        {
            EfetuarPagamento();
        }

        public override void EfetuarPagamento()
        {
            Console.WriteLine("Pagamento efetuado por pix");
        }
    }

    public class Cartao : Formapagamento
    {
        public Cartao()
        {
            EfetuarPagamento();
        }

        public override void EfetuarPagamento()
        {
            Console.WriteLine("Pagamento efetuado por cartão de crédito");
        }
    }

}
