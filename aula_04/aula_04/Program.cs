using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task01();
            Task02();
            //Task03();
            //Task04();
            //Task05();

        }

        static void Task01()
        {
            /*Crie um programa que solicite a entrada de 10 números pelo usuário, armazenando-os em um vetor, 
             * e então monte outro vetor com os valores do primeiro multiplicados por 5.
             * Exiba os valores dos dois vetores na tela, um em cada linha.*/

            Console.WriteLine("\n-------------------------------------------- Vetor --------------------------------------------\n\n");
            Console.WriteLine(" Infome 10 números para serem multiplados:\n\n ");



            int[] vetor01 = new int[10];
            int[] vetor02 = new int[10];

            int soma = 0;


            for (int i = 0; i < 10; i++)
            {
                Console.Write($"- {i + 1}°) ");
                vetor01[i] = Convert.ToInt16(Console.ReadLine());
                soma += vetor01[i];

                for (int j = 0; j < 10; j++)
                {
                    vetor02[j] = vetor01[j] * 5;

                }
            }
            Console.WriteLine("\n\n Números inseridos :{ " + String.Join(",", vetor01) + " } ");
            Console.WriteLine("\n\n Resultado dos números inseridos multiplicados por 5 : {" + String.Join(",", vetor02) + "}");
            Console.ReadLine();
        }

        static void Task02()
        {
            /*Crie um programa que armazene 10 números digitados pelo usuário em dois vetores: 
             * um somente para números pares, e outro somente para números ímpares. Após, exiba 
             * os valores dos dois vetores na tela, um vetor em cada linha.*/

            Console.WriteLine("\n-------------------------------------------- Pares / Ímpares --------------------------------------------\n\n");
            Console.WriteLine(" Infome 10 números para serem separados entre pares e ímpares:\n\n ");


            //Variável (pairs e odd) para gerar a quantidade do vetor par e ímpar
            int pairs = 0;
            int odd = 0;
            int[] auxiliar = new int[10];


            for (int i = 0; i < 10; i++)
            {
                Console.Write($"- {i + 1}°) ");
                auxiliar[i] = Convert.ToInt16(Console.ReadLine());


                if (auxiliar[i] % 2 == 0)
                {
                    pairs++;
                }
                else
                {
                    odd++;

                }
            }
            //atribuição da quantidade no vetor
            int[] vetorPar = new int[pairs];
            int[] vetorImpar = new int[odd];

            //Variavel para contagem do indice
            int iPar = 0, iImpar = 0;

            for (int i = 0; i < 10; i++)
            {
                if (auxiliar[i] % 2 == 0)
                {

                    vetorPar[iPar++] = auxiliar[i];
                }
                else
                {
                    vetorImpar[iImpar++] = auxiliar[i];
                }
            }



            Console.WriteLine(" Numeros inseridos {" + String.Join(",", auxiliar) + "}");
            Console.WriteLine(" Quantidade de numeros pares :" + pairs);
            Console.WriteLine(" Quantidade de numeros ímpares :" + odd);
            Console.WriteLine($" Os números digitados, foram separados em dois grupos, descritos abaixo\n\n Números pares: {String.Join(",", vetorPar)} \n Números ímpares: {String.Join(",", vetorImpar)}  ");

            Console.ReadLine();


        }
        static void Task03()
        {
            /*Crie um programa que lê 5 palavras e as ordena em um vetor de strings pelo seu tamanho. 
             * Se o tamanho das strings for igual, deve-se manter a ordem inserida pelo usuário.*/

        }

        static void Task04()
        {
            /*                  Jogo Jokenpô
             *Utilizando os conceitos aprendidos até estruturas de repetição, crie um programa que jogue pedra, 
             *papel e tesoura (Jokenpô) com você.
             *Permitir que eu decida quantas rodadas iremos fazer;
             *Ler a minha escolha (Pedra, papel ou tesoura);
             *Decidir de forma aleatória a decisão do computador;
             *Mostrar quantas rodadas cada jogador ganhou;
             *Determinar quem foi o grande campeão de acordo com a quantidade de vitórias de cada um (computador e jogador);
             *Perguntar se o Jogador quer jogar novamente, se sim inicie volte a escolha de quantidade de rodadas, 
             *se não finalize o programa.*/
        }
        static void Task05()
        {
            /*                              Jogo da Velha
             *Crie um algorítimo que possibilite que dua pessoas joguem o jogo da velha e exiba quem foi o vencedor.
             *O tabuleiro é uma matriz de três linhas e três colunas.
             *Dois jogadores escolhem uma marcação cada um, geralmente um círculo (O) e um xis (X).
             *Os jogadores jogam alternadamente, uma marcação por vez, numa célula que esteja vazia.
             *O objetivo é conseguir três círculos ou três xis em linha, quer horizontal, vertical 
             *ou diagonal , e ao mesmo tempo, quando possível, impedir o adversário de ganhar na próxima jogada.
             *Quando um jogador conquista o objetivo ele é o vencedor. Se os dois jogadores jogarem sempre 
             *da melhor forma, o jogo terminará sempre em empate ou seja "Deu a Velha!".*/


        }
    }
}
