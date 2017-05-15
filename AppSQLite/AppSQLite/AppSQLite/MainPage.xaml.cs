using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppSQLite
{
    public partial class MainPage : ContentPage
    {
        Data.UsuarioData objUsuario = new Data.UsuarioData();

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCrearTabla_Clicked(object sender, EventArgs e)
        {
            try
            {
                objUsuario.Crear();

                DisplayAlert("Crear", "Tabla Usuarios Creada con éxito!", "Ok");
            }
            catch (Exception Error)
            {
                DisplayAlert("Crear", "Ocurrió un error: " + Error.Message, "Ok");
            }
        }

        private void btnInsertar_Clicked(object sender, EventArgs e)
        {
            try
            {
                Models.UsuarioModel U = new Models.UsuarioModel();

                U.Nombres = "John " + Guid.NewGuid();
                U.Apellidos = "Caicedo";
                U.CorreoElectronico = "john.caicedo.osc@gmail.com";
                U.Contrasena = "1234";
                U.FechaNacimiento = DateTime.Now;
                U.Sexo = 1;

                objUsuario.Insertar(U);

                DisplayAlert("Insertar", "Usuario insertado con éxito!", "Ok");
            }
            catch (Exception Error)
            {
                DisplayAlert("Crear", "Ocurrió un error: " + Error.Message, "Ok");
            }
        }

        private void btnConsultar_Clicked(object sender, EventArgs e)
        {
            try
            {
                lvUsuarios.ItemsSource = objUsuario.Listar();
                //ItemTemplate = new DataTemplate(typeof(vwMenuViewCell))

                DisplayAlert("Consultar", "Tabla Usuarios leída con éxito!", "Ok");
            }
            catch (Exception Error)
            {
                DisplayAlert("Crear", "Ocurrió un error: " + Error.Message, "Ok");
            }
        }
    }
}
