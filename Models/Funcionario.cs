using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula02RH.Models.Enuns;

//Um comentario qualquer para deixar no git (amo minha ex)

namespace Aula02RH.Models
{
    public class Funcionario
    {
        public int Id { get; set; } //prop + enter
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataAdmissão { get; set; }
        public decimal Salario { get; set; }
        public TipoFuncionarioEnum TipoFuncionario { get; set; }

        public void ReajustarSalario()
        {
            Salario = Salario + (Salario * 10 /100);
        }

        public string ExibirPeriodoExperiencia()
        {
            string periodoExperiencia = 
                string.Format("Periodo de Experiência: {0} até {1}", DataAdmissão, DataAdmissão.AddMonths(3));
                return periodoExperiencia;
        }

        public decimal CalcularDescontoVT(decimal percentual)
        {
            decimal desconto = this.Salario * percentual/100;
            return desconto;
        }
    }
}