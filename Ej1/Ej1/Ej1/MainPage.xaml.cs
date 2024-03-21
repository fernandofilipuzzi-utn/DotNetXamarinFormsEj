using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ej1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //string url = "https://www.google.com";// "http://desa-wallet.boleteriadigital.com.ar/validar/default";
            string url = "https://transporteromero.boleteriadigital.com.ar/validar/login?app=true&appVersion=23";
            Navegador.Source = url;
        }
    }
}
