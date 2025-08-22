using System;
using MinhaBiblioteca;

class exercicio2
{
    static int contadorImpar(int[] vetor)
    {
        int contador = 0;
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] % 2 != 0)
            {
                contador++;
            }
        }
        return contador;
    }
   
    static void Main()
    {
        int n;
        Console.WriteLine("Tamanho do vetor:");
        n = int.Parse(Console.ReadLine());
        int[] vetor = new int[n];
        Biblioteca.gerarVetor(vetor);
        Biblioteca.mostrarVetor(vetor);
        int quantImpar = contadorImpar(vetor);
        Console.WriteLine("A quantidade de números ímpares no vetor é: " + quantImpar);
        Console.ReadKey();
    }
}