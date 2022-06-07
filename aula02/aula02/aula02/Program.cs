using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2.1) Faça um programa que pergunte ao usuário ano de nascimento e imprima sua idade.

            Console.WriteLine();
            Console.WriteLine("-------------------------------------- Tarefa Idade --------------------------------------\n\n");
            Console.WriteLine("Insira o ano de seu nascimento: ");
            Console.WriteLine();


            int year = int.Parse(Console.ReadLine());
            int momentYear = 2022;

            Console.WriteLine($"\nOlá você possui {momentYear - year} anos de idade!");
            Console.ReadLine();


            // 2.2) Escreva um programa que leia 10 valores inteiros e ao final exiba a soma dos números.
            //SEM TRATAMENTO DE ERRO


            Console.WriteLine();
            Console.WriteLine("-------------------------------------- Tarefa Soma --------------------------------------\n\n");
            Console.WriteLine("Insira 10 ( dez ) em sequencia, separados por ',' números para serem somados.\nExemplo: 2,2,2,2.... ");
            Console.WriteLine();

        
            string[] somar =  Console.ReadLine().Split(',');
            int a = int.Parse(somar[0]), b= int.Parse(somar[1]), c= int.Parse(somar[2]), d= int.Parse(somar[3]),
                e= int.Parse(somar[4]), f= int.Parse(somar[5]), g = int.Parse(somar[6]), h = int.Parse(somar[7]),
                i = int.Parse(somar[8]), j = int.Parse(somar[9]);

            Console.WriteLine();
            Console.WriteLine($"A soma dos números digitados é :  {a+b+c+d+e+f+g+h+i+j}");

            Console.ReadLine();

            /* 2.3) Escreva um programa que leia o número de horas trabalhadas de um funcionário, o valor que recebe por 
             * hora e calcule o salário desse funcionário. A seguir, mostre o número de horas e o salário do funcionário, 
             * com duas casas decimais.
             */

            Console.WriteLine();
            Console.WriteLine("-------------------------------------- Salário --------------------------------------\n\n");
            Console.WriteLine("\nInforme o número de horas trabalhadas ");

            int hours = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme o valor por hora trabalhada, que o usuário recebe. ");

            float wage = float.Parse(Console.ReadLine());

            Console.WriteLine($"Quantidade de horas trabalhadas: {hours}\nSalário final recebido: R$ {(hours * wage).ToString("F2", CultureInfo.InvariantCulture) }");
            Console.ReadLine();


            /* 2.4) Leia um valor inteiro correspondente à idade de uma pessoa e mostre-a em anos, meses e dias.
             * Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias. 
             * Nos casos de teste nunca haverá uma situação que permite 12 meses e alguns dias, como 360, 363 ou 364. 
             * Este é apenas um exercício com objetivo de testar raciocínio matemático simples.
            */

           /* Console.WriteLine();
            Console.WriteLine("-------------------------------------- Idade --------------------------------------\n\n");
            Console.WriteLine("\nInforme sua idade: ");

            int age = int.Parse(Console.ReadLine());
           */


            /* 2.5) Construa um conversor de moedas:
            * Crie um programa que solicite um valor em real ao usuário e converta esse valor, para:
            * DOLAR
            * EURO
            * LIBRA ESTERLINA
            * DÓLAR CANADENSE
            * PESO ARGENTINO
            * PESO CHILENO
            * Para esse exercício você precisará realizar uma pesquisa para saber a cotação de cada moeda em real. 
            * Mostrar o resultado no formato símbolo da moeda e valor, como o exemplo R$ 10,00 para a moeda real.*/

            Console.WriteLine();
            Console.WriteLine("-------------------------------------- Conversor --------------------------------------\n\n");
            Console.WriteLine("\nInforme o valor em R$(real) para ser convertido. ");

            float value = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe para qual moeda deseja realizar a conversão.\n\n Opções:\n 1 para DOLAR\n 2 para LIBRA ESTERLINA\n" +
                " 3 para DÓLAR CANADENSE\n 4 para PESO ARGENTINO\n 5 para PESO CHILENO\n 6 para EURO ");

            int choice = int.Parse(Console.ReadLine());

            float dolar = 4.87f;
            float euro = 5.21f;
            float libra = 6.13f;
            float canadianDollar = 3.89f;
            float argentinianPeso = 0.040f;
            float chileanPeso = 0.0059f;

            if(choice == 1)
            {
                Console.WriteLine($" Valor em real R$ {value.ToString("F2", CultureInfo.InvariantCulture)}\n Valor convertido para Dolar US$ {(value / dolar).ToString("F2",CultureInfo.InvariantCulture)}.");
            }
            else if( choice == 2)
            {
                Console.WriteLine($" Valor em real R$ {value.ToString("F2", CultureInfo.InvariantCulture)}\n Valor convertido para Libras Esterlina £ {(value / libra).ToString("F2", CultureInfo.InvariantCulture)}.");
            }
            else if ( choice == 3)
            {
                Console.WriteLine($" Valor em real R$ {value.ToString("F2", CultureInfo.InvariantCulture)}\n Valor convertido para Dolar Canadense CAD {(value / canadianDollar).ToString("F2", CultureInfo.InvariantCulture)}.");
            }
            else if (choice == 4)
            {
                Console.WriteLine($" Valor em real R$ {value.ToString("F2", CultureInfo.InvariantCulture)}\n Valor convertido para Peso Argentino ARS {(value / argentinianPeso).ToString("F2", CultureInfo.InvariantCulture)}.");
            }
            else if (choice == 5) {
                Console.WriteLine($" Valor em real R$ {value.ToString("F2", CultureInfo.InvariantCulture)}\n Valor convertido para Peso Chileno CLP {(value / chileanPeso).ToString("F2", CultureInfo.InvariantCulture)}.");
            }
            else if ( choice == 6)
            {
                Console.WriteLine($" Valor em real R$ {value.ToString("F2", CultureInfo.InvariantCulture)}\n Valor convertido para Euro € {(value / euro).ToString("F2", CultureInfo.InvariantCulture)}.");
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }

            Console.ReadLine();
        }
    }
}
