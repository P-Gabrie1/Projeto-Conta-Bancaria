using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0300Exemplo
{
    public class ContaBancaria
    {
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public string NomeCliente { get; set; }
        public decimal LimiteCredito { get; set; }
        private decimal Saldo;

        public void ImprimirDados()
        {
            Console.WriteLine();
            Console.WriteLine("====================");
            Console.WriteLine("Dados Da Conta Bancaria");
            Console.WriteLine("--------------------");
            Console.WriteLine($"Numero Da Conta: {Numero}");
            Console.WriteLine($"Tipo Da Conta: {Tipo}");
            Console.WriteLine($"Nome Do Cliente: {NomeCliente}");
            Console.WriteLine($"Limite De Credito: {LimiteCredito:c}");
            Console.WriteLine($"Saldo: {Saldo:c}");
            Console.WriteLine("====================");

        }
        public void Depositar(decimal valorDeposito) 
        {
            Saldo += valorDeposito;
        }
        // pega o valor que ja existe e somar mais o valor depositado
        public void Sacar(decimal valorSaque) 
        {

            //Validação para conferir se o valor connfere
          if (Saldo < valorSaque) 
            {
                Console.WriteLine("Não ha saldo suficiente");
            }
            else 
            {
                Saldo -= valorSaque;
            }
        }
    }
}
