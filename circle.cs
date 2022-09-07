using System;
class Circle
{
    public static double Area(double r)
    {
        const double Pi = 3.14;
        return (Pi * r * r);

    }
    public static double Circumference(double r)
    {
        const double Pi = 3.14;
        return (2 * Pi * r);
    }
    public static void Main()
    {
        //Circle C = new Circle();
        double Ar, Circum;
        Console.WriteLine("\n Enter the radius of the circle : ");
        double r = double.Parse(Console.ReadLine());
        Ar = Area(r);
        Circum = Circumference(r);
        Console.WriteLine("\n The area of the circle is : {0}", Ar);
        Console.WriteLine("\n The circumference of the circle is : {0}", Circum);
    }
}