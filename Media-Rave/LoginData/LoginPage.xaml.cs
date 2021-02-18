using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Media-Rave.Login
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Page1 : ContentPage
{
    public Page1()
    {
        InitializeComponent();
    }

    void LoginProceedure(object sender, EventArgs e)
    {
        User user = new User(Entry_Username.Text, Entry_Password.Text)
    }

}
}