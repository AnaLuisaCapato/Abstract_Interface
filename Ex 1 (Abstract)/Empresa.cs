using System.Text;

namespace Ex_1__Abstract_
{
    public abstract class Empresa
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

        public void ImprimirInfo()
        {
            StringBuilder builder = new();
            builder.AppendLine($"Nome: {Nome}");
            builder.AppendLine($"Telefone: {Telefone}");
            builder.Append($"Endereço: {Endereco}");

            Console.WriteLine(builder.ToString());
        }
        public abstract void RealizarVenda();
    }
}
