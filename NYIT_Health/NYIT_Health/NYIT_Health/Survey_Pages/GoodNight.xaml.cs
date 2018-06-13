using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NYIT_Health
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GoodNight: ContentPage
	{
		public GoodNight ()
		{
			InitializeComponent ();
		}

        void Emoji0Tapped(Object sender, EventArgs args)
        {
            var imageSender = (Image)sender;


        }

        void Emoji1Tapped(Object sender, EventArgs args)
        {
            var imageSender = (Image)sender;


        }

        void Emoji2Tapped(Object sender, EventArgs args)
        {
            var imageSender = (Image)sender;


        }

        void Emoji3Tapped(Object sender, EventArgs args)
        {
            var imageSender = (Image)sender;


        }

        void Emoji4Tapped(Object sender, EventArgs args)
        {
            var imageSender = (Image)sender;

        }

        async void InfoTapped(Object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NYIT_Health.EmojiInfo());

        }
    }
}