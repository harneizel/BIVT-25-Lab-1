using System.Diagnostics.CodeAnalysis;

namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            double f = Math.Abs(d);
            answer = f >= 1;

            // end

            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            // code here
            double sum = (d + f) / 2;
            answer = sum > 0;
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            int sum = a + b;
            double sr_znach = (Math.Abs(a) + Math.Abs(b)) / 2;
            answer = sum > sr_znach;
            // end

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            // code here
            answer = Math.Max(a, Math.Max(b, c));

            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double mod = Math.Abs(x);

            // end

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here

            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            // code here

            // end

            return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            // code here

            // end

            return answer;
        }
    }
}
