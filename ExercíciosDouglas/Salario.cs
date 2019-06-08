



namespace ExerciciosDouglas
{
    class Salario
    {
        

        public static double Reajuste(double salario)
        {
            if (salario <= 300.00)
            {
                salario = (salario * 1.50);
            }
            else
            {
                salario = (salario * 1.30);
            }
            return salario;
        }
    }
}
