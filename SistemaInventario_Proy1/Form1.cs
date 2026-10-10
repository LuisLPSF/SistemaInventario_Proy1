namespace SistemaInventario_Proy1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Form formularioActivo = null;

   
        private void AbrirFormularioHijo(Form nuevoFormulario)
        {

            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = nuevoFormulario;
            nuevoFormulario.TopLevel = false; 
            nuevoFormulario.FormBorderStyle = FormBorderStyle.None; 
            nuevoFormulario.Dock = DockStyle.Fill; 

            panelContenedor.Controls.Add(nuevoFormulario);
            panelContenedor.Tag = nuevoFormulario;
            nuevoFormulario.BringToFront();
            nuevoFormulario.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormProductos());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormProveedores());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormMovimientos());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormReportes());
        }
    }
}
