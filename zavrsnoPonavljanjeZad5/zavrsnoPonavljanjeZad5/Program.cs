using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavrsnoPonavljanjeZad5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1, i2, i3, i4, i5, i6, i7;

            for (i1 = 1; i1 <= 33; i1++)
            {
                for (i2 = i1 + 1; i2 <= 34; i2++)
                {
                    for (i3 = i2 + 1; i3 <= 35; i3++)
                    {
                        for (i4 = i3 + 1; i4 <= 36; i4++)
                        {
                            for (i5 = i4 + 1; i5 <= 37; i5++)
                            {
                                for (i6 = i5 + 1; i6 <= 38; i6++)
                                {
                                    for (i7 = i6 + 1; i7 <= 39; i7++)
                                    {
                                    Console.WriteLine(i1 + " " + i2 + " " + i3 + " " + i4 + " " + i5 + " " + i6 + " " + i7);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
