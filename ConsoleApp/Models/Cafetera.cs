
namespace ConsoleApp.Models
{
    public class Cafetera
    {
        public static List<Cafetera> Cafeteras = new List<Cafetera>(); 
        private int cantidadCafe;

        public Cafetera(int cantidadCafe)
        {
            this.cantidadCafe = cantidadCafe;
            Cafeteras.Add(this); 
        }

        public bool HasCafe(int cantidad)
        {
            return cantidadCafe >= cantidad;
        }

        public void GiveCafe(int cantidad)
        {
            if (HasCafe(cantidad))
            {
                cantidadCafe -= cantidad;
            }
            else
            {
                throw new InvalidOperationException("No hay suficiente café.");
            }
        }

        
        public int GetCantidadCafe()
        {
            return cantidadCafe;
        }
    }
}


