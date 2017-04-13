namespace Sandro_Malca_Neyra
{
    class Empleado
    {
        public int EmpleadoId { get; set; }

        public string DNI { get; set; }

        public Empleado()
        {

        }

        public Empleado(string dni)
        {
            DNI = dni;
        }
    }
}
