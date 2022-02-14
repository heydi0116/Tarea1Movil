using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tarea1Movil
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async private void btnSuma_Clicked(object sender, EventArgs e)
        {
            var procs = new Models.resultados
            {
                resul = Convert.ToInt32(this.txtN1.Text) + Convert.ToInt32(this.txtN2.Text)

            };
            var pagina = new Page1();
            pagina.BindingContext = procs;
            await Navigation.PushAsync(pagina);

        }

        async private void btnResta_Clicked(object sender, EventArgs e)
        {
            var procs = new Models.resultados
            {
               resul = Convert.ToInt32(this.txtN1.Text) - Convert.ToInt32(this.txtN2.Text)

            };
            var pagina = new Page1();
            pagina.BindingContext = procs;
            await Navigation.PushAsync(pagina);

        }

        async private void btnDivision_Clicked(object sender, EventArgs e)
        {
            var procs = new Models.resultados
            {
                resul = Convert.ToInt32(this.txtN1.Text) / Convert.ToInt32(this.txtN2.Text)

            };
            var pagina = new Page1();
            pagina.BindingContext = procs;
            await Navigation.PushAsync(pagina);

        }

        async private void btnMultiplicacion_Clicked(object sender, EventArgs e)
        {
            var procs = new Models.resultados
            {
                resul = Convert.ToInt32(this.txtN1.Text) * Convert.ToInt32(this.txtN2.Text)

            };
            var pagina = new Page1();
            pagina.BindingContext = procs;
            await Navigation.PushAsync(pagina);

        }
    }
}
