using System;

namespace SequenceGenerator {
    public class Generator {
        static int[,] TribMatrix() => new[,] { { 1, 1, 1 }, { 1, 0, 0 }, { 0, 1, 0 } };

        static void Multiply(int[,] t, int[,] m)
        {
            int[,] tempm = new int[t.GetLength(0), m.GetLength(1)];

            for (int i = 0; i < t.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    tempm[i, j] = 0;
                    for (int k = 0; k < t.GetLength(1); k++)
                        tempm[i, j] = tempm[i, j] + t[i, k] * m[k, j];
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    t[i, j] = tempm[i, j];
                }
            }
        }

        static void Power(int[,] t, int n)
        {
            if (n == 0 || n == 1) return;
            Power(t, n / 2);
            Multiply(t, t);
            if (n % 2 != 0)
            {
                int[,] m = TribMatrix();
                Multiply(t, m);
            }
        }

        public static int Tribonacci(int n)
        {
            int[,] t = TribMatrix();
            Power(t, n);
            return t[0, 0];
        }
    }
}
