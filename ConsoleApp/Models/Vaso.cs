


namespace ConsoleApp.Models
{
    public class Vaso
    {
        public static List<Vaso> Vasos = new List<Vaso>(); 
        private int cantidadVasos;
        private int contenido;

        public Vaso(int cantidadVasos, int contenido)
        {
            this.cantidadVasos = cantidadVasos;
            this.contenido = contenido;
            Vasos.Add(this); 
        }

        public void SetCantidadVasos(int cantidad)
        {
            cantidadVasos = cantidad;
        }

        public int GetCantidadVasos()
        {
            return cantidadVasos;
        }

        public void SetContenido(int contenido)
        {
            this.contenido = contenido;
        }

        public int GetContenido()
        {
            return contenido;
        }

        public bool HasVasos(int cantidadVasos)
        {
            return this.cantidadVasos >= cantidadVasos;
        }

        public void GiveVasos(int cantidadVasos)
        {
            if (cantidadVasos > this.cantidadVasos)
            {
                throw new InvalidOperationException("No hay suficientes vasos disponibles.");
            }
            this.cantidadVasos -= cantidadVasos;
        }
    }
}
