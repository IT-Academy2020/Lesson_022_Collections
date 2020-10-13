using System.Collections;

namespace InterIEnumerable
{
    public class UserCollection : IEnumerable
    {
        public Element[] elementsArray = null;

        public UserCollection()
        {
            elementsArray = new Element[4];
            elementsArray[0] = new Element("A", 1, 10);
            elementsArray[1] = new Element("B", 2, 20);
            elementsArray[2] = new Element("C", 3, 30);
            elementsArray[3] = new Element("D", 4, 40);
        }

        // Показник поточної позиції елемента в масиві.
        int position = -1;

        // Скинути показник (position) до початкового значення.
        public void Reset()
        {
            position = -1;
        }

        // ------------------------------------------------ -------------------------------------------------- -----------------------
        // Реалізація інтерфейсу - IEnumerable.

        public IEnumerator GetEnumerator()
        {
            while (true)
            {
                if (position < elementsArray.Length - 1)
                {
                    position++;
                    yield return elementsArray[position];
                }
                else
                {
                    Reset();
                    yield break; // Вихід з циклу.
                }
            }
        }
    }
}