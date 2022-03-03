using System;

namespace Algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número do exercicio:");
            Console.WriteLine("1 - Pesquisa Binária");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    int[] numeros = { 1, 3, 7, 9, 11 };
                    PesquisaBinaria(numeros, 3);
                    break; 
                default:
                    break;
            }

        }

        static int? PesquisaBinaria(int[] lista, int numeroASerAchado)
        {

            int baixo = 0;
            int alto = lista.Length - 1;
            int meio = 0;
            int chute = 0;
            while (baixo <= alto)
            {
                meio = (baixo + alto) / 2;
                chute = lista[meio];

                if (chute == numeroASerAchado) 
                    return meio;

                if (chute > numeroASerAchado)
                    alto = meio - 1;
                else
                    baixo = meio + 1;
            }

            return null;
        }
    }
}
