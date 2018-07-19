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
            Cat c = new Cat(); // 구조체 struct 참조
            GrowCat(ref c);
            Console.WriteLine(c.Age);

            Lion l = new Lion(); // 클래스 class 참조
            GrowLion(ref l);
            Console.WriteLine(l.Age);

            foo();
        }

        private static void foo()
        {
            Lion l1 = new Lion();
        }

        //이곳에서의 ref는 2중 포인터의 느낌과 같다. **
        static void GrowLion(ref Lion a)
        {
            a.Age++;
        }

        //ref는 포인터랑 같은 의미를 가지고잇음 또는 out 사용
        static void GrowCat(ref Cat a) // overloading
        {
            a.Age++;
        }
    }
}
