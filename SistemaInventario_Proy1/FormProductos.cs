using System;
using System.Collections.Generic;
using System.IO;                  // Para manejar archivos físicos
using System.Text.Json;           // Para leer y guardar JSON
using System.Windows.Forms;

namespace SistemaInventario_Proy1
{
    public partial class FormProductos : Form
    {
        // 1. Lista en memoria y nombre del archivo
        List<Producto> listaProductos = new List<Producto>();
        string rutaArchivo = "productos.json";

        public FormProductos()
        {
            InitializeComponent();
            CargarDatos(); // Llama a la carga de datos al abrir la ventana
        }

        // 2. Método para leer el archivo JSON al iniciar
        private void CargarDatos()
        {
            if (File.Exists(rutaArchivo))
            {
                string json = File.ReadAllText(rutaArchivo);
                listaProductos = JsonSerializer.Deserialize<List<Producto>>(json) ?? new List<Producto>();

                // Mostrar en la tabla
                dgvProductos.DataSource = null;
                dgvProductos.DataSource = listaProductos;
            }
        }

        // 3. Botón Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Instanciar un nuevo producto a partir de tu clase
                Producto nuevoProducto = new Producto();

                // Llenar los atributos (Convertimos los textos a números donde corresponde)
                nuevoProducto.IDProducto = txtID.Text;
                nuevoProducto.Nombre = txtNombre.Text;
                nuevoProducto.Categoria = txtCategoria.Text;
                nuevoProducto.Precio = Convert.ToDouble(txtPrecio.Text);
                nuevoProducto.ExistenciaActual = Convert.ToInt32(txtExistencia.Text);
                nuevoProducto.NivelMinimo = Convert.ToInt32(txtMinimo.Text);

                // Agregar a la lista
                listaProductos.Add(nuevoProducto);

                // Guardar en el archivo físico JSON
                string json = JsonSerializer.Serialize(listaProductos);
                File.WriteAllText(rutaArchivo, json);

                // Actualizar la tabla visual
                dgvProductos.DataSource = null;
                dgvProductos.DataSource = listaProductos;

                MessageBox.Show("¡Producto guardado exitosamente en el inventario!", "Éxito");

                // Limpiar cajas de texto
                txtID.Clear();
                txtNombre.Clear();
                txtCategoria.Clear();
                txtPrecio.Clear();
                txtExistencia.Clear();
                txtMinimo.Clear();
                txtID.Focus();
            }
            catch (Exception)
            {
                // Validación por si el usuario ingresa letras en lugar de números
                MessageBox.Show("Error: Verifica que el Precio y las Existencias sean números válidos.", "Error de validación");
            }
        }
    }
}