using CommunityToolkit.Mvvm.ComponentModel;

namespace PlutoWallet.ViewModel
{
    public partial class SaveAddressPageViewModel : ObservableObject //, INotifyPropertyChanged
    {
       
        [ObservableProperty]
        private string address;

        [ObservableProperty]
        private string nickName = "";

        public SaveAddressPageViewModel()
        {

        }
    }
}

