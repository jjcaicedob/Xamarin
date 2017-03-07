using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Triangulo : ContentPage
    {
        public Triangulo()
        {
            InitializeComponent();

            btnCalcular.Clicked += BtnCalcular_Clicked;
        }

        private void BtnCalcular_Clicked(object sender, EventArgs e)
        {
            if (entBase.Text == null)
            {
                DisplayAlert("Area del Triangulo", "El valor de la base no puede estar vacio.", "Aceptar");

                return;
            }

            if (entAltura.Text == null)
            {
                DisplayAlert("Area del Triangulo", "El valor de la altura no puede estar vacio.", "Aceptar");

                return;
            }

            double b = double.Parse(entBase.Text);
            double h = double.Parse(entAltura.Text);

            double a = b * h / 2;

            lblResultado.Text = a.ToString();
        }
    }
}
