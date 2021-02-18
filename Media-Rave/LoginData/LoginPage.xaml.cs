using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Media_Rave.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Media-Rave.Login
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    void LoginProceedure(object sender, EventArgs e)
    {
        User user = new User(Entry_Username.Text, Entry_Password.Text)
    if(user.CheckInformation())
            {
        DisplayAlert("Login","Login Success","Oke");
        }
    else{
          DisplayAlert("Login","Login Not Correct, empty username or password.","Oke");
        }
            }

}
}