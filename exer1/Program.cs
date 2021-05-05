using System;

namespace exer1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nota");

            Console.WriteLine("Insira uma nota de 0 a 10.");
            int nota = int.Parse(Console.ReadLine());

            while(nota > 10){
                Console.WriteLine("A nota inserida não é valida, repita o processo novamente.");
                
                Console.WriteLine("Insira uma nota de 0 a 10.");
                nota = int.Parse(Console.ReadLine());
            }
            while(nota < 0){
                Console.WriteLine("A nota inserida não é valida, repita o processo novamente.");

                Console.WriteLine("Insira uma nota de 0 a 10.");
                nota = int.Parse(Console.ReadLine());
            }
        }
    }
}
