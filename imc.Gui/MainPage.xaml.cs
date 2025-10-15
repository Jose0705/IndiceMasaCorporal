using Imc.Model;

namespace imc.Gui
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
            Limpiar();
        }

        private void OnCalcularButtonCliked(object sender, EventArgs e)
        {
            decimal peso = Convert.ToDecimal(PesoEntry.Text);
            decimal estatura = Convert.ToDecimal(EstaturaEntry.Text);
            decimal Imc = IndiceDeMasaCorporalLib.IndiceDeMasaCorporal(peso, estatura);
            ImcLabel.Text = Imc.ToString("G6");
            SituacionNutriocional.Text = IndiceDeMasaCorporalLib.DeterminaEstadoNutricional(Imc);
        }

        private void OnLimpiarButton_Clicked(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            PesoEntry.Text = string.Empty;
            EstaturaEntry.Text = string.Empty;
            ImcLabel.Text = string.Empty;
            SituacionNutriocional.Text = string.Empty;
        }
    }
}
