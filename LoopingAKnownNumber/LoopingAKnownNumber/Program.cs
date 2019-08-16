using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingAKnownNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 24;
            for (int i = 0; i <= num; i++)
            {
                if (i == 24)
                {
                    Console.Write(i);
                }
                else 
                Console.Write(i+",");
               
                if (i == 24)
                {
                    
                    Console.Write("\n");
                    for (int j = 0; j <= num; j += 2)
                    {
                        if (j == 24)
                        {
                            Console.Write(j);
                        }
                        else
                        Console.Write(j + ",");
                        if (j == 24)
                        {
                            Console.Write("\n");
                            for (int k = 0; k <= num; k += 3)
                            {
                                if (k == 24)
                                {
                                    Console.Write(k);
                                }
                                else 
                                Console.Write(k + ",");
                                if (k == 24)
                                {
                                    Console.Write("\n");
                                    for (int z = 0; z <= num; z += 4)
                                    {
                                        if (z == 24)
                                        {
                                            Console.Write(z);
                                        }
                                        else 
                                        Console.Write(z + ",");
                                    }
                                }
                            }
                        }
                    }
                }
                
               
            }
            Console.Read();
        
        }
    }
}
