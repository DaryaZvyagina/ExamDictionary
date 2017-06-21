using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace ExamDictionary.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

       /* intent.button.Click += delegate {
       var uri = Android.Net.Uri.Parse("http://www.xamarin.com");
        var intent = new Intent(Intent.ActionView, uri);
       StartActivity(intent);*/
    };
}
