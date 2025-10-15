using Imc.Model;
using System;

// NOMBRE : JOSE LUIS FLORES SAUCEDO MS3
public class IMC
{
    // DATOS DE ENTRADA
    decimal Peso = 0;
    decimal Estatura = 0;
    decimal Imc = 0;

    public void Indicedemasa()
    {
        // DATOS QUE SE LE PIDEN AL CLIENTE PARA CALCULAR EL IMC
        Console.WriteLine("Ingrese su peso (kg): ");
        Peso = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese su estatura (m): ");
        Estatura = decimal.Parse(Console.ReadLine());

        // CÁLCULO DEL IMC
        Imc = IndiceDeMasaCorporalLib.IndiceDeMasaCorporal(Peso, Estatura);

        // MUESTRA EL RESULTADO
        Console.WriteLine($"\nSu índice de masa corporal es: {Imc:F2}");
        IndiceDeMasaCorporalLib.DeterminaEstadoNutricional(Imc);
    }

    // MAIN PRINCIPAL
    public static void Main(string[] args)
    {
        // SE CREA UN OBJETO DE LA CLASE IMC
        IMC paciente = new IMC();

        // SE LLAMA AL MÉTODO PARA CALCULAR EL IMC
        paciente.Indicedemasa();

        // ESPERA UNA TECLA PARA SALIR
        Console.WriteLine("\nPresione una tecla para salir...");
        Console.ReadKey();
    }
}
