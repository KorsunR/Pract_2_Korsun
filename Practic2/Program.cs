using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v;
            do
            { 
                Console.WriteLine("Для запуска первой проги нажми 1\nДля запуска второй проги нажми 2\nДля запуска третьей проги нажми 3\nЕсли хотите выйти из программы нажми 4");
                v = int.Parse(Console.ReadLine());
                switch (v)
                {
                    case 1:
                        Random n = new Random();
                        int f = n.Next(0, 100);
                        Console.WriteLine(f);
                        do
                        {
                            int u;
                            Console.WriteLine("JUST DO IT"); 
                            u = int.Parse(Console.ReadLine()); 
                            if (u == f)
                            {
                                Console.WriteLine("SHIUUUSH ПРАВИЛЬНО");
                                v = 2;
                                break;
                            }
                            else if (u > f)
                            {

                                while (u > f)
                                {
                                    Console.WriteLine("Поменьше\n давайка еще разок"); 

                                    u = int.Parse(Console.ReadLine());
                                    if (u < f)
                                    {
                                        while (u < f)
                                        {
                                            Console.WriteLine("Побольше"); 
                                            u = int.Parse(Console.ReadLine());
                                            if (u < f)
                                            {

                                                continue;
                                            }
                                            else if (u == f)
                                            {
                                                Console.WriteLine("SHIUUUSH ПРАВИЛЬНО"); 
                                                v = 2;
                                                break;
                                            }

                                        }




                                    }
                                    else if (u == f)
                                    {

                                        Console.WriteLine("GYGACHAD"); 
                                        v = 2;
                                    }
                                    else if (u > f)
                                    {

                                        continue;
                                    }
                                }


                            }
                            else if (u < f)
                            {

                                while (u < f)
                                {
                                    Console.WriteLine("Побольше\n давайка еще разок"); 

                                    u = int.Parse(Console.ReadLine());
                                    if (u > f)
                                    {
                                        while (u > f)
                                        {
                                            Console.WriteLine("Поменьше");
                                            u = int.Parse(Console.ReadLine());
                                            if (u < f)
                                            {

                                                continue;
                                            }
                                            else if (u == f)
                                            {
                                                Console.WriteLine("SHIUUUSH ПРАВИЛЬНО");
                                                v = 2;
                                                break;
                                            }

                                        }
                                    }
                                    else if (u == f)
                                    {

                                        Console.WriteLine("GYGACHAD");
                                        v = 2;
                                        break;
                                    }
                                    else if (u < f)
                                    {


                                        continue;
                                    }
                                }
                            }
                        } while (v == 1);
                        break;
                    case 2:

                        int[] mpt = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                        



                        for (int i = 0; i < mpt.Length; i++)
                        {
                            Console.Write($"  {mpt[i]}\t");
                        }
                        Console.WriteLine("\n");
                        for (int k = 0; k < mpt.Length; k++)
                        {
                            Console.Write($"  {mpt[0] * mpt[k]}\t  " +
                                $"{mpt[1] * mpt[k]}\t  " +
                                $"{mpt[2] * mpt[k]}\t  " +
                                $"{mpt[3] * mpt[k]}\t  " +
                                $"{mpt[4] * mpt[k]}\t  " +
                                $"{mpt[5] * mpt[k]}\t  " +
                                $"{mpt[6] * mpt[k]}\t  " +
                                $"{mpt[7] * mpt[k]}\t  " +
                                $"{mpt[8] * mpt[k]}\t\n");
                        }



                        break;
                    case 3:
                        int q;
                        Console.WriteLine("ЭЙ чел введи число, не души"); 
                        q = int.Parse(Console.ReadLine());


                        for (int i = 1; i <= q; i++)
                        {
                            int w;
                            w = q % i;
                            if (w == 0)
                            {
                                Console.Write(i + "\t");

                            }
                        }

                        Console.WriteLine(" \n ");


                        break;
                    case 4:

                        break;

                }

            } while (v != 4);
        }
    }
}

