// See https://aka.ms/new-console-template for more information
using Aula0300Exemplo;
using System.Data;

//Instanciar um objeto do tipo conta bancaria
ContaBancaria objCB1 = new ContaBancaria();
//Atribuir valores para as propriedades objetos
objCB1.Numero = 123456;
objCB1.Tipo = "Conta corrente";
objCB1.NomeCliente = "João da Silva";
objCB1.LimiteCredito = 10000;






//depositar dinheiro na conta 1
objCB1.Depositar(150);
objCB1.Depositar(678);
objCB1.Depositar(432.65m);
objCB1.Depositar(129);



//Chamar o metodo imprimir dados do objCB1
objCB1.ImprimirDados();

//Criar nova conta

ContaBancaria objCB2 = new ContaBancaria();
objCB2.Numero = 678910;
objCB2.Tipo = "Poupança";
objCB2.NomeCliente = "Maria";
objCB2.LimiteCredito = 20000;

objCB2.Depositar(789);
objCB2.Depositar(1000.01m);
objCB2.Depositar(7560);

objCB2.Sacar(349.01m);

objCB2.ImprimirDados();


//programa caixa eletronico

ContaBancaria objCB3 =new ContaBancaria();
objCB2.Numero = 101010;
objCB2.Tipo = "Conta Corrente";
objCB2.NomeCliente = "Anderson";
objCB2.LimiteCredito = 5000;

int opcao = 0;

do 
{
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - Depositar");
    Console.WriteLine("2 - Sacar");
    Console.WriteLine("3 - Imprimir Dados");
    Console.WriteLine("0 - Sair");

    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao) 
    {
        case 1:
            Console.WriteLine("Digite o valor a depositar");
            decimal vlDepositar = Convert.ToDecimal(Console.ReadLine());
            objCB3.Depositar(vlDepositar);
            break;

        case 2:
            Console.WriteLine("Digite o valor do Saque:");
            decimal vlSaque = Convert.ToDecimal(Console.ReadLine());
            objCB3.Sacar(vlSaque);
            break;

            case 3:
            objCB3.ImprimirDados();
            break;
    }
    Console.WriteLine("Aperte qualquer tecla para continuar....");
    Console.ReadKey();
    Console.Clear();
} while (opcao!=0);