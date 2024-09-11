// Practica Opp Herencia 
/*2.  Defina una clase abstracta Shape con el método abstracto CalculateSurface() y el ancho y alto de los campos. 
 * Defina dos clases adicionales para un triangle y un rectangle, que implementan CalculateSurface(). 
 * Este método tiene que devolver las áreas del rectángulo (alto*ancho) y del triángulo (alto*ancho/2). 
 * Defina una clase para un Circle con un constructor apropiado, que inicialice los dos campos (alto y ancho) 
 * con el mismo valor (el radio) e implemente el método abstracto para calcular el área. Crea una matriz de diferentes Shapes y 
 * calcula el área de cada forma en otra matriz.*/


public abstract class Shape
{
    protected double ancho;
    protected double altura;

    public Shape(double ancho, double altura)
    {
        this.ancho = ancho;
        this.altura = altura;
    }
    public abstract double CalculateSurface();

}

// Clase triangulo
 
public class Triangulo : Shape
{
    public Triangulo(double ancho, double altura) : base(ancho, altura) { }

    public override double CalculateSurface()
    {
        return ancho * altura / 2;
    }
}

// Clase Rectangulo

public class  Rectangulo: Shape
{
    public Rectangulo(double ancho, double altura) : base(ancho, altura) { }

    public override double CalculateSurface()
    {
        return ancho * altura;
    }

}

//Circulo Clase 

public class Circulo : Shape
{
    public Circulo(double radio) : base(radio,radio ) { }

    public override double CalculateSurface()
    {
        return Math.PI * ancho * ancho;
    }
}

class Programa
{
    static void Main(string[] args)
    {
        Shape[] shapes = new Shape[]
        {
            new Triangulo (5,3),
            new Rectangulo (7,4),
            new Circulo (90),
            new Triangulo(9,12),
            new Rectangulo(20,5)

        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"El área es: {shape.CalculateSurface()}");


    }    }        
}   