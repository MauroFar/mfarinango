namespace mfarinango.Views;

public partial class vHome : ContentPage
{
	public vHome(string usuario)
	{
		InitializeComponent();
		DisplayAlertAsync("Bienvenido", usuario, "Cerrar");
		lblUsuario.Text = "Usuario Conectado " + usuario; 
	}
}