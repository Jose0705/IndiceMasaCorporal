namespace imc.Gui
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
            PesoEntry.Text = string.Empty;
            EstaturaEntry.Text = string.Empty;
            ImcLabel.Text = string.Empty;
            SituacionNutriocional.Text = string.Empty;
        }

        private void OnCalcularButtonCliked(object sender, EventArgs e)
        {
            decimal peso = Convert.ToDecimal(PesoEntry.Text);
            decimal estatura = Convert.ToDecimal(EstaturaEntry.Text);
            decimal Imc = peso / (estatura * estatura);
            ImcLabel.Text = Imc.ToString("G6");
            SituacionNutriocional.Text = DeterminaEstadoNutricional(Imc);
        }

        private void OnLimpiarButton_Clicked(object sender, EventArgs e)
        {
            PesoEntry.Text = string.Empty;
            EstaturaEntry.Text = string.Empty;
            ImcLabel.Text = string.Empty;
            SituacionNutriocional.Text = string.Empty;
        }

        private decimal IndiceDeMasaCorporal(decimal peso , decimal estatura){
            return peso / (estatura * estatura);
        }
            
        private string DeterminaEstadoNutricional(decimal Imc)
        {
            if ( Imc < 18.5m )
            {

                return "Peso Bajo";


            }  if (Imc < 25.00m)
            {

                return "Peso Normal";

                
            }  if (Imc < 30.00m) 
            {

                return "Sobrepeso";
            
            }  if (Imc < 40)
            {
                return "Obesidad";

            } 
            {

                return "Obecidad Extrema";

            }
        }

    }
}
