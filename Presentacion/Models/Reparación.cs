namespace Presentacion.Models
{
    public class Reparación
    {
        public int IdReparacion { get; set; }
        public int IdMovil { get; set; }
        public int IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        public int IdComponente { get; set; }
        public int IdTrabajador { get; set; }
        public int PrecioReparacion { get;set; }
    }
}
