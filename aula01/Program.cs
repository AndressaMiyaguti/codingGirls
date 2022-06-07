using System;

namespace aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elabore um programa que escreve seu nome completo, seu endereço, o CEP e telefone em linhas separadas.
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


            /*Escolha uma mulher famosa na história da tecnologia e implemente um programa que escreve seu nome, 
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




        }

    }
}
