using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace SistemaInventario_Proy1
{
    public partial class FormMovimientos : Form
    {
        string rutaProductos = "productos.json";

        public FormMovimientos()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validar que se haya seleccionado Entrada o Salida
                if (cmbTipo.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione si es Entrada o Salida.", "Advertencia");
                    return;
                }

                string tipoMovimiento = cmbTipo.SelectedItem.ToString();
                string idBuscado = txtIDProducto.Text;
                int cantidadMovimiento = Convert.ToInt32(txtCantidad.Text);
                string referenciaText = txtReferencia.Text;

                // 2. Cargar los productos actuales del archivo JSON
                if (!File.Exists(rutaProductos))
                {
                    MessageBox.Show("Aún no hay productos registrados en el sistema.", "Error");
                    return;
                }

                string json = File.ReadAllText(rutaProductos);
                List<Producto> listaProductos = JsonSerializer.Deserialize<List<Producto>>(json) ?? new List<Producto>();

                // 3. Buscar el producto usando el ID
                Producto productoEncontrado = listaProductos.Find(p => p.IDProducto == idBuscado);

                if (productoEncontrado == null)
                {
                    MessageBox.Show("No se encontró ningún producto con ese ID.", "Error");
                    return;
                }

                // 4. APLICAR HERENCIA Y ACTUALIZAR STOCK
                if (tipoMovimiento == "Entrada")
                {
                    // Usamos la clase hija Entrada
                    Entrada nuevaEntrada = new Entrada();
                    nuevaEntrada.Cantidad = cantidadMovimiento;
                    nuevaEntrada.Fecha = DateTime.Now;
                    nuevaEntrada.Comprobante = referenciaText;

                    // Sumamos al stock
                    productoEncontrado.ActualizarStock(nuevaEntrada.Cantidad);
                }
                else if (tipoMovimiento == "Salida")
                {
                    // Validar que haya suficiente stock antes de restar
                    if (productoEncontrado.ExistenciaActual < cantidadMovimiento)
                    {
                        MessageBox.Show("Stock insuficiente. Solo hay " + productoEncontrado.ExistenciaActual + " unidades.", "Stock Bajo");
                        return;
                    }

                    // Usamos la clase hija Salida
                    Salida nuevaSalida = new Salida();
                    nuevaSalida.Cantidad = cantidadMovimiento;
                    nuevaSalida.Fecha = DateTime.Now;
                    nuevaSalida.Motivo = referenciaText;

                    // Restamos al stock (pasamos el número en negativo)
                    productoEncontrado.ActualizarStock(-nuevaSalida.Cantidad);
                }

                // 5. Guardar la lista de productos actualizada de vuelta al archivo JSON
                string jsonActualizado = JsonSerializer.Serialize(listaProductos);
                File.WriteAllText(rutaProductos, jsonActualizado);

                MessageBox.Show($"¡Movimiento registrado con éxito! El nuevo stock de {productoEncontrado.Nombre} es: {productoEncontrado.ExistenciaActual}", "Éxito");

                // 6. Limpiar pantalla
                txtIDProducto.Clear();
                txtCantidad.Clear();
                txtReferencia.Clear();
                cmbTipo.SelectedIndex = -1; // Limpia el combobox
                txtIDProducto.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, asegúrate de ingresar solo números en la cantidad.", "Error de formato");
            }
        }
    }
}