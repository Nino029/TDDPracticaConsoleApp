

namespace ConsoleApp.Models
{
    public class Azucarero
    {
      
            public static List<Azucarero> Azucares = new List<Azucarero>(); 
            private int cantidadAzucar;

            public Azucarero(int cantidadAzucar)
            {
                this.cantidadAzucar = cantidadAzucar;
                Azucares.Add(this); 
            }

            public bool HasAzucar(int cantidad)
            {
                return cantidadAzucar >= cantidad;
            }

            public void GiveAzucar(int cantidad)
            {
                if (HasAzucar(cantidad))
                {
                    cantidadAzucar -= cantidad;
                }
                else
                {
                    throw new InvalidOperationException("No hay suficiente azúcar.");
                }
            }

            
            public int GetCantidadAzucar()
            {
                return cantidadAzucar;
            }
        }
    }


