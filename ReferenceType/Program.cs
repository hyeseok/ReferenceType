using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceType
{
    class Program
    {
        static int MAX = 4;
        
        static void Main(string[] args)
        {
            short a = 1;
            short b = 2;
            Swap(&a, &b);
            Console.WriteLine(a);
            Console.WriteLine(b);
            return;

            Lion l = new Lion();
            LionGrow(l);
            Console.WriteLine(l.Age);

            Cat c = new Cat();
            CatGrow(c);
            Console.WriteLine(c.Age);
        }

        static void Swap(short* a, short* b)
        {
            short s = *a;
            *a = *b;
            *b = s;
        }

        static void LionGrow(Lion a)
        {
            a.Age++;
        }

        static void CatGrow(Cat a) // overloading
        {
            a.Age++;
        }
    }
}
