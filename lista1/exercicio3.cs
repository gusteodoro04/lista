using System;
using MinhaBiblioteca;

class exercicio3
{
    static int menorVetor(int[] vetor)
    {
        int menor = vetor[0];
        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i] < menor)
            {
                menor = vetor[i];
            }
        }
        return menor;
    }
   
    static void Main()
    {
        int n;
        Console.WriteLine("Tamanho do vetor:");
        n = int.Parse(Console.ReadLine());
        int[] vetor = new int[n];
        Biblioteca.gerarVetor(vetor);
        Biblioteca.mostrarVetor(vetor);
        int menor = menorVetor(vetor);
        Console.WriteLine("O menor valor do vetor é: " + menor);
        Console.ReadKey();
    }
}