using System;

namespace _20201010_DM_ARTIGO_26813
{
    public class ConversionTypeSafe
    {
        public static void Conversion()
        {
            sbyte a = 10;
            short b = a;
            int c = b;
            long d = c;
            float e = d;
            double f = e;

            Console.WriteLine(f);
            Console.ReadLine();
        }
    }

}

