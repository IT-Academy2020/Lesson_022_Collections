using System;
using System.Collections;

namespace Yield
{
    class Program
    {
        static void Main()
        {
            foreach (string element in UserCollection.Power())
                Console.WriteLine(element);

            Console.WriteLine(new string('-', 12));

            // ------------------------------------------------ -----------------------------------------------
            // Так працює foreach.

            IEnumerable enumerable = UserCollection.Power();

            IEnumerator enumerator = enumerable.GetEnumerator();
            enumerator.Reset();

            while (enumerator.MoveNext()) // Переміщаємо курсор на 1 крок вперед.
            {
                String element = enumerator.Current as String;

                Console.WriteLine(element);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}