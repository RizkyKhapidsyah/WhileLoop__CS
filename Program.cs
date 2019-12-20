using System;

namespace WhileLoop__CS
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y, A;
            string Z;

            X = 1;

            Console.Write("Jumlah Perulangan Nilai Yang Ingin Ditampilkan   : ");
            Y = Convert.ToInt32(Z = Console.ReadLine());
            Console.Write("Jumlah Kelipatan                                 : ");
            A = Convert.ToInt32(Z = Console.ReadLine());

            Console.WriteLine();

            while (X <= Y)
            {
                Console.WriteLine("Nilainya adalah = " + X);
                X += A;
            }

            Console.ReadLine();
        }
    }
}
