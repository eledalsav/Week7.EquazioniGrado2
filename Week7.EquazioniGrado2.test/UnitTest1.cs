using System;
using Week7.EquazioniGrado2.Core;
using Xunit;

namespace Week7.EquazioniGrado2.test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Equation equazione = new Equation();
            double?[] risultato = equazione.Risolvi(1, -3, 2);
            Assert.True(risultato.Length == 2);
            Assert.Equal(1, risultato[0]);// alternativa Assert.True(risultato[0] == 1);
            Assert.Equal(2, risultato[1]);
        }
    }
}
