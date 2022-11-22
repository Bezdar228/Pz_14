namespace Pz_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n:");
            int n = int.Parse(Console.ReadLine());
            int a1 = -30;
            double b1 = 6;
            Console.WriteLine("Задача 1");
            Console.WriteLine(ArithmeticProgression(a1, n));
            Console.WriteLine("Задача 2");
            Console.WriteLine(Geometricprogression(b1, n));
            Console.WriteLine("Задача 3");
            Console.WriteLine(AllNumbers(64,54+));
            Console.WriteLine("Задание 4");
            Console.WriteLine(sumTo(n));

        }
        static int ArithmeticProgression(int a1, int n)
        {
            int d = 2;
            if (n == 1)
            {
                return a1;
            }
            else
            {
                int result = ArithmeticProgression(a1 + d, --n);
                return result;
            }
        }
        static double Geometricprogression(double b1, int n)
        {
            double q = -5;
            if (n == 1)
            {
                return b1;

            }
            else
            {
                double result = Geometricprogression(b1 * q, --n);
                return result;
            }

        }
        static int sumTo(int n)
           
        {
            if (n == 1)
                return 1;
            return sumTo(n - 1) + n;
            
        }
        static string AllNumbers(int A, int B)
        {
            if (A == B)
            {
                return Convert.ToString(A);
            }
            else if (A > B)
            {
                return A + " " + AllNumbers(A - 1, B);
            }
            else
            {
                return A + " " + AllNumbers(A + 1, B);
            }
        }









    }

}