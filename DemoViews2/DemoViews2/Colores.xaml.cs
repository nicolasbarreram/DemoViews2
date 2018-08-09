using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoViews2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Calores : ContentPage
	{
		public Calores ()
		{
			InitializeComponent ();
		}

        private string ColorToHex(Color color)
        {
            int rojo = (int)(color.R * 255);
            int verde = (int)(color.G * 255);
            int azul = (int)(color.B * 255);
            int alpha = (int)(color.A * 255);
            return $"#{rojo:x2}{verde:x2}{azul:x2}{alpha:x2}";
        }

        void CambiarColor(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            var rojo = sldRojo.Value;
            var azul = sldAzul.Value;
            var verde = sldVerde.Value;
            Color bgColor = new Color(rojo, verde, azul);
            boxColor.BackgroundColor = bgColor;
            lbDisplay.Text = ColorToHex(bgColor);
        }



	}

}