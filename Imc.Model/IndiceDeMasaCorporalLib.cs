using System;

namespace Imc.Model
{
    public static class IndiceDeMasaCorporalLib
    {
        public static decimal IndiceDeMasaCorporal(decimal peso, decimal estatura)
        {
            return peso / (estatura * estatura);
        }

        public static string DeterminaEstadoNutricional(decimal Imc)
        {
            if (Imc < 18.5m)
            {

                return "Peso Bajo";


            }
            if (Imc < 25.00m)
            {

                return "Peso Normal";


            }
            if (Imc < 30.00m)
            {

                return "Sobrepeso";

            }
            if (Imc < 40)
            {
                return "Obesidad";

            }
            {

                return "Obecidad Extrema";

            }
        }
    }
}
