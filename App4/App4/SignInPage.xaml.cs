using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App4
{
    public partial class SignInPage : ContentPage
    {
        public SignInPage()
        {
            InitializeComponent();
        }

        async void OnSignUpButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new SignUpPage());
        }

        async void OnSignInButtonClicked(object sender, EventArgs args)
        {
            if (userNameEntry.Text == "samthui7" && passwordEntry.Text == "smisy")
            {
                await Navigation.PushAsync(new Dashboard());
            }
        }
    }
}
