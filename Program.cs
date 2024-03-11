using System;

namespace QuickOrBubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Random input
            Console.WriteLine("Wie viel Elemente sollen im Array sein? : ");
            int numberInput = Convert.ToInt32(Console.ReadLine());
            int[] numbersArr = new int[numberInput];

            Console.Write("So sieht das Array aus: [");
            Random rnd = new Random();

            for (int item = 0; item < numberInput; item++)
            {
                numbersArr[item] = rnd.Next(1000);
                Console.Write($"{numbersArr[item]} ");
            }
            Console.WriteLine("\b]");
            Console.WriteLine("----------------");
            //Choise
            Console.WriteLine("Bitte wählen Sie den Algorythmus, nach dem die Zahlen im Array sortiert werden sollen:");
            Console.WriteLine();
            Console.WriteLine("1. Bubble Sort");
            Console.WriteLine("2. Quick Sort");
            Console.WriteLine("----------------");

            int inpChoise = Convert.ToInt32(Console.ReadLine());

            if (inpChoise == 1)
            {
                Console.Write("So sieht das nach der Bubble-Sorstierung aus: [");
                Bubble bubble1 = new Bubble();
                bubble1.BSort(numbersArr);
            }
            else if (inpChoise == 2)
            {
                Console.Write("So sieht das nach der Quick-Sorstierung aus: [");
                Quick quick1 = new Quick();
                quick1.QSort(numbersArr, 0, numbersArr.Length - 1);

                foreach (int i in numbersArr)
                {
                    Console.Write($"{i} ");
                }
            }
            else
            {
                Console.WriteLine("_(:3_z)_");
            }
            
            Console.WriteLine("\b]");
            Console.WriteLine("****************");
            Console.ReadKey();
        }
    }
}