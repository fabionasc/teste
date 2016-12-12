using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Loja.LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTestLoja
    {
        [TestMethod]
        public void Take()
        {
            int[] numeros = { 5, 4, 3, 1, 9, 8, 2, 7, 6, 0 };
            var resultado = from num in numeros.Take(5) select num;

            int[] teste = { 5, 4, 3, 1, 9 };            
            CollectionAssert.AreEqual(resultado.ToArray(), teste);
        }
        [TestMethod]
        public void Skip()
        {
            int[] numeros = { 5, 4, 3, 1, 9, 8, 2, 7, 6, 0 };
            var resultado = from num in numeros.Take(5).Skip(2) select num;

            int[] teste = {3, 1, 9};
            CollectionAssert.AreEqual(resultado.ToArray(), teste);
        }
    }
}
