using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int id, string nome, double salario)
        {
            Id = id;
            Name = nome;
            Salary = salario;
        }

        public void AumentarSalario(double porcentagem)
        {
            Salary += Salary * (porcentagem / 100);
        }
        public override string ToString()
        {
            return "Employee info:\n"
                + "Id " + Id
                + ", Name: " + Name
                + ", Salary: $" + Salary.ToString("F2")
                + "\n";
        }
    }
}
