using System;

namespace ExerciciosCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] estudadente = new string[3] { "Bruno", "Lucas", "Noah" };
            int[] idade = new int[3] { 34, 18, 1 };

            string estudadenteMaisVelho = estudadente[0];
            string estudadenteMaisNovo = estudadente[0];

            int maiorIdade = idade[0];
            int menorIdade = idade[0];

            for (var i = 0; i < idade.Length; i++)
            {
                if (maiorIdade < idade[i])
                {
                    maiorIdade = idade[i];
                    estudadenteMaisVelho = estudadente[i];
                }

                if (menorIdade > idade[i])
                {
                    menorIdade = idade[i];
                    estudadenteMaisNovo = estudadente[i];
                }
            }

            Console.WriteLine($"Maior idade {estudadenteMaisVelho} {maiorIdade} anos");
            Console.WriteLine($"Menor idade {estudadenteMaisNovo} {menorIdade} anos");
            Console.ReadKey();

        }

        public static void ImprimeParImparVetor()
        {
            int[] vetor = new int[5] { 1, 2, 3, 4, 5 };
            int[] pares = new int[5];
            int[] impar = new int[5];

            for (var i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 == 0)
                    pares[i] = vetor[i];
                else
                    impar[i] = vetor[i];
            }

            Array.Sort(vetor);
            Array.Sort(pares);
            Array.Sort(impar);

            Console.WriteLine("Vetor em ordem crescente: ");

            foreach (var item in vetor)
                Console.WriteLine(item);

            Console.WriteLine(" ");
            Console.WriteLine("Esses são os pares: ");
            foreach (var par in pares)
            {
                if (par != 0)
                    Console.WriteLine(par);
                else
                    continue;
            }

            Console.WriteLine(" ");
            Console.WriteLine("Esses são os ímpares: ");

            foreach (var imp in impar)
            {
                if (imp != 0)
                    Console.WriteLine(imp);
                else
                    continue;
            }

            Console.ReadKey();
        }
        public static void InverterOrdemVetor()
        {
            int[] vetor = new int[5];

            for (var i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Por favor digite o {i + 1}° número");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("");
            Console.WriteLine("Invertendo a ordem: ");
            Console.WriteLine("");

            for (var i = vetor.Length - 1; i >= 0; i--)
                Console.WriteLine(vetor[i]);

            Console.ReadKey();
        }
    }
}
