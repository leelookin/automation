using System;

namespace Calc2
{
    public static class Calculator
    {
        public static double Plus(double x1, double x2) {
            return x1 + x2;
        }

        public static double Minus(double x1, double x2) {
            return x1 - x2;
        }

        public static double Divide(double x1, double x2) {
            return x1 / x2;
        }

        public static double Multiply(double x1, double x2) {
            return x1 * x2;
        }

        public static double Balance(double x1, double x2) {
            return x1 % x2;
        }

        public static double Sqrt(double x1) {
            return Math.Sqrt(x1);
        }
    }
}
