using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HolaMundo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }



        void CambioDeTexto(System.Object sender, System.EventArgs e)
        {

            String txt = Entrada.Text;

            Pizarra.Text = txt;

        }
    }
}
