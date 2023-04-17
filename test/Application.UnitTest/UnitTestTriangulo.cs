using Xunit;

namespace Application.UnitTest;

public class UnitTestTriangulo
{


    [Theory]
    [InlineData(3,3,3, 9)]
    [InlineData(2, 2,2, 6)]
    [InlineData(1, 1, 1,3)]
    [InlineData(6, 6,3, 15)]
    [InlineData(12,12,6, 30)]
    public void TestPerimetro(double ladoA, double ladoB,double ladoC, double perimetro)
    {
        // Arrange – Set up

        // Act – Perform
        double resultado = Triangulo.Perimetro(ladoA, ladoB,ladoC);

        // Assert – Verify
        Assert.Equal(perimetro, resultado);
    }

    [Theory]
    [InlineData(1, 2, 1)]
    [InlineData(2, 4, 4)]
    [InlineData(3, 9, 13.50)]
    [InlineData(4, 16, 32)]
    [InlineData(5, 25, 62.50)]
    public void TestArea(double _base, double altura, double area)
    {
        // Arrange – Set up

        // Act – Perform
        double resultado = Triangulo.Area(_base, altura);

        // Assert – Verify
        Assert.Equal(area, resultado);
    }
}