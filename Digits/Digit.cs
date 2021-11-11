using System;
using System.Collections.Generic;
using System.Text;

namespace Digits
{
    public class Digit
    {
        private int _numerator;
        private int _denominator;
        public int Numerator
        {
            get => _numerator;
        }
        public int Denominator
        {
            get => _denominator;
        }
        public static Digit operator + (Digit d1, Digit d2)
        {
            Digit result = new Digit((d1.Numerator * d2.Denominator)
                + (d2.Numerator * d1.Denominator), d1.Denominator * d2.Denominator);
            return result;
        }
        public static Digit operator - (Digit d1, Digit d2)
        {
            Digit result = new Digit((d1.Numerator * d2.Denominator)
                - (d2.Numerator * d1.Denominator), d1.Denominator * d2.Denominator);
            return result;
        }
        public Digit(int numerator, int denominator)
        {
            if(denominator == 0)
            {
                throw new ArgumentException("zero in denominator");
            }
            if(denominator < 0)
            {
                numerator *= -1;
                denominator *= -1;
            }
            _numerator = numerator;
            _denominator = denominator;
        }
        public override string ToString()
        {
            return $"{_numerator}/{_denominator}";
        }

    }
}
