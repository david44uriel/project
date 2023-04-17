namespace Application;

public class Paralelogramo
{
    public static double Perimetro(double lado1, double lado2, double lado3, double lado4)
    {
        double perimetro = lado1 + lado2 + lado3 + lado4;
        return perimetro;
    }
    public static double Area(double _base, double altura)
    {
        double area = (_base + altura) ;
        return area;
    }

}