using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int summ = 0;
            bool S=false;
            int[,] cvad = new int[5, 5];
            Random rand = new Random();
            int l = 0, s = 0;
            while (!S)
            {
                summ = 0;
                for (int i = s; i < 5; i++)
                {
                    cvad[s, i] = rand.Next(1, 9);
                    summ += cvad[s, i];
                }S = true;
               /* if(summ <= 18)
                {
                    
                }*/
            }
            Console.WriteLine("[" + s + "," + l + "] = "+summ);
            s++;
            Console.ReadKey();
            cvad_stroc(ref cvad, ref l, ref s, summ);


            for (int y = 0; y <= 4; y++)
            {
                for (int t = 0; t <= 4; t++)
                {

                    if (t == 4) { Console.WriteLine(cvad[y, t] + " "); } else { Console.Write(cvad[y, t] + " "); }
                }
            }


            Console.ReadKey();
        }
        static int[,] cvad_line(ref int[,] cvad, ref int l, ref int s, int summ)
        {
            Random rand = new Random();
            bool q = false;
            int nsumm = 0;
            for (int i = l; i < 5; i++)
            {
                cvad[s, i] = rand.Next(1, 9);
            }
            while (!q)
            {
                nsumm = 0;
                for (int i = 0; i < 5; i++)
                {
                    nsumm += cvad[s, i];
                }
                for (int i = l; i < 5; i++)
                {
                    nsumm = 0;
                    for (int i1 = 0; i1 < 5; i1++)
                    {
                        nsumm += cvad[s, i1];
                    }
                    if (nsumm > summ)
                    {
                        if (cvad[s, i] > 1)
                        {
                            cvad[s, i]--;
                        }
                       /* if (cvad[s, i] <= 1)
                        {
                            break;
                        }*/
                    }
                    if (nsumm < summ)
                    {
                        if (cvad[s, i] < 9)
                        {
                            cvad[s, i]++;
                        }
                       /* if (cvad[s, i] >= 9)
                        {
                            break;
                        }*/
                    }
                }
                if (summ == nsumm)
                {
                    q = true;
                    Console.WriteLine(q + "2 "+"["+s+","+l+"]" + nsumm);
                  for (int y = 0; y <= 4; y++)
                    {
                        for (int t = 0; t <= 4; t++)
                        {

                            if (t == 4) { Console.WriteLine(cvad[y, t] + " "); } else { Console.Write(cvad[y, t] + " "); }
                            
                        }
                    }
                    Console.ReadKey();
                    s++;
                    if (s<5)
                    {
                        cvad_stroc(ref cvad, ref l, ref s, summ);
                    }
                    
                }
                else
                {
                    Console.WriteLine(q + "2 " + nsumm);
                   
                    
                }

            }
            return cvad;
        }
        static int[,] cvad_stroc(ref int[,] cvad, ref int l, ref int s, int summ)
        {
            Random rand = new Random();
            bool q = false;
            int nsumm = 0;
            for (int i = s; i < 5; i++)
            {
                cvad[i, l] = rand.Next(1, 9);
            }
            while (!q)
            {
                nsumm = 0;
                for (int i = s; i < 5; i++){
                    nsumm = 0;
                    for (int i1 = 0; i1 < 5; i1++){nsumm += cvad[i1, l];}
                    if (nsumm > summ){if (cvad[i, l] > 1){cvad[i, l]--;}}
                    if (nsumm < summ){if (cvad[i, l] < 9){cvad[i, l]++;}}
                }
                for (int i = 0; i < 5; i++){nsumm += cvad[i, l];}
                if (summ == nsumm){
                    q = true;
                    Console.WriteLine(q + "1 " + "["+s + "," + l + "]" + nsumm);
                 for (int y = 0; y <= 4; y++)
                    {
                        for (int t = 0; t <= 4; t++)
                        {

                            if (t == 4) { Console.WriteLine(cvad[y, t] + " "); } else { Console.Write(cvad[y, t] + " "); }
                            
                        }
                    }
                    Console.ReadKey();
                    l++;
                    if (l<5)
                    {
                        cvad_line(ref cvad, ref l, ref s, summ);
                    }
                    
                }
                else
                {
                    Console.WriteLine(q + "1 " + nsumm);
                    
                }
            }
            return cvad;
        }
    
    }
}
