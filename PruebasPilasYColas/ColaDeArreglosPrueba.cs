using pilasycolas;
namespace PruebasPilasYColas;

[TestClass]
public class ColaDeArreglosPrueba
{
    [TestMethod]
    public void PruebaAnadirACola()
    {
        Cola PruebaCola = new ColaDeArreglos(5);
        PruebaCola.AnadirACola(5);
        PruebaCola.AnadirACola(6);
        int esperado;
        esperado = 5;
        int actual;
        actual = PruebaCola.Delante();

        Assert.AreEqual(esperado, actual, "El elemento no es el esperdado.");
    }
    [TestMethod]
    public void PruebaQuitarDeCola()
    {
        Cola PruebaCola = new ColaDeArreglos(5);
        PruebaCola.AnadirACola(5);
        PruebaCola.AnadirACola(6);
        PruebaCola.QuitarDeCola();

        int esperado;
        esperado = 6;
        int actual;
        actual = PruebaCola.Delante();

        Assert.AreEqual(esperado, actual, "El elemento no es el esperdado.");
    }
    [TestMethod]
    public void PruebaDelante()
    {
        Cola PruebaCola = new ColaDeArreglos(5);
        PruebaCola.AnadirACola(5);
        PruebaCola.AnadirACola(6);
        PruebaCola.AnadirACola(7);

        int esperado;
        esperado = 5;
        int actual;
        actual= PruebaCola.Delante();

        Assert.AreEqual(esperado, actual, "El elemento no es el esperado");
    }
    [TestMethod]
    public void PruebaToString()
    {
        Cola PruebaCola = new ColaDeArreglos(5);
        PruebaCola.AnadirACola(5);
        PruebaCola.AnadirACola(6);
        PruebaCola.AnadirACola(7);
        Assert.AreEqual("[5, 6, 7]", PruebaCola.ToString(), "El elemento no es el esperado");
    }
}
