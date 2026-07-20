namespace Fractions
{
    public class Fraction
    {
        private int _top;
        private int _bottom;

        // Constructeur sans parametre : initialise a 1/1
        public Fraction()
        {
            _top = 1;
            _bottom = 1;
        }

        // Constructeur avec un seul parametre : denominateur initialise a 1
        public Fraction(int top)
        {
            _top = top;
            _bottom = 1;
        }

        // Constructeur avec deux parametres : numerateur et denominateur
        public Fraction(int top, int bottom)
        {
            _top = top;
            _bottom = bottom;
        }

        // Getters et setters
        public int GetTop()
        {
            return _top;
        }

        public void SetTop(int top)
        {
            _top = top;
        }

        public int GetBottom()
        {
            return _bottom;
        }

        public void SetBottom(int bottom)
        {
            _bottom = bottom;
        }

        // Retourne la fraction sous forme "3/4"
        public string GetFractionString()
        {
            return $"{_top}/{_bottom}";
        }

        // Retourne la valeur decimale, ex 0.75
        public double GetDecimalValue()
        {
            return (double)_top / _bottom;
        }
    }
}