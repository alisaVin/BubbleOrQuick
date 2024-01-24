using System;

namespace QuickOrBubbleSort
{
    public class Bubble
    {
        public void BSort(int[] numbersArr)
        {
            for (int item = 0; item < numbersArr.Length; item++)
            {
                for (int sort = 0; sort < numbersArr.Length - 1; sort++)
                {
                    if (numbersArr[sort] > numbersArr[sort + 1])
                    {
                        int temp = numbersArr[sort];
                        numbersArr[sort] = numbersArr[sort + 1];
                        numbersArr[sort + 1] = temp;
                    }
                }
            }
            foreach (int item in numbersArr)
            {
                Console.Write($"{item} ");
            }
        }
    }
}

