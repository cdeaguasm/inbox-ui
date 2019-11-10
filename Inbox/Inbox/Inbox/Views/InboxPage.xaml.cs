using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inbox.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inbox.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InboxPage : ContentPage
    {
        public InboxPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}