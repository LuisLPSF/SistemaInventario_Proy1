using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace SistemaInventario_Proy1
{
    public partial class FormProveedores : Form
    {
        // Lista en memoria y nombre del archivo exclusivo para proveedores
        List<Proveedor> listaProveedores = new List<Proveedor>();
        string rutaArchivo = "proveedores.json";

        public FormProveedores()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            if (File.Exists(rutaArchivo))
            {
                string json = File.ReadAllText(rutaArchivo);
                listaProveedores = JsonSerializer.Deserialize<List<Proveedor>>(json) ?? new List<Proveedor>();

                dgvProveedores.DataSource = null;
                dgvProveedores.DataSource = listaProveedores;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Instanciar un nuevo proveedor
                Proveedor nuevoProveedor = new Proveedor();

                // Llenar los datos desde las cajas de texto
                nuevoProveedor.IDProveedor = txtID.Text;
                nuevoProveedor.Nombre = txtNombre.Text;
                nuevoProveedor.Contacto = txtContacto.Text;
                nuevoProveedor.ProductosSuministrados = txtProductos.Text;

                // Agregar a la lista y guardar en el archivo JSON
                listaProveedores.Add(nuevoProveedor);
                string json = JsonSerializer.Serialize(listaProveedores);
                File.WriteAllText(rutaArchivo, json);

                // Actualizar la tabla
                dgvProveedores.DataSource = null;
                dgvProveedores.DataSource = listaProveedores;

                MessageBox.Show("¡Proveedor registrado exitosamente!", "Éxito");

                // Limpiar pantalla
                txtID.Clear();
                txtNombre.Clear();
                txtContacto.Clear();
                txtProductos.Clear();
                txtID.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar: " + ex.Message, "Error");
            }
        }
    }
}