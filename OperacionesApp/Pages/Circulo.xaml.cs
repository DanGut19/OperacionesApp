using static Android.Provider.MediaStore.Audio;

namespace OperacionesApp.Pages;

public partial class Circulo : ContentPage
{
	public Circulo()
	{
		InitializeComponent();
	}

    public double N1 { get; private set; }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        try 
        {
            Circulo circulo = new Circulo();

            if (validarCampos()) 
            {
                circulo.N1 = Double.Parse(txtCirculo.Text);

                txtResultado.Text = $"El area del circulo es: {circulo.btnCalcular()}";
            }

        } catch(Exception ex) {
            DisplayAlert("Error", ex.Message, "Aceptar");
        }

    }

    private object btnCalcular()
    {
        return Math.PI * Math.Pow(N1, 2);
    }

    private void btnLimpiar_Clicked(object sender, EventArgs e)
    {
        txtCirculo.Text = "";
        txtResultado.Text = "";
    }

    private bool validarCampos()
    {
        if (txtCirculo.Text == null || txtCirculo.Text == "")
        {
            DisplayAlert("Advertencia", "Primer número en blanco", "Aceptar");
            return false;
        }
        else
        {
            return true;
        }
    }
}