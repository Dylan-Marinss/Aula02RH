using System;
using Aula02RH.Models;
using Aula02RH.Models.Enuns;

//Um outro comentario qualquer (Ainda amo minha ex fi)

namespace Aula02RH
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Funcionario f = new Funcionario();
            f.Id = 10;
            f.Nome = "Roberto";
            f.Cpf = "12345678910";
            f.DataAdmissão = DateTime.Parse("01/01/2000");
            f.Salario = 1000.00M;
            f.TipoFuncionario = TipoFuncionarioEnum.Aprendiz;

            string mensagem = f.ExibirPeriodoExperiencia();
            System.Console.WriteLine(mensagem);*/

            Funcionario func = new Funcionario();

            System.Console.WriteLine("Digite o Id do funcionário: ");
            func.Id = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o nome do funcionário: ");
            func.Nome = Console.ReadLine();

            System.Console.WriteLine("Digite o CPF: ");
            func.Cpf = Console.ReadLine();

            System.Console.WriteLine("Digite a data de Admissão: ");
            func.DataAdmissão = DateTime.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o Salário: ");
            func.Salario = decimal.Parse(Console.ReadLine());

            System.Console.WriteLine("Escolha o tipo de funcionario (1 - CLT / 2 - Aprendiz): ");
            int opcao = int.Parse(Console.ReadLine());

            func.TipoFuncionario = (opcao ==1 ) ? TipoFuncionarioEnum.CLT : TipoFuncionarioEnum.Aprendiz;

            func.ReajustarSalario();
            decimal valorDescontoVT = func.CalcularDescontoVT(6);


            System.Console.WriteLine("=======================");
            System.Console.WriteLine("Escolha qual informação você quer ver(3 - Salario Reajustado / 4 Desconto VT)");
            int opcao2 = int.Parse(Console.ReadLine());
            if(opcao2 == 3 )
                System.Console.WriteLine($"O salário reajustado é {func.Salario}.\n");
            else
                  System.Console.WriteLine($"O Desconto do VT é {valorDescontoVT}.\n");
            System.Console.WriteLine("=======================");
        }
    }
}