namespace Ex_1__Abstract_
{
    public class Empreiteira : Empresa
    {
        public Empreiteira(string nome, string endereco, string telefone) 
            : base(nome, endereco, telefone)
        {
        }
        public override void RealizarVenda()
        {
            Console.WriteLine("Vendendo serviços..."); 
        }
    }
}
