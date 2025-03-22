using pilasycolas;
namespace PruebasPilasYColas;

[TestClass]
public class PilaListasPruebas
{
    [TestMethod]
    public void PushPruebas()
    {
        PilaListas pila = new PilaListas();
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
        PilaListas pila = new PilaListas();
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
        PilaListas pila = new PilaListas();
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
        PilaListas pila = new PilaListas();
        pila.Push(1);
        pila.Push(2);
        pila.Push(3);
        pila.Push(4);
        pila.Push(5);
        Assert.AreEqual("5, 4, 3, 2, 1", pila.ToString());
    }
}
