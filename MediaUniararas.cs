namespace CalculoUNIP;
public partial class MediaUniararas : Form
{
    public const int NotadePasse = 5;
    public MediaUniararas() => InitializeComponent();
    private void BTN_CALCULAR_Click(object sender, EventArgs e)
    {
        try
        {
            lbl_valorP1.Text = $"{MSK_P1.Text}+";
            lbl_valorP2.Text = $"(2x {MSK_P2.Text})";

            if (string.IsNullOrEmpty(lbl_valorP1.Text) || string.IsNullOrEmpty(lbl_valorP2.Text))
                throw new Exception("NAO PODE ESTAR VAZIO");

            //converte string em double para fazer o calculo
            double P1 = double.Parse(MSK_P1.Text);
            double P2 = double.Parse(MSK_P2.Text);
            double valorMedia = (P1 + (2 * P2)) / 3;
            //Formata para mostrar duas casas decimais 
            string mostrarMedia = valorMedia.ToString("F2");
            LB_RESULT.Text = $"{mostrarMedia}";

            if (valorMedia >= NotadePasse)
            {
                label_Situacao.Text = " APROVADO ";
                label_Situacao.ForeColor = Color.Green;
            }

            else
            {
                label_Situacao.Text = " REPROVADO ";
                label_Situacao.ForeColor = Color.Red;
            }
        }

        catch (FormatException)
        {//Erro comum causado pelo usuario
            MessageBox.Show($"Preencha corretamente os Campos\n", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        catch (ArgumentNullException)
        {
            MessageBox.Show($"CAMPOS ESTAO VAZIOS\n", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        catch (Exception)
        {
            MessageBox.Show($"Preencha corretamente os Campos\n", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}