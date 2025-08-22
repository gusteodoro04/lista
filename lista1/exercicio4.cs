using System;
using MinhaBiblioteca;

class exercicio4
{
    static int maiorVetor(int[] vetor)
    {
        int maior = vetor[0];
        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i] > maior)
            {
                maior = vetor[i];
            }
        }
        return maior;
    }
   
    static void Main()
    {
        int n;
        Console.WriteLine("Tamanho do vetor:");
        n = int.Parse(Console.ReadLine());
        int[] vetor = new int[n];
        Biblioteca.gerarVetor(vetor);
        Biblioteca.mostrarVetor(vetor);
        int maior = maiorVetor(vetor);
        Console.WriteLine("O maior valor do vetor é: " + maior);
        Console.ReadKey();
    }
}