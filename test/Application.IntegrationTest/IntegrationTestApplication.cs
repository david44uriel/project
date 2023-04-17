// code .\test\Application.IntegrationTest\IntegrationTestApplication.cs
namespace Application.IntegrationTest;

public class IntegrationTestApplication
{
    [Theory]
    [InlineData(4, 4, 4, 32)]
    [InlineData(5, 6, 5 , 90 )]
    [InlineData(5, 5, 5, 62.5)]
    [InlineData(2, 2, 2, 4)]
    [InlineData(3, 3, 4.5, 13.5)]
    public void TestVolumen(double _base, double altura,double altura2, double volumen)
    {
        // Arrange – Set up
        double area = Triangulo.Area(_base, altura);

        // Act – Perform
        double resultado = PrismaTriangular.Volumen(area, altura);

        // Assert – Verify
        Assert.Equal(resultado, volumen);
    }
}