using System;
using System.Globalization;
using System.Collections.Generic;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            //int teste = option ?? 0; lembrar
            Console.WriteLine("ESCOLHA O NUMERO DO EXERCICIO -");
            Console.WriteLine("1 - Triangulo");
            Console.WriteLine("2 - Produto");
            Console.WriteLine("3 - Banco");
            Console.WriteLine("4 - Altura");
            Console.WriteLine("5 - Calc Ref and Out");
            Console.WriteLine("6 - Listas");
            Console.WriteLine("7 - Matriz");

            option = int.Parse(Console.ReadLine());

            

            if (option == 1)
            {
                EscolhaTriangulo();
            }
            else if (option == 2)
            {
                EscolhaProduto();
            }
            else if (option == 3)
            {
                EscolhaBanco();
            }
            else if (option == 4)
            {
                EscolhaAltura();
            }
            else if (option == 5)
            {
                EscolhaCalc();
            }
            else if (option == 6)
            {
                EscolhaLista();
            }
            else if (option == 7)
            {
                EscolhaMatriz();
            }
            else
            {
                Console.WriteLine("Opcao n existe");
            }
        }

        

        static void EscolhaTriangulo()
        {
            Triangulo tX, tY;
            Console.Write("Digite os lados do triangulo separados por espaço: ");
            tX = new Triangulo(Console.ReadLine().Split());
            Console.Write("Digite os lados do triangulo separados por espaço: ");
            tY = new Triangulo(Console.ReadLine().Split());

            Console.WriteLine("A area do primeiro triangulo: " + tX.GetArea().ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("A area do segundo triangulo: " + tY.GetArea().ToString("F3", CultureInfo.InvariantCulture));

            if (tX.GetArea() > tY.GetArea())
            {
                Console.WriteLine("O primeiro triangulo tem a maior area!");
            }
            else
            {
                Console.WriteLine("O segundo triangulo tem a maior area!");
            }
        }

        static void EscolhaProduto()
        {
            Console.WriteLine("Digite o nome do produto:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o valor do produto:");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do produto:");
            int quantidade = int.Parse(Console.ReadLine());
            Produto produto = new Produto(nome, valor, quantidade);

            Console.WriteLine(produto.ToString());
        }
        static void EscolhaBanco()
        {
            Conta conta;
            Console.WriteLine("Entre o número da conta: ");
            int numeroAcc = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre o titular da conta: ");
            string titularAcc = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial? (s/n) ");
            string temDepositoInicial = Console.ReadLine();
            if (temDepositoInicial == "s" || temDepositoInicial == "S")
            {
                Console.WriteLine("Entre o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new Conta(numeroAcc, titularAcc, depositoInicial);
            }
            else
            {
                conta = new Conta(numeroAcc, titularAcc);
            }

            Console.WriteLine(conta.ToString());

            Console.WriteLine("Entre o valor do depósito: ");
            conta.Deposito(double.Parse(Console.ReadLine()));
            Console.WriteLine(conta.ToString());

            Console.WriteLine("Entre o valor do saque: ");
            conta.Saque(double.Parse(Console.ReadLine()));
            Console.WriteLine(conta.ToString());
        }
        private static void EscolhaAltura()
        {
            double sum = 0;
            Console.WriteLine("Insira quantas alturas: ");
            int quantidade = int.Parse(Console.ReadLine());
            double[] vectAlturas = new double[quantidade];

            Console.WriteLine("Insira as alturas: ");
            for (int i = 0; i < quantidade; i++)
            {
                vectAlturas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                sum += vectAlturas[i];
            }
            Console.WriteLine("A média das alturas é: " + (sum/quantidade).ToString("F2", CultureInfo.InvariantCulture));
        }
        private static void EscolhaCalc()
        {
            double valueOut;

            Console.WriteLine("Digite um numero para Ref: ");
            double valueRef = double.Parse(Console.ReadLine());
            Calculadora.TripleRef(ref valueRef);
            Console.WriteLine(valueRef);

            Console.WriteLine("Digite um numero para Out: ");
            double valueIn = double.Parse(Console.ReadLine());
            Calculadora.TripleOut(valueIn, out valueOut);
            Console.WriteLine(valueOut);
        }
        private static void EscolhaLista()
        {
            Console.Write("How many employees will be registered: ");
            int tamanhoLista = int.Parse(Console.ReadLine());

            List<Employee> funcionarios = new List<Employee>();
            for (int i = 0; i < tamanhoLista; i++)
            {
                Console.WriteLine("Employee #"+(i+1)+":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionarios.Add(new Employee(id, name, salary));
            }

            Console.Write("Enter the employee that will gave salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = funcionarios.Find(x => x.Id == searchId);
            if (emp != null)
            {
                Console.Write("Enter percentage: ");
                emp.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("This ID does not exist!");
            }
            foreach (Employee obj in funcionarios)
            {
                Console.WriteLine(obj);
            }
        }
        private static void EscolhaMatriz()
        {
            Console.Write("Digite o tamanho da matriz de orden N: ");
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];
            int negatives = 0;

            for (int x = 0; x < n; x++)
            {
                Console.Write("Digite o valor da primeira linha: ");
                string[] linha = Console.ReadLine().Split(" ");
                for (int y = 0; y < n; y++)
                {
                    mat[x, y] = int.Parse(linha[y]);
                }
            }
            Console.WriteLine("Main diagonal:");
            for(int i = 0; i < n; i++)
            {
                Console.Write(mat[i,i]+" ");
            }
            Console.WriteLine();
            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < n; y++)
                {
                    if (mat[x,y] < 0)
                    {
                        negatives++;
                    }
                }
            }
            Console.Write("Negative Numbers = " + negatives);
        }
    }
}
