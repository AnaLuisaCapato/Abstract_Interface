namespace Ex_1__Abstract_
{
    public class Varejo : Empresa
    {
        public Varejo(string nome, string endereco, string telefone) 
            : base(nome, endereco, telefone)
        {
        }
        public override void RealizarVenda()
        {
            Console.WriteLine("Vendendo produtos...");
        }
    }
}
