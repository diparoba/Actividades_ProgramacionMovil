using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Actividades_RobalinoDiegoXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void calc(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DPRB_Calculadora());
        }
    }
}
