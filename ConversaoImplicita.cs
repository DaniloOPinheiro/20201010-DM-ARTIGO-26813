using System;

namespace _20201010_DM_ARTIGO_26813
{
    public class ConversaoImplicita
    {
        public static void ConversaoImp()
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

