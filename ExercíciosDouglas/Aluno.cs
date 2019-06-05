using System;
using System.Collections.Generic;
using System.Text;

namespace ExercíciosDouglas
{
    class Aluno
    {
        private string nome;
        private double nota;
        private int numeroMatricula;
        private int idade;
        private double altura;
        private double salario;

        public Aluno(string nome, double nota, int numeroMatricula, int idade, double altura, double salario)
        {
            this.nome = nome;
            this.nota = nota;
            this.numeroMatricula = numeroMatricula;
            this.idade = idade;
            this.altura = altura;
            this.salario = salario;
        }
        public Aluno()
        {

        }
        public string Nome { get => nome; set => nome = value; }
        public double Nota { get => nota; set => nota = value; }
        public int NumeroMatricula { get => numeroMatricula; set => numeroMatricula = value; }
        public int Idade { get => idade; set => idade = value; }
        public double Altura { get => altura; set => altura = value; }
        public double Salario { get => salario; set => salario = value; }

        
        public void ParImpar()
        {
            if (this.numeroMatricula % 2 == 0)
            {
                Console.WriteLine("Numero da matrícula {0} é Par", this.numeroMatricula);
            }
            else
            {
                Console.WriteLine("Numero da matrícula {0} é Ímpar", this.numeroMatricula);
            }
        }
        public void MaioDeDezoito()
        {
            if(this.idade < 18)
            {
                Console.WriteLine("O Aluno {0} é menor de idade! ", this.nome);
            }
            else
            {
                Console.WriteLine("O Aluno {0} é maior de idade! ", this.nome);
            }
        }
      public void ReajusteSalario()
        {
            if(this.salario <= 300.00)
            {
                this.salario = salario * 1.50;
                Console.WriteLine("Salário até R$ 300,00 recebe aumento de 50% Salario atual {0}", this.salario.ToString("F2"));
            }
            else
            {
                this.salario = salario * 1.30;
                Console.WriteLine("Salário acima de R$ 300,00 recebe aumento de 30%. Salario atual {0}", this.salario.ToString("F2"));
            }
        }
    }
}
