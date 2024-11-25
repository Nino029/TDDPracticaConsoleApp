using Xunit;
using ConsoleApp.Models;

public class MaquinaDeCafeTests
{
    private readonly Cafetera cafetera;
    private readonly Vaso vasosPequeno;
    private readonly Vaso vasosMediano;
    private readonly Vaso vasosGrande;
    private readonly Azucarero azucarero;
    private readonly MaquinaDeCafe maquinaDeCafe;

    public MaquinaDeCafeTests()
    {
        cafetera = new Cafetera(50);
        vasosPequeno = new Vaso(5, 10);
        vasosMediano = new Vaso(5, 20);
        vasosGrande = new Vaso(5, 30);
        azucarero = new Azucarero(20);

        maquinaDeCafe = new MaquinaDeCafe(cafetera, vasosPequeno, vasosMediano, vasosGrande, azucarero);
    }

    [Fact]
    public void DeberiaDevolverUnVasoPequeno()
    {
        var vaso = maquinaDeCafe.GetTipoVaso("pequeno");
        Assert.Equal(vasosPequeno, vaso);
    }

    [Fact]
    public void DeberiaDevolverUnVasoMediano()
    {
        var vaso = maquinaDeCafe.GetTipoVaso("mediano");
        Assert.Equal(vasosMediano, vaso);
    }

    [Fact]
    public void DeberiaDevolverUnVasoGrande()
    {
        var vaso = maquinaDeCafe.GetTipoVaso("grande");
        Assert.Equal(vasosGrande, vaso);
    }

    [Fact]
    public void DeberiaDevolverNoHayCafe()
    {
        cafetera.GiveCafe(45);  
        var resultado = maquinaDeCafe.GetVasoDeCafe("pequeno", 1, 2);
        Assert.Equal("No hay Cafe", resultado);
    }

    [Fact]
    public void DeberiaDevolverNoHayAzucar()
    {
        azucarero.GiveAzucar(18);  
        var resultado = maquinaDeCafe.GetVasoDeCafe("pequeno", 1, 3);
        Assert.Equal("No hay Azucar", resultado);
    }

    [Fact]
    public void DeberiaRestarCafe()
    {
        maquinaDeCafe.GetVasoDeCafe("pequeno", 1, 3);
        Assert.Equal(40, cafetera.GetCantidadCafe());
    }

    [Fact]
    public void DeberiaRestarVaso()
    {
        maquinaDeCafe.GetVasoDeCafe("pequeno", 1, 3);
        Assert.Equal(4, vasosPequeno.GetCantidadVasos());
    }

    [Fact]
    public void DeberiaRestarAzucar()
    {
        maquinaDeCafe.GetVasoDeCafe("pequeno", 1, 3);
        Assert.Equal(17, azucarero.GetCantidadAzucar());
    }

    [Fact]
    public void DeberiaDevolverFelicitaciones()
    {
        var resultado = maquinaDeCafe.GetVasoDeCafe("pequeno", 1, 3);
        Assert.Equal("Felicitaciones", resultado);
    }
}
