namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbxNumero1.Text) )
            {
                MessageBox.Show("Por favor, informe o primeiro n�mero!");
            }

            if (String.IsNullOrEmpty(tbxNumero2.Text))
            {
                MessageBox.Show("Por favor, informe o segundo n�mero!");
            }


            double valor1 = Convert.ToDouble(tbxNumero1.Text);
            double valor2 = Convert.ToDouble(tbxNumero2.Text);

            if (rdbtnAdicao.Checked)
            {
                lblResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (rdbtnSubtracao.Checked)
            {
                lblResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (rdbtnMultiplicacao.Checked)
            {
                lblResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else if (rdbtnDivicao.Checked)
            {
                lblResultado.Text = Convert.ToString(valor1 / valor2);
            }
            else
            {
                MessageBox.Show("Selecione uma opera��o matem�tica!");
                // lblResultado.Text = "Selecione uma opera��o matem�tica.";
            }
        }
    }
}