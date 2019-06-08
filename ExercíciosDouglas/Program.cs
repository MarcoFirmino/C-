using ExerciciosDouglas;
using System;
using System.Globalization;

namespace ExercíciosDouglas
{
    class Program
    {
        static void Main(string[] args)
        {

           
            Aluno a1 = new Aluno("Marco", 9.5, 1, 47, 1.75, 500.00);
            Console.WriteLine(a1);
            a1.ParImpar();
            a1.MaioDeDezoito();
            Console.WriteLine("{0} tem o Sálario reajustado para: {1}", a1.Nome, Salario.Reajuste(a1.Salario).ToString("F2", CultureInfo.InvariantCulture));
            Separador.Separar();

            Aluno a2 = new Aluno("Isadora", 9.5, 2, 6, 1.30, 280.00);
            Console.WriteLine(a2);
            a2.ParImpar();
            a2.MaioDeDezoito();
            Console.WriteLine("{0} tem o Sálario reajustado para: {1}", a2.Nome, Salario.Reajuste(a2.Salario).ToString("F2", CultureInfo.InvariantCulture));
            Separador.Separar();

            Aluno a3 = new Aluno("Douglas", 9.5, 3, 24, 1.70, 650.00);
            Console.WriteLine(a3);
            a3.ParImpar();
            a3.MaioDeDezoito();
            Console.WriteLine("{0} tem o Sálario reajustado para: {1}", a3.Nome, Salario.Reajuste(a3.Salario).ToString("F2", CultureInfo.InvariantCulture));
            Separador.Separar();

            Aluno a4 = new Aluno("Sivaldo", 9.5, 4, 47, 1.68, 200.00);
            Console.WriteLine(a4);
            a4.ParImpar();
            a4.MaioDeDezoito();
            Console.WriteLine("{0} tem o Sálario reajustado para: {1}", a4.Nome, Salario.Reajuste(a4.Salario).ToString("F2", CultureInfo.InvariantCulture));
            Separador.Separar();

            Aluno a5 = new Aluno("Cirleide", 9.5, 5, 47, 1.72, 1500.00);
            Console.WriteLine(a5);
            a5.ParImpar();
            a5.MaioDeDezoito();
            Console.WriteLine("{0} tem o Sálario reajustado para: {1}", a5.Nome, Salario.Reajuste(a5.Salario).ToString("F2", CultureInfo.InvariantCulture));
            Separador.Separar();

            Aluno a6 = new Aluno("Genoveva", 9.5, 6, 51, 1.55, 300.00);
            Console.WriteLine(a6);
            a6.ParImpar();
            a6.MaioDeDezoito();
            Console.WriteLine("{0} tem o Sálario reajustado para: {1}", a6.Nome, Salario.Reajuste(a6.Salario).ToString("F2", CultureInfo.InvariantCulture));
            Separador.Separar();

            Aluno a7 = new Aluno("Epaminondas", 9.5, 7, 68, 1.65, 299.99);
            Console.WriteLine(a7);
            a7.ParImpar();
            a7.MaioDeDezoito();
            Console.WriteLine("{0} tem o Sálario reajustado para: {1}", a7.Nome, Salario.Reajuste(a7.Salario).ToString("F2", CultureInfo.InvariantCulture));
            Separador.Separar();

            Aluno a8 = new Aluno("Jose", 9.5, 8, 30, 1.80, 550.00);
            Console.WriteLine(a1);
            a8.ParImpar();
            a8.MaioDeDezoito();
            Console.WriteLine("{0} tem o Sálario reajustado para: {1}", a8.Nome, Salario.Reajuste(a8.Salario).ToString("F2", CultureInfo.InvariantCulture));
            Separador.Separar();

            Aluno a9 = new Aluno("Francisca", 9.5, 9, 18, 1.75, 200.00);
            Console.WriteLine(a9);
            a9.ParImpar();
            a9.MaioDeDezoito();
            Console.WriteLine("{0} tem o Sálario reajustado para: {1}", a9.Nome, Salario.Reajuste(a9.Salario).ToString("F2", CultureInfo.InvariantCulture));
            Separador.Separar();

            Aluno a10 = new Aluno("Marcio", 9.5, 10, 17, 1.60, 1500.00);
            Console.WriteLine(a10);
            a10.ParImpar();
            a10.MaioDeDezoito();
            Console.WriteLine("{0} tem o Sálario reajustado para: {1}", a10.Nome, Salario.Reajuste(a10.Salario).ToString("F2", CultureInfo.InvariantCulture));
            Separador.Separar();
        }  
           
    }
}
