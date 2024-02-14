namespace InterfazGrafica_Ejercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAfp.Clear();
            txtIsr.Clear();
            txtMensaje.Clear();
            txtSfs.Clear();
            txtSueldo.Clear();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            double sfs, afp, isr, sueldo, sueldo_anual, esc1, esc2, esc3, excedente;

            esc1 = 416220.01;
            esc2 = 624329.01;
            esc3 = 867123.01;
            sueldo = double.Parse(txtSueldo.Text);

            sueldo_anual = sueldo * 12;

            sfs = (sueldo * 3.04) / 100;
            afp = (sueldo * 2.87) / 100;

            if (sueldo_anual >= esc1)
            {
                excedente = sueldo_anual - esc1;
                isr = ((excedente * 15) / 100) / 12;
                txtIsr.Text = isr.ToString();
                txtMensaje.Text = "Aplica";
            }

            else if (sueldo_anual >= esc2)
            {
                excedente = sueldo_anual - esc2;
                isr = ((excedente * 20) / 100) / 12;
                txtIsr.Text = isr.ToString();
                txtMensaje.Text = "Aplica";
            }

            else if (sueldo_anual >= esc3)
            {
                excedente = sueldo_anual - esc3;
                isr = ((excedente * 25) / 100) / 12;
                txtIsr.Text = isr.ToString();
                txtMensaje.Text = "Aplica";
            }

            else
            {

                txtMensaje.Text = "N/A";
                txtIsr.Enabled = false;
            }

            txtSueldo.Text = sueldo.ToString();
            txtSfs.Text = sfs.ToString();
            txtAfp.Text = afp.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}