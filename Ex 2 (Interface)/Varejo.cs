using System.Text;

namespace Ex_2__Interface_
{
    public class Varejo : Empresa, Ifuncoes
    {
        public Varejo(string nome, string endereco, string telefone)
            : base(nome, endereco, telefone)
        {
        }
        public void RealizarVenda()
        {
            Console.WriteLine("Vendendo produtos...");
        }

        public void ImprimirInfo()
        {
            StringBuilder builder = new();
            builder.AppendLine($"Nome: {Nome}");
            builder.AppendLine($"Telefone: {Telefone}");
            builder.Append($"Endereço: {Endereco}");

            Console.WriteLine(builder.ToString());
        }
    }
}