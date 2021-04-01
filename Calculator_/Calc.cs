using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_
{
    static class Calc
    {
        private static double a, b;
        private static char? operationMathSymbol;



        public static void SetSymbolAndA(char OperationMathSymbol, string A)
        {
            a = CheckTheNumber(A);
            operationMathSymbol = OperationMathSymbol;
        }

        private static double CheckTheNumber(string textToConvert)
        {
            double x = 0;
            try
            {
                x = Convert.ToDouble(textToConvert.Replace('.', ','));
            }
            catch (FormatException e)
            {
                MessageBox.Show($"W tym okienku należy wpisać prawidłową liczbę, nie tekst");
            }
            catch (Exception e)
            {
                MessageBox.Show($"Inny nie znany błąd. Zgłoś ten problem programistom\ntresc bledu: {e} \n oraz {e.Message}");
            }
            return x;
        }
        public static void Reset()
        {
            a = 0;
            b = 0;

            operationMathSymbol = null;
        }
        public static double Result(string B)
        {
            b = CheckTheNumber(B);


            return Calculations();
        }
        private static double Calculations()
        {
            switch (operationMathSymbol)
            {
                case '+':
                    a += b;
                    break;
                case '-':
                    a -= b;
                    break;
                case '*':
                    a *= b;
                    break;
                case '/':
                    if (b != 0)
                        a /= b;
                    else MessageBox.Show("Ty cholero, dlaczego dzielisz przez zero?");
                    break;

                default:
                    MessageBox.Show("Coś poszło nie tak z działaniem");

                    break;
            }

            return a;
        }
    }
}
