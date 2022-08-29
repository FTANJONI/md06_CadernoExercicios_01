using System;

namespace md06_CadernoExercicios_01
{
    class Program
    {
        static void Main(string[] args)
        /*
         1. Uma empresa irá dar um aumento de salário aos seus funcionários de
            acordo com a categoria de cada empregado. O aumento seguirá a seguinte
            regra:
            • Funcionários das categorias A, C, F, e H ganharão 10% de aumento sobre o
            salário;
            • Funcionários das categorias B, D, e T ganharão 15% de aumento sobre o
            salário;
            • Funcionários das categorias K e R ganharão 25% de aumento sobre o
            salário;
            O programa deve perguntar se o usuário deseja encerrar a aplicação.
            Números devem ser tratados
         */
        {
            double aum1 = 1.10, aum2 = 1.15, aum3 = 1.25, salario;
            int sair = 1, categoria;


            do
            {
                sair = 1;
                Console.WriteLine("Digite o Salário do Funcionário:");
                salario = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nMenu:\n1.Categorias A, C, F e H\n2.Categorias B, D e T\n3.Categorias K e R");
                categoria = Convert.ToInt32(Console.ReadLine());
                if (categoria == 1)
                {
                    salario = salario * aum1;
                    Console.WriteLine("Salário atualizado com 10% de aumento: R$ {0}", salario.ToString("0.00"));
                }
                else if (categoria == 2)
                {
                    salario = salario * aum2;
                    Console.WriteLine("Salário atualizado com 15% de aumento: R$ {0}", salario.ToString("0.00"));
                }
                else if (categoria == 3)
                {
                    salario = salario * aum3;
                    Console.WriteLine("Salário atualizado com 25% de aumento: R$ {0}", salario.ToString("0.00"));
                }
                else
                {
                    Console.WriteLine("\nOpção inválida:\n");
                    sair = 0;
                }

                Console.WriteLine("\n***Digite ''1'' para fechar o programa ou ''2'' para o próximo cálculo.***\n");
                sair = Convert.ToInt32(Console.ReadLine());

            } while (sair != 1);

        }
    }
}
