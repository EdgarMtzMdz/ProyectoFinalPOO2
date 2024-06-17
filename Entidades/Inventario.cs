using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal;

public class Inventario
{
    public Inventario ()
    {

    }

    [Key]
    public int codBarras { get; set; }
    public string nombreProducto { get; set; }
    public int cantProducto { get; set; }
    public int codProveedor {get; set; }
    public int costoProducto { get; set; }
}