using System.Text;

namespace Ex_2__Interface_
{
    public class Empresa
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public Empresa(string nome, string endereco, string telefone)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;                        
        }             
    }
}
