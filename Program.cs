using System;

namespace chmlab12
{
    class Program
    {
        const double eps = 1e-3;
        static void Main()
        {
            int n;
            double a, b, min, max, q, tau;
            a = 0.5;
            b = 1.5;
            minmax(a, b, out min, out max);
            set_q(min, max, out q);
            iternum(0.5, q, out n); // z0<=0.5

            tau = 2.0 / (min + max);
            double xn = 0.5; // x0 = 0.5
            double xn1;
            double test = xn;
            Console.WriteLine($"Промiжок вiд 0.5 до 1.5\nКiлькiсть апрiорних iтерацiй: {n}\ni: xn\t\t\t\t\t\tf(xn)\n0: {test}\t\t\t\t\t\t{fx(test)}");

            for (var i = 0; i < n; ++i)
            {
                xn1 = xn - tau * fx(xn);
                test = xn = xn1;
                Console.WriteLine($"{i + 1}: {test}\t\t\t\t\t\t{fx(test)}");
            }
        }
        static void iternum(double z, double q, out int n)
        {
            n = (int)Math.Floor(Math.Log(Math.Abs(z) / eps) / Math.Log(1 / q)) + 1;


        }
        static void set_q(double min, double max, out double q)
        {
            q = (max - min) / (min + max);  // q
        }
        static void minmax(double a, double b, out double min, out double max)
        {
            min = Math.Abs(3 * a * a + 6 * a - 1);
            max = Math.Abs(3 * b * b + 6 * b - 1);

        }
        static double fx(double x)
        {
            return x * x * x + 3 * x * x - x - 3;
        } // x^3+3x^2-x-3
    }
}
