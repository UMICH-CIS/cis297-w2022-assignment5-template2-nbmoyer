using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGUI
{
    internal class Quadratic
    {
        class QuadraticEquation
        {
            private int A;
            private int B;
            private int C;

            double Discriminant;
            double X1;
            double X2;
            Boolean status = true;

            public QuadraticEquation(int a, int b, int c)
            {
                this.A = a;
                this.B = b;
                this.C = c;
            }
            public QuadraticEquation()
            {

            }
            public int a
            {
                get
                {
                    return this.A;
                }

                set
                {
                    this.A = value;
                }
            }

            public int b
            {
                get
                {
                    return this.B;
                }

                set
                {
                    this.B = value;
                }
            }

            public int c
            {
                get
                {
                    return this.C;
                }

                set
                {
                    this.C = value;
                }
            }


            public double ComputeDisc()
            {
                Discriminant = Math.Pow(B, 2) - 4 * A * C;
                return Discriminant;
            }

            public void ComputeSolution()
            {
                if (Discriminant == 0)
                {
                    if (A == 0)
                    {

                        status = false;

                    }
                    else
                    {
                        X1 = -B / (2 * A);
                        X2 = X1;
                    }

                }
                else if (Discriminant > 0)
                {
                    if (A == 0)
                    {

                        status = false;

                    }
                    else
                    {
                        X1 = (-B + Math.Sqrt(Discriminant)) / (2 * A);
                        X2 = (-B - Math.Sqrt(Discriminant)) / (2 * A);
                    }

                }
                else
                {
                    status = false;
                }
            }
            public void DisplaySolution()
            {
                //Console.WriteLine($"Quadratic Equation with  A: {0}   B: {1}  C: {2}", A, B, C);
                ComputeDisc();
                ComputeSolution();
                if (status)
                {
                    if (X1 == X2)
                    {
                        Console.WriteLine($"The equation has one root: {X1}");
                    }
                    else
                    {
                        Console.WriteLine($"Root X1 = {X1}");
                        Console.WriteLine($"Root X2 = {X2}");
                    }
                }
                else
                {
                    Console.WriteLine("Equation has no real roots!");
                }

            }
        }
    }
}
