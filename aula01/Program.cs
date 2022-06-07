using System;

namespace aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            //  1)  Elabore um programa que escreve seu nome completo, seu endereço, o CEP e telefone em linhas separadas.
/*
            Console.WriteLine("--------------------------------- Formulário Simples" +
                " ---------------------------------");

            Console.WriteLine("Nome completo:");
            string name = Console.ReadLine();

            Console.WriteLine("Meu endereço:");
            string address = Console.ReadLine();

            Console.WriteLine("Meu CEP:");
            string cep = Console.ReadLine(); //Optei por não usar o intParse, devido ao dígito

            Console.WriteLine("Meu telefone:");
            string phone = Console.ReadLine(); //Optei por não usar o intParse, devido ao dígito

            Console.WriteLine("---------------------------------Meu cadastro ---------------------------------");
            Console.WriteLine($" Nome:{name}\n Endereço:{ address }\n CEP: { cep}\n Telefone: {phone}");
            Console.ReadLine();
*/


            /*  2)  Escolha uma mulher famosa na história da tecnologia e implemente um programa que escreve seu nome, 
             * sua formação e uma contribuição feita por ela dentro da tecnologia em linhas separadas.*/

            string iconicWoman = "Grace Hopper";
            string UniversityGraduate = "Doutorado em Matemática";
            string contribution = "No campo da tecnologia, ela foi uma das criadoras do COBOL, uma linguagem de programação para bancos de dados comerciais. +" +
                " Entretanto, sua história mais famosa é a que remonta à popularização do termo “bug” para indicar problemas em software. +" +
                " Além do COBOL, Hopper também criou linguagens de programação para o UNIVAC, o primeiro computador comercial fabricado nos Estados Unidos";


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------------------------------ Uma das mulheres que contribuíram na área de Tecnologia ------------------------------ \n\n");
            
            Console.WriteLine($" Nome: {iconicWoman}\n Grau Acadêmico: {UniversityGraduate}\n" +
                $" Contribuição tecnológica: {contribution}");

            Console.ReadLine();


            //  3)  Elabore um programa que mostre na tela uma letra de música que você gosta, o compositor e o gênero musical em linhas separadas.



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------------------------------ Música escolhida ------------------------------ \n\n");

            string song = "Dancing Queen";
            string band = "ABBA";
            string genre = "Disco/Pop";
            string composer = " Benny Andersson\n Stig Anderson\n Björn Ulvaeus";
            string lyrics = "You can dance\nYou can jive\nHaving the time of your life\nSee that girl\nWatch that scene\nDigging the Dancing Queen" + 
               " \nFriday night and the lights are low\nLooking out for a place to go\nWhere they play the right music\nGetting in the swing\nYou come to look for a King" +
               " \nAnybody could be that guy\nNight is young and the music's high\nWith a bit of rock music\nEverything is fine\nYou're in the mood for a dance" +
               "\nAnd when you get the chance\nYou are the Dancing Queen\nYoung and sweet, only seventeen\nDancing Queen\nFeel the beat from the tambourine, oh yeah!" +
               " \nYou can dance\nYou can jive\nHaving the time of your life\nSee that girl\nWatch that scene\nDigging the Dancing Queen\nYou're a teaser, you turn them on"+
               " \nLeave them burning and then you are gone\nLooking out for another, anyone will do\nYou're in the mood for a dance\nAnd when you get the chance "+
               "\nYou are the Dancing Queen\nYoung and sweet, only seventeen\nDancing Queen\nFeel the beat from the tambourine Oh Yeah!\nYou can dance" +
               "\nYou can jive\nHaving the time of your life\nSee that girl\nWatch that scene\nDigging the Dancing Queen\nDigging the Dancing Queen";

            Console.WriteLine($" Título: ' {song} '\n\n Banda: ' {band} '\n\n Gênero: ' {genre} '\n\n Compositores:\n{composer}\n\nLetra: '{lyrics}'");
            Console.ReadLine();
        }

    }
}
