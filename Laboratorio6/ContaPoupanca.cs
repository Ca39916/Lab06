using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6
{
    public class ContaPoupanca : Conta
    {
        //atributos
        private decimal taxaJuros;
        private DateTime dataAniversario;

        //Metodo construtor
        public ContaPoupanca(decimal j, DateTime d, string t) : base(t)//Parametros
        {
            taxaJuros = j; dataAniversario = d;
        }

        public decimal Juros
        {
            get { return taxaJuros; }
            set { taxaJuros = value; }
        }
        public DateTime DataAniversario
        {
            get { return dataAniversario; }
        }
        public void AdicionarRendimento()//Calcula o rendimento 
        {
            DateTime hoje = DateTime.Now;
            if (hoje.Day == dataAniversario.Day && hoje.Month == dataAniversario.Month)
            {
                decimal rendimento = this.Saldo * taxaJuros;
                this.Depositar(rendimento);
            }
        }
        public override string Id
        {
            get { return this.Titular + "(CP)"; }
        }
    }
}
