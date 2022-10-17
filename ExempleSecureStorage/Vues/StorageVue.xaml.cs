using ExempleSecureStorage.Services;
using ExempleSecureStorage.VueModeles;

namespace ExempleSecureStorage.Vues;

public partial class StorageVue : ContentPage
{
	StorageVueModele vueModele;
    public StorageVue()
	{
		InitializeComponent();
		BindingContext = vueModele = new StorageVueModele();
	}

	private void ButtonValider_Clicked(object sender, EventArgs e)
	{
		 Storage.StockerValeur("MDP",SaisieMdp.Text);
		 this.GetValeur("MDP");
	}

	private async Task GetValeur(string param)
	{
        Mdp.Text = await Storage.RecupererValeur("MDP");
    }
}