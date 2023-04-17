namespace Application;

public class Paralelolipedo
{
    public static double Volumen(double area, double prisma)
    {
        double volumen = area * prisma;
        return volumen;
    }

    public static double Volumen(double a, double h, double prisma)
    {
        double area = Paralelogramo.Area( a, h);
        double volumen = Volumen(area, prisma);

        return volumen;
    }
}