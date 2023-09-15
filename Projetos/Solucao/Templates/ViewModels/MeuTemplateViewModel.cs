using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Templates.ViewModels
{
    public partial class MeuTemplateViewModel : ObservableObject
    {
        [RelayCommand]
        private void VerTermos()
        {
            App.Current.MainPage.DisplayAlert("Clicou!", "Clicou!", "OK");
        }
    }
}
