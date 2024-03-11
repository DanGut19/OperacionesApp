namespace OperacionesApp.Pages;

public partial class Rectangulo : ContentPage
{
    public double N1 { get; private set; }
    public double N2 { get; private set; }


    public Rectangulo()
	{
		InitializeComponent();
	}

    private void BtnLimpiar_Clicked(object sender, EventArgs e)
    {
        txtRectanguloL1.Text = "";
        txtRectanguloL2.Text = "";
        txtResultado.Text = "";
    }

    private void BtnCalcular_Clicked(object sender, EventArgs e)
    {
        try
        {
            Rectangulo rectangulo = new Rectangulo();

            if (ValidarCampos())
            {
                rectangulo.N1 = Double.Parse(txtRectanguloL1.Text);
                rectangulo.N2 = Double.Parse(txtRectanguloL2.Text);

                txtResultado.Text = $"El area del cuadrado es: {rectangulo.BtnCalcular()}";
            }
        }
        catch (Exception ex)
        {
            DisplayAlert("Error", ex.Message, "Aceptar");
        }
    }

    private object BtnCalcular()
    {
        return N1 * N2;
    }

    private bool ValidarCampos()
    {
        if (txtRectanguloL1.Text == null || txtRectanguloL1.Text == "")
        {
            DisplayAlert("Advertencia", "Primer número en blanco", "Aceptar");
            return false;
        }
        else if (txtRectanguloL2.Text == null || txtRectanguloL1.Text == "")
        {
            DisplayAlert("Advertencia", "Segundo número en blanco", "Aceptar");
            return false;
        }
        else
        {
            return true;
        }
    }
}