using System;

namespace _20201010_DM_ARTIGO_26813
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "Boas Vindas ao artigo 26813, da plataforma DEVMEDIA",
                "Conversões de dados implícitas e explicitas em C#"
                );
            
            Console.WriteLine("/n==== Conversão Implícita ====/n");
            ConversaoImplicita.ConversaoImp();
            Console.WriteLine("------------------------------------");
            
            Console.WriteLine("/n==== Conversão Explicito ====/n");
            ConversaoExplicita.ConversaoExp();
            Console.WriteLine("------------------------------------");

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
