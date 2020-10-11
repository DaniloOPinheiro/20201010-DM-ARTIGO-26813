using System;

namespace _20201010_DM_ARTIGO_26813
{
    public class ConversaoExplicita
    {
        public static void ConversaoExp()
        {
            sbyte a = 10;
            short b = (short)a;
            int c = (int)b;
            long d = (long)c;
            float e = (long)d;
            double f = (float)e;
            
            Console.Write(f);
            Console.Read();
        }
    }
}