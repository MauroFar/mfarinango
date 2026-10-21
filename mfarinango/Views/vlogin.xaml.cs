namespace mfarinango.Views;

public partial class vlogin : ContentPage
{
	String usuario = " ";
	String contrasena = " ";

	public vlogin(string UsuarioNuevo, string ContrasenaNueva)
    {
        InitializeComponent();
		usuario = UsuarioNuevo;
		contrasena = ContrasenaNueva;
    }
    public vlogin()
	{
		InitializeComponent();
	}

	private async void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
		try
		{
			string usuarioIngresado = txtUsuario.Text ?? "";
			string contrasenaIngresada = txtContrasena.Text ?? "";

			if (usuario == usuarioIngresado && contrasena == contrasenaIngresada)
			{
				await Navigation.PushAsync(new Views.vHome(usuario));
			}
			else
			{
				await DisplayAlertAsync("ERROR", "Usuario/Contraseña Incorrectos", "Cerrar");
				txtContrasena.Text = "";
				txtUsuario.Text = "";
			}
		}
		catch (Exception ex)
		{
            await DisplayAlertAsync("ERROR",ex.Message , "Cerrar");
        }

    }

	private async void btnRegistrarUsuario_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Views.vRegistro());
    }

 
}