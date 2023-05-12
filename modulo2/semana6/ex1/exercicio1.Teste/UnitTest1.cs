using exercicio1;

namespace exercicio1.Teste;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestandoSoma()
    {
        List<double> valores = new List<double>() {6, -8, 9.6, 7};
        double resultado = Soma.SomarTodos(valores);
        double resultadoFinal = 6 + (-8) + 9.6 + 7; 

        Assert.AreEqual(resultadoFinal, resultado);
    }
}