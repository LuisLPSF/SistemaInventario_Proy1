using System;

namespace SistemaInventario_Proy1
{
    // 1. CLASE PRODUCTO
    public class Producto
    {
        public string IDProducto { get; set; } = "";
        public string Nombre { get; set; } = "";
        public string Categoria { get; set; } = "";
        public double Precio { get; set; }
        public int ExistenciaActual { get; set; }
        public int NivelMinimo { get; set; }

        // Actualiza el inventario automáticamente
        public void ActualizarStock(int cantidad)
        {
            ExistenciaActual += cantidad;
        }
    }

    // 2. CLASE PROVEEDOR
    public class Proveedor
    {
        public string IDProveedor { get; set; } = "";
        public string Nombre { get; set; } = "";
        public string Contacto { get; set; } = "";
        public string ProductosSuministrados { get; set; } = "";
    }

    // 3. CLASE PADRE: MOVIMIENTO
    public class Movimiento
    {
        public string IDMovimiento { get; set; } = "";
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
    }

    // 4. HERENCIA: ENTRADA (Hereda de Movimiento)
    public class Entrada : Movimiento
    {
        public string Comprobante { get; set; } = "";
        public string ProveedorAsociado { get; set; } = "";
    }

    // 5. HERENCIA: SALIDA (Hereda de Movimiento)
    public class Salida : Movimiento
    {
        public string Motivo { get; set; } = "";
    }
}