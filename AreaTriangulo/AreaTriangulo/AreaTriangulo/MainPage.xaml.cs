using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AreaTriangulo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btnCalcular.Clicked += BtnCalcular_Clicked;
            btnLimpiar.Clicked += BtnLimpiar_Clicked;
        }

        private void BtnCalcular_Clicked(object sender, EventArgs e)
        {
            if (entBase.Text == null)
            {
                DisplayAlert("Área del Triángulo", "La base es obligatoria.", "Aceptar");

                return;
            }

            if (entAltura.Text == null)
            {
                DisplayAlert("Área del Triángulo", "La altura es obligatoria.", "Aceptar");

                return;
            }

            double b = double.Parse(entBase.Text);
            double h = double.Parse(entAltura.Text);

            double a = b * h / 2;

            lblResultado.Text = "Área: " + a.ToString();
        }

        private void BtnLimpiar_Clicked(object sender, EventArgs e)
        {
            entBase.Text = null;
            entAltura.Text = null;
            lblResultado.Text = null;
        }
    }
}
