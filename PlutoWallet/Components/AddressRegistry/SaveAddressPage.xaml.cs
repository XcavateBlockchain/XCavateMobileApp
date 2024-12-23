using System.Text;
using AzeroIdResolver;
using PlutoWallet.Model;
using Substrate.NetApi;

namespace PlutoWallet.Components.AddressRegistry;

public partial class SaveAddressPage : ContentPage
{
    public SaveAddressPage(string addressValue)
    {
        NavigationPage.SetHasNavigationBar(this, false);
        Shell.SetNavBarIsVisible(this, false);

        InitializeComponent();
        viewModel.Address = addressValue;
    }

    private async void OnSaveClicked(System.Object sender, System.EventArgs e)
    {
        Preferences.Set(viewModel.Address, viewModel.NickName);
        await Navigation.PopAsync();
    }

    private async void OnRejectClicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void OnInputChanged(System.Object sender, System.EventArgs e)
    {
        try
        {
            if (viewModel != null)
            {
                Utils.GetPublicKeyFrom((string)viewModel.Address);
                saveButton.IsEnabled = !viewModel.NickName.Equals("");
            }
        }
        catch
        {
            saveButton.IsEnabled = false;
        }
    }
}
