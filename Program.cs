using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_estatistica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de número que deseja digitar:");
            try
            {
                int qtdeNumero = int.Parse(Console.ReadLine());

                int[] listaNumeros = new int[qtdeNumero];


                double media = 0;
                int mediana = 0;

                //Media
                for (int x =0; x<qtdeNumero; x++)
                {
                    int n = int.Parse(Console.ReadLine());
                    listaNumeros[x] = n;
                    media += n;
                    
                }
                media = media /qtdeNumero;
                Array.Sort(listaNumeros);


                //Mediana
                if (qtdeNumero % 2 == 0)
                {
                    int m1 = (qtdeNumero / 2);
                    int m2 = m1 + 1;
                    mediana = (listaNumeros[m1] + listaNumeros[m2])/2;

                }
                else
                {
                    int m1 = (qtdeNumero / 2);
                    mediana = listaNumeros[m1];
                }

                //Desvio padrão
                float desvioPadra = 0;
                double[] desvio = new double[listaNumeros.Length];
                for (int x = 0; x < listaNumeros.Length; x++)
                {
                    double valor = listaNumeros[x];
                    double y = valor - media;
                    desvio[x] = Math.Pow(y, 2);
                }

                double somaDesvio = 0;
                for (int x = 0; x < desvio.Length; x++)
                {
                    somaDesvio += desvio[x];
                }
                double desvioSubtracao = somaDesvio / desvio.Length;
                double desvioPadrao = Math.Sqrt(desvioSubtracao);

                //Varicao amostral
                double variancaAmostral = desvioPadrao * desvioPadrao;

                //coeficiente de variação 
                double coeficienteVariacao = (desvioPadrao / media) * 100;

                Console.WriteLine($"Média: {media}");
                Console.WriteLine($"Mediana: {mediana}");
                Console.WriteLine($"Desvio Padrâo: {desvioPadrao}");
                Console.WriteLine($"Variança amostral: {variancaAmostral}");
                Console.WriteLine($"Coeficiente de variação : {coeficienteVariacao}%");

                //conjunto de dados é homogêneo ou heterogêneo 
                if (coeficienteVariacao > 30)
                {
                    Console.WriteLine($"Conjunto de dados é heterogêneo");
                }
                else
                {
                    Console.WriteLine($"Conjunto de dados é homogêneo");
                }
                
                Console.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine("Valor inválido");
            }
        }
    }
}
