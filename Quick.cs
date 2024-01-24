using System;

//FINAL BEARBEITEN!!!
class Quick
{
    public static int split(int[] numbersArr, int less, int more)
    {
        int i = less - 1;
        int pivot = numbersArr[more];

        for (int j = less; j <= more; j++)
        {
            if (numbersArr[j] < pivot)
            {
                i++;

                int temp = numbersArr[i];
                numbersArr[i] = numbersArr[j];
                numbersArr[j] = temp;
            }
        }
        i++;

        int temp_2 = numbersArr[i];
        numbersArr[i] = numbersArr[more];
        numbersArr[more] = temp_2;

        return i; 
    }

    public void QSort(int[] numbersArr, int less, int more)
    {
        if (more <= less) return; 

        int pivot_i = split(numbersArr, less, more);
        QSort(numbersArr, less, pivot_i - 1);
        QSort(numbersArr, pivot_i + 1, more);
    }
}