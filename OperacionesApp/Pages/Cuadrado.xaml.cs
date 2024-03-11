namespace OperacionesApp.Pages;

public partial class Cuadrado : ContentPage
{
    private double N1;

    public Cuadrado()
	{
		InitializeComponent();
	}

    private void BtnCalcular_Clicked(object sender, EventArgs e)
    {
        try 
        {
            Cuadrado cuadrado = new Cuadrado();

            if (ValidarCampos()) 
            {
                cuadrado.N1 = Double.Parse(txtLadoR.Text);

                txtResultado.Text = $"El area del cuadrado es: {cuadrado.BtnCalcular()}";
            }
        } 
        catch(Exception ex) {
            DisplayAlert("Error", ex.Message, "Aceptar");
        }

    }

    private object BtnCalcular()
    {
        return N1 * 4;
    }

    private void BtnLimpiar_Clicked(object sender, EventArgs e)
    {
        txtLadoR.Text = "";
        txtResultado.Text = "";
    }

    private bool ValidarCampos()
    {
        if (txtLadoR.Text == null || txtLadoR.Text == "")
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