using System;
// NOMBRE :  JOSE LUIS FLORES SAUCEDO MS3
public class IMC
{
    //DATOS DE ENTRA
    double Peso = 0;
    double Estatura = 0;
    double Imc = 0;
    public void Indicedemasa()
    {
        // DATOS QUE SE LE PIDEN AL CLIENTE PARA CALCULAR EL IMC
        Console.WriteLine("Ingrese su peso : ");
        Peso = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese su estatura : ");
        Estatura = double.Parse(Console.ReadLine());
        // CALCULO DEL IMC (INDICE DE MASA CORPORAL)
        Imc = (Peso / (Estatura * Estatura));
    }
    public void Masa()
    {
        //SE MANDA A IMPRIMIR EL IMC
        Console.WriteLine("Su IMC es " + Imc);
    }
    public void Condiciones() {
        // SE REALIZA CADA CONDICION SI IMC ES MENOR QUE 18.5 Y ASI DE MANERA QUE CUMPLA CON LOS PARAMETROS
        if (Imc < 18.5)
        {
            Console.WriteLine("Su clasificacion de su estado nutricional es Bajo");
        }
        else if (Imc >= 18.5 && Imc < 25)
        {
            Console.WriteLine("Su clasificacion de su estado nutricional es Normal");
        }
        else if (Imc >= 25 && Imc < 30)
        {
            Console.WriteLine("Su clasificacion de su estado nutricional es Sobrepeso");
        }
        else if (Imc >= 30 && Imc < 40)
        {
            Console.WriteLine("Su clasificacion de su estado nutricional es Obesidad");
        }
        else if (Imc >= 40)
        {
            Console.WriteLine("Su clasificacion de su estado nutricional es Obesidad Extrema");
        }
    }
    // MAIN PRINCIPAL
    public static void Main(string[] args)
    {
        // SE CREA UN METODO LLAMADO PACIENTE
        IMC paciente = new IMC();
        // SE LLAMAN LOS METOS DE MANERA QUE CUMPLA CON LOS REQUISISTOS
        paciente.Indicedemasa();
        paciente.Masa();
        paciente.Condiciones();
    }
}