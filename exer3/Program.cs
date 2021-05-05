using System;

namespace exer3
{
    class Program
    {
        static void Main(string[] args)
        {
            var certo = false;
            Console.WriteLine("Olá usuario, forneça as seguintes informações para o cadastro");

            Console.WriteLine("Seu Nome: ");
            string nome = Console.ReadLine();

            while (nome == "")
            {
                Console.WriteLine("Seu nome foi deixado em branco, preencha novamente");

                Console.WriteLine("Seu Nome: ");
                nome = Console.ReadLine();
            }

            Console.WriteLine("Sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            while (idade > 150)
            {
                Console.WriteLine("Sua idade é invalida, digite novamente uma idade válida");

                Console.WriteLine("Sua idade: ");
                idade = int.Parse(Console.ReadLine());
            }
            while (idade < 0)
            {
                Console.WriteLine("Sua idade é invalida, digite novamente uma idade válida");

                Console.WriteLine("Sua idade: ");
                idade = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Seu salário: ");
            double salário = double.Parse(Console.ReadLine());

            while (salário <= 0)
            {
                Console.WriteLine("Seu salário é inválida, digite novamente um salário válido");

                Console.WriteLine("Seu salário: ");
                salário = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Estado civil (somente com as letras: s - solteiro, c - casado, v - viuvo, d - divorciado):");
            string estadocivil = Console.ReadLine();


            while (certo == false)
            {
                switch (estadocivil)
                {
                    case "s":
                        Console.WriteLine("Cadastro completo");
                        certo = true;
                        break;
                    case "c":
                        Console.WriteLine("Cadastro completo");
                        certo = true;
                        break;
                    case "v":
                        Console.WriteLine("Cadastro completo");
                        certo = true;
                        break;
                    case "d":
                        Console.WriteLine("Cadastro completo");
                        certo = true;
                        break;
                    default:
                        certo = false;
                        Console.WriteLine("Seu estado civil é inválido, digite novamente um estado civil válido");

                        Console.WriteLine("Estado civil (somente com as letras: s - solteiro, c - casado, v - viuvo, d - divorciado):");
                        estadocivil = Console.ReadLine();
                        break;
                }
            }


            Console.WriteLine("Tenha um bom dia.");

        }
    }
}
