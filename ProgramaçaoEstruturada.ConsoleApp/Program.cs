using System;

namespace ProgramaçaoEstruturada.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sequencia = new int[]
            {
                -5 , 4 , 3, 6, 7 , 9, 40 , 2, 11, 9
            };
            Resposta("A sequencia é : " + string.Join("; ", sequencia) + "\n");
            int MenorNumero = EncontrarMenorNumero(sequencia);
            int MaiorNumero = EncontrarMaiorNumero(sequencia);
            decimal ValorMedio = CalcularMedia(sequencia);
            int[] SequenciaCrescente = SoluçãoSequenciaCrescente(sequencia);
            int[] NumerosNegativos = EncontrarNumerosNegativos(sequencia);
            Resposta($"O maior numero da sequencia é :{MaiorNumero}");
            Resposta($"O menor numero da sequencia é :{MenorNumero}");
            Resposta($"O valor medio da sequencia é :{ValorMedio}");
            Resposta("Os maiores numeros da sequencia são : " + string.Join("; ",SequenciaCrescente));
            Resposta("Os numeros negativos da sequencia são : " + string.Join("; ", NumerosNegativos));
            Console.WriteLine("digite o numero que deseja remover da sequencia: ");
            int remover = Convert.ToInt32(Console.ReadLine());
            RemoçaoDoNumero(ref sequencia, remover);
        }
        static void RemoçaoDoNumero(ref int[] numeros, int NumerosRemovidos)
        {
            int qtdNumeros = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == NumerosRemovidos)
                    qtdNumeros++;
            }
            int[] NovaSequencia = new int[numeros.Length - qtdNumeros];
            int j = 0;
            for (int i = 0;i < numeros.Length; i++)
            {
                if (numeros[i] != NumerosRemovidos)
                {
                    NovaSequencia[j] = NumerosRemovidos;
                    j++;
                }
            }
            numeros = NovaSequencia;
        }
        static int[] EncontrarNumerosNegativos(int[] numeros)
        {
            int qtdNumerosNegativos = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < 0 )
                    qtdNumerosNegativos++;
            }
            int[] NumerosNegativos = new int[qtdNumerosNegativos];
            int j = 0;
            for (int i = 0;i < numeros.Length; i++)
            {
               if (numeros[i] < 0)
                {
                    NumerosNegativos[j] = numeros[i];
                    j++;
                }
            }
            return NumerosNegativos;
        }
        static int[] SoluçãoSequenciaCrescente(int[] numeros)
        {
            Array.Sort(numeros);
            Array.Reverse(numeros);
            int[] SequenciaCrescente = new int[3];
            for (int i = 0; i < SequenciaCrescente.Length; i++)
            {
                SequenciaCrescente[i] = numeros[i];
            }
            return SequenciaCrescente;
        }
        static decimal CalcularMedia(int[] numeros)
        {
            decimal Valortotal = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                Valortotal += numeros[i];
            }
            decimal valorMedio = Valortotal / numeros.Length;
            return valorMedio;
        }
        static void Resposta(string Mensagem)
        {           
            Console.WriteLine(Mensagem);
        }
        static int EncontrarMaiorNumero(int[] numeros)
        {
            int MaiorNumero = int.MinValue;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > MaiorNumero)
                    MaiorNumero = numeros[i];
            }
           return MaiorNumero;
        }
        static int EncontrarMenorNumero(int[] numeros)
        {
            int MenorNumero = int.MaxValue;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < MenorNumero)
                    MenorNumero = numeros[i];
            }
            return MenorNumero;
        }
    }
}
