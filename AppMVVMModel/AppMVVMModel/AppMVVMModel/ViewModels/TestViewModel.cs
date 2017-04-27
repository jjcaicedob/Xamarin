using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace AppMVVMModel.ViewModels
{
    class TestViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Nombre { get; set; }

        private string _Mensaje { get; set; }

        public string Mensaje
        {

            get { return _Mensaje; }

            set
            {
                _Mensaje = value;
                OnPropertyChanged();
            }
        }

        public Command IntroduceYourself
        {
            get
            {
                return new Command(() => { Mensaje = $"Mi nombre es {Nombre}"; });
            }
        }

    }
}
