/* Faça o mesmo exercício aplicando Interfaces.
Crie a classe base para herdar as propriedades porém façam os métodos através de 
implementação de Interface.

Na main, crie uma lista de interface.
Adicione um objeto de cada classe do tipo da interface, preenchendo as propriedades
Invoque os métodos da lista. */

using Ex_2__Interface_;

namespace Exerc_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ifuncoes> empresas = new List<Ifuncoes>();

            Ifuncoes varejo = new Varejo("Store 123", "Av. Paulista, 1000", 
                "(11) 9555-9999");
            Ifuncoes empreiteira = new Empreiteira("Storage ABC", "Rua XV de novembro, 2000",
                "(11) 5555-9090");

            empresas.Add(varejo);
            empresas.Add(empreiteira);

            foreach (var empresa in empresas)
            {
                if (empresa is Ifuncoes info)
                {
                    info.ImprimirInfo();
                }

                if (empresa is Ifuncoes vendas)
                {
                    vendas.RealizarVenda();
                }
                Console.WriteLine();

            } 
        }
    }
}