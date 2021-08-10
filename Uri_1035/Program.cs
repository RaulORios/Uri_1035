using System;

namespace Uri_1035
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensagem;

            string[] valores = Console.ReadLine().Split(' ');
            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);
            int c = int.Parse(valores[2]);
            int d = int.Parse(valores[3]);


            if (b > c && d > a && c + d > a + b && d > 0 && c > 0 && a % 2 == 0) 
            {
                mensagem = "Valores aceitos";
            }
            else
	        {
                mensagem = "Valores nao aceitos";
            }

            Console.WriteLine(mensagem);

        }
    }
}
