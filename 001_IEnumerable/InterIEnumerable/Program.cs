using System;
using System.Collections;

namespace InterIEnumerable
{
    class Program
    {
        static void Main()
        {
            UserCollection myCollection = new UserCollection();

            // Використовуємо foreach, для звернення до кожного об'єкту Element всередині масиву myCollection.
            foreach (Element element in myCollection)
            {
                Console.WriteLine("Name: {0} Field1: {1} Field2: {2}", element.Name, element.Field1, element.Field2);
            }

            //myCollection.Reset (); // Прибрати коментар для перевірки.

            Console.Write(new string('-', 29) + "\n");

            // Використовуємо foreach, для повторного звернення до кожного об'єкту Element всередині масиву myCollection.
            foreach (Element element in myCollection)
            {
                Console.WriteLine("Name: {0} Field1: {1} Field2: {2}", element.Name, element.Field1, element.Field2);
            }

            Console.Write(new string('-', 29) + "\n");


            // ------------------------------------------------ -------------------------------------------------- --------------------
            // Так працює foreach.

            UserCollection myElementsCollection = new UserCollection();

            // foreach - приводить колекцію до типу IEnumerable.
            IEnumerable enumerable = myElementsCollection as IEnumerable;

            // foreach - приводить колекцію до типу IEnumerator, викликаючи метод - GetEnumerator ().
            IEnumerator enumerator = enumerable.GetEnumerator();


            while (enumerator.MoveNext()) // Переміщаємо курсор на 1 крок вперед (з -1 на 0) і т.д.
            {
                Element element = enumerator.Current as Element;

                Console.WriteLine("Name: {0} Field1: {1} Field2: {2}", element.Name, element.Field1, element.Field2);
            }


            enumerator.Reset();

            // Затримка.
            Console.ReadKey();
        }
    }
}