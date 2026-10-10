using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace SistemaInventario_Proy1
{
    public partial class FormReportes : Form
    {
        // Ruta del archivo y lista en memoria
        string rutaProductos = "productos.json";
        List<Producto> listaCompleta = new List<Producto>();

        public FormReportes()
        {
            InitializeComponent();
            CargarDatos();
        }

        // Leer el archivo JSON una sola vez al abrir la pantalla
        private void CargarDatos()
        {
            if (File.Exists(rutaProductos))
            {
                string json = File.ReadAllText(rutaProductos);
                listaCompleta = JsonSerializer.Deserialize<List<Producto>>(json) ?? new List<Producto>();
            }
            else
            {
                MessageBox.Show("No hay datos de inventario para generar reportes.", "Aviso");
            }
        }

        // BOTÓN 1: Inventario Total
        private void btnTotal_Click(object sender, EventArgs e)
        {
            dgvReportes.DataSource = null;
            dgvReportes.DataSource = listaCompleta; // Muestra todo
        }

        // BOTÓN 2: Stock Bajo
        private void btnStockBajo_Click(object sender, EventArgs e)
        {
            // Filtra productos cuya existencia sea menor o igual al nivel mínimo, pero mayor a 0
            var stockBajo = listaCompleta.FindAll(p => p.ExistenciaActual <= p.NivelMinimo && p.ExistenciaActual > 0);

            dgvReportes.DataSource = null;
            dgvReportes.DataSource = stockBajo;
        }

        // BOTÓN 3: Productos Agotados
        private void btnAgotados_Click(object sender, EventArgs e)
        {
            // Filtra productos cuya existencia sea exactamente 0
            var agotados = listaCompleta.FindAll(p => p.ExistenciaActual == 0);

            dgvReportes.DataSource = null;
            dgvReportes.DataSource = agotados;
        }
    }
}