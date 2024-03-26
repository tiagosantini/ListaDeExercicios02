namespace ListaDeExercicios02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sequencia = new int[16];

            // atribuição de valores pro array
            sequencia[0] = -5;
            sequencia[1] = 3;
            sequencia[2] = 4;
            sequencia[3] = 5;
            sequencia[4] = 9;
            sequencia[5] = 6;
            sequencia[6] = 10;
            sequencia[7] = -2;
            sequencia[8] = 11;
            sequencia[9] = 1;
            sequencia[10] = 2;
            sequencia[11] = 6;
            sequencia[12] = 7;
            sequencia[13] = 8;
            sequencia[14] = 0;
            sequencia[15] = -6;
            sequencia[16] = 11;

            ExibirValoresDaSequencia(sequencia);

            EncontrarMaiorValorDaSequencia(sequencia);

            EncontrarMenorValorDaSequencia(sequencia);

            EncontrarMediaDaSequencia(sequencia);

            EncontrarMaioresValores(sequencia);

            EncontrarValoresNegativos(sequencia);

            RemoverItemDaSequencia(sequencia, 6);

            Console.ReadLine();
        }

        private static void RemoverItemDaSequencia(int[] sequencia, int posicaoParaRemover)
        {
            int[] novoArray = new int[sequencia.Length - 1];

            int contadorItens = 0;

            for (int i = 0; i < sequencia.Length; i++)
            {
                int valorAtual = sequencia[i];
                if (i != posicaoParaRemover)
                {
                    novoArray[contadorItens] = sequencia[i];
                    contadorItens++;
                }
            }

            Console.WriteLine($"\nSequência após remoção: [{string.Join(", ", novoArray)}]");
        }

        static void EncontrarValoresNegativos(int[] sequencia)
        {
            // Encontrar os valores negativos da sequência

            // contar a quantidade de valores negativos
            int contadorValoresNegativos = 0;

            for (int i = 0; i < sequencia.Length; i++)
            {
                int valorAtual = sequencia[i];

                if (valorAtual < 0)
                    contadorValoresNegativos++;
            }

            // obter um array com os valores negativos
            int[] valoresNegativos = new int[contadorValoresNegativos];

            int indiceValoresNegativos = 0;

            for (int i = 0; i < sequencia.Length; i++)
            {
                int valorAtual = sequencia[i];

                if (valorAtual < 0)
                {
                    valoresNegativos[indiceValoresNegativos] = valorAtual;
                    indiceValoresNegativos++;
                }
            }

            Console.WriteLine($"\nValores negativos: [{string.Join(", ", valoresNegativos)}]");
        }

        private static void EncontrarMaioresValores(int[] sequencia)
        {
            // Encontrar os 3 maiores valores da sequência
            int[] copia = new int[sequencia.Length];

            Array.Copy(sequencia, copia, sequencia.Length);

            Array.Sort(copia);

            Array.Reverse(copia);

            Console.WriteLine($"\nOs 3 maior valores são: [{copia[0]}, {copia[1]}, {copia[2]}]");
        }

        private static void EncontrarMediaDaSequencia(int[] sequencia)
        {
            // Encontrar o Valor Médio da sequência
            // somar elementos da sequencia
            decimal soma = 0;

            for (int i = 0; i < sequencia.Length; i++)
            {
                int valorAtual = sequencia[i];
                soma += valorAtual;
            }

            // dividir a soma pela quantidade de valores
            decimal media = soma / sequencia.Length;

            Console.WriteLine("\nValor Médio: " + media);
        }

        private static void EncontrarMenorValorDaSequencia(int[] sequencia)
        {
            // Encontrar o Menor Valor da sequência
            int menorValor = int.MaxValue;

            for (int i = 0; i < sequencia.Length; i++)
            {
                int valorAtual = sequencia[i];

                if (valorAtual < menorValor)
                {
                    menorValor = valorAtual;
                }
            }

            Console.WriteLine("\nMenor valor: " + menorValor);
        }

        private static void EncontrarMaiorValorDaSequencia(int[] sequencia)
        {
            // Encontrar o Maior Valor da sequência
            int maiorValor = int.MinValue;

            for (int i = 0; i < sequencia.Length; i++)
            {
                int valorAtual = sequencia[i];

                if (valorAtual > maiorValor)
                {
                    maiorValor = valorAtual;
                }
            }

            Console.WriteLine("\nMaior valor: " + maiorValor);
        }

        private static void ExibirValoresDaSequencia(int[] sequencia)
        {
            // Mostrar na Tela os valores da sequência

            // forma manual
            //for (int i = 0; i < sequencia.Length; i++)
            //{
            //    Console.Write(sequencia[i] + " ");
            //}

            Console.WriteLine($"Sequência: [{string.Join(", ", sequencia)}]");
        }
    }
}
