

namespace ConsoleApp.Models
{
    public class MaquinaDeCafe
    {
        private Cafetera cafe;
        private Vaso vasosPequenos;
        private Vaso vasosMedianos;
        private Vaso vasosGrandes;
        private Azucarero azucar;

        public MaquinaDeCafe(Cafetera cafe, Vaso vasosPequenos, Vaso vasosMedianos, Vaso vasosGrandes, Azucarero azucar)
        {
            this.cafe = cafe;
            this.vasosPequenos = vasosPequenos;
            this.vasosMedianos = vasosMedianos;
            this.vasosGrandes = vasosGrandes;
            this.azucar = azucar;
        }

        public Vaso GetTipoVaso(string tipoDeVaso)
        {
            return tipoDeVaso.ToLower() switch
            {
                "pequeno" => vasosPequenos,
                "mediano" => vasosMedianos,
                "grande" => vasosGrandes,
                _ => null
            };
        }

        public string GetVasoDeCafe(string tipoDeVaso, int cantidadDeVasos, int cantidadDeAzucar)
        {
            Vaso vaso = GetTipoVaso(tipoDeVaso);
            if (vaso == null || !vaso.HasVasos(cantidadDeVasos))
                return "No hay Vasos";

            if (!cafe.HasCafe(vaso.GetContenido() * cantidadDeVasos))
                return "No hay Cafe";

            if (!azucar.HasAzucar(cantidadDeAzucar))
                return "No hay Azucar";

            vaso.GiveVasos(cantidadDeVasos);
            cafe.GiveCafe(vaso.GetContenido() * cantidadDeVasos);
            azucar.GiveAzucar(cantidadDeAzucar);

            return "Felicitaciones";
        }
    }

}
