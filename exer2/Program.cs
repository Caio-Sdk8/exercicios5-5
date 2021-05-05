using System;

namespace exer2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastro:");

            Console.WriteLine("Insira seu nome de usuario:");
            string nome = Console.ReadLine();

            Console.WriteLine("Insira sua senha:");
            string senha = Console.ReadLine();

            if (nome != senha)
            {
                Console.WriteLine("Muito obrigado, E bem vindo!!!");
            }

            while (senha == nome)
            {
                if (senha == nome)
                {
                    Console.WriteLine("Erro. Seu nome de usuario é igual a senha, tente novamente");

                    Console.WriteLine("Insira seu nome de usuario:");
                    nome = Console.ReadLine();

                    Console.WriteLine("Insira sua senha:");
                    senha = Console.ReadLine();
                }

                if (nome != senha)
            {
                Console.WriteLine("Muito obrigado, E bem vindo!!!");
            }


            }

        }
    }
}
