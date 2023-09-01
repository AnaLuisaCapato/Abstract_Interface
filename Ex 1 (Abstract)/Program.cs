/*Crie uma classe Empresa que possua os dados básicos de uma empresa como propriedades.
Construa um método para imprimir as informações da empresa.
Construa um método abstrato void RealizarVenda()

Crie uma classe Varejo que implemente o método abstrato para imprimir que vende produtos.
Crie uma classe Empreiteira que implemente o método abstrato para imprimir que vende serviços.

Na main, crie um objeto de cada classe, preenchendo as propriedades e invocando os métodos.    */
using Ex_1__Abstract_;

namespace Exerc_1__Abstract_
{
    class Program
    {
        static void Main(string[] args)
        {
            Varejo varejo = new("Store 123", "Av. Paulista, 1000", "(11) 9555-9999");
            
            varejo.ImprimirInfo();
            varejo.RealizarVenda();
            Console.WriteLine();

            Empreiteira empreiteira = new("Storage ABC", "Rua XV de novembro, 2000",
                "(11) 5555-9090");

            empreiteira.ImprimirInfo();
            empreiteira.RealizarVenda();
        }
    }
}