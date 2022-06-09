using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Task_01();
            Task_01();
            Task_02();
            Task_03();
            Task_04();
            Task_05();

        }

        static void Task_01()
        {
            /*  Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monetário. 
             *  A seguir, calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto. 
             *  As notas consideradas são de 100, 50, 20, 10, 5, 2.
             *  Entrada: 576.73
             *  Exemplo de Saída: NOTAS: 5 nota(s) de R$ 100.00 1 nota(s) de R$ 50.00 1 nota(s) de R$ 20.00 0 nota(s)
             *  de R$ 10.00 1 nota(s) de R$ 5.00 0 nota(s) de R$ 2.008
             *  */

            Console.WriteLine("\n---------------------------------- Cédulas ----------------------------------\n\n ");
            Console.Write(" Insira o valor a ser decomposto:");

            float bankNote = float.Parse(Console.ReadLine());
            float value = 0.0f;
            float leftovers;
            float hundred;
            float fifty;
            float twenty;
            float ten;
            float five;
            float two;

            if (bankNote >= 100.00)
            {
                value = bankNote / 100;
                leftovers = bankNote % 100;
                Console.Write($" Obteremos:\n {(int)value} nota(s) de 100.00");
                fifty = leftovers / 50;
                leftovers = leftovers % 50;
                Console.Write($" {(int)fifty} nota(s) de 50.00");
                twenty = leftovers / 20;
                leftovers = leftovers % 20;
                Console.Write($" {(int)twenty} nota(s) de 20.00");
                ten = leftovers / 10;
                leftovers = leftovers % 10;
                Console.Write($" {(int)ten} nota(s) de 10.00");
                five = leftovers / 5;
                leftovers = leftovers % 5;
                Console.Write($" {(int)five} nota(s) de 5.00");
                two = leftovers / 2;
                Console.Write($" e {(int)two} nota(s) de 2.00 .");

            }
      
            Console.ReadLine();

        }

        static void Task_02()
        {
            /*
             Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da 
            mensagem “x é o maior”. 
            Exemplo de Entrada 7 14 106
            Exemplo de Saída 106 é o maior
            */
        }

        static void Task_03()
        {
            /*
             Leia 3 valores que são as três notas de um aluno. A seguir, calcule a média do aluno. 
            Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal. Imprima se 
            o aluno foi aprovado ou reprovado considerando a média 7.
            Exemplo de Entrada 7 8 3
            Exemplo de Saída O aluno tirou 6 e foi reprovado.*/
        }

        static void Task_04()
        {
            /*
             Leia 3 valores que são as três notas de um aluno. A seguir, calcule a média do aluno.
             Se a nota for menor que 6.0, deve exibir a nota F.
             Se a nota for de 6.0 até 7.0, deve exibir a nota D.
             Se a nota for entre 7.0 e 8.0, deve exibir a nota C.
             Se a nota for entre 8.0 e 9.0, deve exibir a nota B.
             Se a nota fot entre 9.0 e 10.0, deve exibir um belo de um A.
             Não esqueça de adicionar uma mensagem após a nota, pode ser um simples parabéns para aprovação ou algo mais complexo.
             Exemplo de Entrada 10 8 9
             Exemplo de Saída O aluno tirou A. Parabéns!*/
        }

        static void Task_05()
        {
            /*
             A Blue resolveu dar um aumento de salários a seus funcionários de acordo com os dados abaixo:
            Salário de 0 até 400.00 ganha 15% Salário de 400.01 até 800.00 ganha 12% Salário de 800.01 até 
            1200.00 ganha 10% Salário de 1200.01 até 2000.00 ganha 7% Acima de 2000.00 ganha 4%
            Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor de reajuste 
            ganho e o índice reajustado, em percentual.
            Exemplo de Entrada 400.00
            Exemplo de Saída Novo salario: 460.00 Reajuste ganho: 60.00 Em percentual: 15 %*/
        }
    }
}
