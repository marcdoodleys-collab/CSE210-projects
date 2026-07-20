using System;

namespace Fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constructeur sans parametre -> 1/1
            Fraction fraction1 = new Fraction();
            Console.WriteLine(fraction1.GetFractionString());
            Console.WriteLine(fraction1.GetDecimalValue());

            // Constructeur avec un parametre -> 5/1
            Fraction fraction2 = new Fraction(5);
            Console.WriteLine(fraction2.GetFractionString());
            Console.WriteLine(fraction2.GetDecimalValue());

            // Constructeur avec deux parametres -> 3/4
            Fraction fraction3 = new Fraction(3, 4);
            Console.WriteLine(fraction3.GetFractionString());
            Console.WriteLine(fraction3.GetDecimalValue());

            // Constructeur avec deux parametres -> 1/3
            Fraction fraction4 = new Fraction(1, 3);
            Console.WriteLine(fraction4.GetFractionString());
            Console.WriteLine(fraction4.GetDecimalValue());

            // Verification des getters et setters
            Fraction fraction5 = new Fraction(6, 7);
            Console.WriteLine(fraction5.GetFractionString());

            fraction5.SetTop(2);
            fraction5.SetBottom(9);
            Console.WriteLine($"Apres modification : {fraction5.GetFractionString()}");
            Console.WriteLine($"Numerateur : {fraction5.GetTop()}, Denominateur : {fraction5.GetBottom()}");
        }
    }
}