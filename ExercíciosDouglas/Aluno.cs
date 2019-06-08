using System;




namespace ExercíciosDouglas
{
    class Aluno
    {
        public string Nome { get; set; }
        public double Nota { get; set; }
        public int NumeroMatricula { get; set; }
        public int Idade { get; set; }
        public double Altura { get; set; }
        public double Salario { get; set; }

       

        public Aluno(string nome, double nota, int numeroMatricula, int idade, double altura, double salario)
        {
            Nome = nome;
            Nota = nota;
            NumeroMatricula = numeroMatricula;
            Idade = idade;
            Altura = altura;
            Salario = salario;
            
        }
        public Aluno()
        {

        }
        public void ParImpar()
        {
            if (NumeroMatricula % 2 == 0)
            {
                Console.WriteLine("Numero da matrícula {0} é Par", NumeroMatricula);
            }
            else
            {
                Console.WriteLine("Numero da matrícula {0} é Ímpar", NumeroMatricula);
            }
        }
        public void MaioDeDezoito()
        {
            if(Idade < 18)
            {
                Console.WriteLine("O Aluno {0} é menor de idade! ", Nome);
            }
            else
            {
                Console.WriteLine("O Aluno {0} é maior de idade! ", Nome);
            }


        }

        public override string ToString()
        {
            return
            "O Aluno "
            + Nome + ", "
            + "de Matrícula de Nº"
            + NumeroMatricula + ", "
            + "tem "
            + Idade + " anos, "
            +"com "
            + Altura + " metros, com salário original de "
            + Salario.ToString("F2"); 
        }
    }
}
