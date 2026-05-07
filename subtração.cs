using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o primeiro número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int subtracao = num1 - num2;

        Console.WriteLine("A subtração é: " + subtracao);
    }
}
}
