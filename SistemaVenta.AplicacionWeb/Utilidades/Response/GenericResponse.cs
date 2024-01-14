namespace SistemaVenta.AplicacionWeb.Utilidades.Response
{
    public class GenericResponse<TObjetct>
    {
        public bool Estado { get; set; }

        public string? Mensaje { get; set; }

        public TObjetct? Objeto { get; set; }

        public List<TObjetct>? ListaObjeto { get; set; }
    }
}
