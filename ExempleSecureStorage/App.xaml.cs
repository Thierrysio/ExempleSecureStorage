using ExempleSecureStorage.Vues;

namespace ExempleSecureStorage;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new StorageVue();
	}
}
