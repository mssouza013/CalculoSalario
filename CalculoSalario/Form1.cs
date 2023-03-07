namespace CalculoSalario
{
    public partial class frmCalculoDeSalario : Form
    {
        public frmCalculoDeSalario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            txtSalario.Visible = false;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Funcionario func = new Funcionario();

            func.CPF = double.Parse(txtCPF.Text);
            func.Nome = txtNome.Text;
            func.ValorHora = double.Parse(txtValorpHora.Text);
            func.HorasTrab = double.Parse(txtHorasTrab.Text);

            func.CalculaSalario();

            
            txtSalario.Visible = true;
            txtSalario.Text = func.Salario.ToString("n2");
        }
    }
}