using Xunit;

namespace Application.UnitTest;

public class UnitTestPrismaCuadrangular
{
    [Theory]
    [InlineData(16, 4, 64)]
    [InlineData(25, 6, 150)]
    [InlineData(20, 20, 400)]
    [InlineData(15, 20, 300)]
    [InlineData(30, 30, 900)]
    public void TestVolumen(double area, double altura, double volumen)
    {
        // Arrange – Set up


        // Act – Perform
        double resultado = PrismaTriangular.Volumen(area, altura);

        // Assert – Verify
        Assert.Equal(resultado, volumen);
    }
}