using System;

namespace ExercíciosDouglas
{
    class Program
    {
        static void Main(string[] args)
        {


            Aluno a1 = new Aluno("Marco", 9.5, 1, 47, 1.75, 1300.00);
            a1.ParImpar();
            a1.MaioDeDezoito();
            Console.WriteLine("O salário atual de {0} é de R${1}", a1.Nome,a1.Salario);
            a1.ReajusteSalario();
            Console.WriteLine("------------------------------------------------------");
            Aluno a2 = new Aluno("Marieta", 9.0, 2, 40, 1.60, 352.00);
            a2.ParImpar();
            a2.MaioDeDezoito();
            Console.WriteLine("O salário atual de {0} é de R${1}", a2.Nome, a2.Salario);
            a2.ReajusteSalario();
            Console.WriteLine("------------------------------------------------------");
            Aluno a3 = new Aluno("Joao", 7.0, 3, 35, 1.95, 258.00);
            a3.ParImpar();
            a3.MaioDeDezoito();
            Console.WriteLine("O salário atual de {0} é de R${1}", a3.Nome, a3.Salario);
            a3.ReajusteSalario();
            Console.WriteLine("------------------------------------------------------");
            Aluno a4 = new Aluno("Tertuliana", 10.0, 4, 38, 1.55, 436.85);
            a4.ParImpar();
            a4.MaioDeDezoito();
            Console.WriteLine("O salário atual de {0} é de R${1}", a4.Nome, a4.Salario);
            a4.ReajusteSalario();
            Console.WriteLine("------------------------------------------------------");
            Aluno a5 = new Aluno("Eustáquio", 8.0, 5, 30, 1.80, 789.80);
            a5.ParImpar();
            a5.MaioDeDezoito();
            Console.WriteLine("O salário atual de {0} é de R${1}", a5.Nome, a5.Salario);
            a5.ReajusteSalario();
            Console.WriteLine("------------------------------------------------------");
            Aluno a6 = new Aluno("Francisco", 6.5, 6, 29, 1.68, 900.00);
            a6.ParImpar();
            a6.MaioDeDezoito();
            Console.WriteLine("O salário atual de {0} é de R${1}", a6.Nome, a6.Salario);
            a6.ReajusteSalario();
            Console.WriteLine("------------------------------------------------------");
            Aluno a7 = new Aluno("Douglas", 2.5, 7, 36, 1.72, 299.00);
            a7.ParImpar();
            a7.MaioDeDezoito();
            Console.WriteLine("O salário atual de {0} é de R${1}", a7.Nome, a7.Salario);
            a7.ReajusteSalario();
            Console.WriteLine("------------------------------------------------------");
            Aluno a8 = new Aluno("Fredegundo", 9.0, 8, 47, 1.63, 1120.95);
            a8.ParImpar();
            a8.MaioDeDezoito();
            Console.WriteLine("O salário atual de {0} é de R${1}", a8.Nome, a8.Salario);
            a8.ReajusteSalario();
            Console.WriteLine("------------------------------------------------------");
            Aluno a9 = new Aluno("Mariana", 6.8, 9, 33, 1.55, 301.95);
            a9.ParImpar();
            a9.MaioDeDezoito();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("O salário atual de {0} é de R${1}", a9.Nome, a9.Salario);
            a9.ReajusteSalario();
            Console.WriteLine("------------------------------------------------------");
            Aluno a10 = new Aluno("Isadora", 10.0, 10, 6, 1.30, 950.10);
            a10.ParImpar();
            a10.MaioDeDezoito();
            Console.WriteLine("O salário atual de {0} é de R${1}", a10.Nome, a10.Salario);
            a10.ReajusteSalario();
            Console.WriteLine("------------------------------------------------------");
            int idadeMedia = (a1.Idade + a2.Idade + a3.Idade + a4.Idade + a5.Idade) / 5;
            Console.WriteLine("A idade média dos cinco primeiros alunos é de {0} anos ", idadeMedia);

            double[] alturas = {a1.Altura,a2.Altura, a3.Altura, a4.Altura, a5.Altura,a6.Altura,a7.Altura,a8.Altura,a9.Altura,a10.Altura };
            string[] nomes = { a1.Nome, a2.Nome, a3.Nome, a4.Nome, a5.Nome, a6.Nome, a7.Nome, a8.Nome, a9.Nome, a10.Nome };
            double maior = a1.Altura;
            double menor = a1.Altura;
            string nomeMaisAlto = a1.Nome;
            string nomeMaisBaixo = a1.Nome;

            for (int i = 0; i< alturas.Length; i++)
            {
                
                if (maior < alturas[i] )
                {
                    maior = alturas[i];
                    nomeMaisAlto = nomes[i];
                }
                if (menor > alturas[i])
                {
                    menor = alturas[i];
                    nomeMaisBaixo = nomes[i]; 
                }
                
            }
            Console.WriteLine("{0} é o mais alto e mede {1} metros ",  nomeMaisAlto, maior.ToString("F2"));
            Console.WriteLine("{0} é o mais baixa e mede {1} metros ", nomeMaisBaixo, menor.ToString("F2"));
        }
    }
}
