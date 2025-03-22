using pilasycolas;
namespace PruebasPilasYColas
{
    [TestClass]
    public sealed class PilaArreglosPruebas
    {
        [TestMethod]
        public void PushPruebas()
        {
            PilaArreglos pila = new PilaArreglos(5);
            pila.Push(1);
            pila.Push(2);
            pila.Push(3);
            pila.Push(4);
            pila.Push(5);
            Assert.AreEqual("5, 4, 3, 2, 1", pila.ToString());
        }

        [TestMethod]
        public void PopPruebas()
        {
            PilaArreglos pila = new PilaArreglos(5);
            pila.Push(1);
            pila.Push(2);
            pila.Push(3);
            pila.Push(4);
            pila.Push(5);
            pila.Pop();
            Assert.AreEqual("4, 3, 2, 1", pila.ToString());
        }

        [TestMethod]
        public void TopPruebas()
        {
            PilaArreglos pila = new PilaArreglos(5);
            pila.Push(1);
            pila.Push(2);
            pila.Push(3);
            pila.Push(4);
            pila.Push(5);
            Assert.AreEqual(5, pila.Top());
        }
        [TestMethod]
        public void ToStringPruebas()
        {
            PilaArreglos pila = new PilaArreglos(5);
            pila.Push(1);
            pila.Push(2);
            pila.Push(3);
            pila.Push(4);
            pila.Push(5);
            Assert.AreEqual("5, 4, 3, 2, 1", pila.ToString());
        }
    }
}
