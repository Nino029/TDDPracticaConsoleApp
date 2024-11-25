

namespace TestProject1
{

    public class TestVaso
    {
        [Fact]
        public void DeberiaDevolverVerdaderoSiExistenVasos()
        {
            Vaso vasosPequenos = new Vaso(2, 10);
            bool resultado = vasosPequenos.HasVasos(1);
            Assert.True(resultado);
        }

        [Fact]
        public void DeberiaDevolverFalsoSiNoExistenVasos()
        {
            Vaso vasosPequenos = new Vaso(1, 10);
            bool resultado = vasosPequenos.HasVasos(2);
            Assert.False(resultado);
        }

        [Fact]
        public void DeberiaRestarCantidadDeVasos()
        {
            Vaso vasosPequenos = new Vaso(5, 10);
            vasosPequenos.GiveVasos(1);  
            Assert.Equal(4, vasosPequenos.GetCantidadVasos());
        }
    }

}

