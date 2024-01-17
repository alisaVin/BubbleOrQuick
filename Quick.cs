using System;

public class Quick 
{
	public void QSort(int[] numbersArr)
	{
		int len = numbersArr.Length;
		int pivot_1 = numbersArr[0];                           //Pivot am Anfang                                
		int m;                                                 //Median Ind *

		//Median berechnen
		if (len % 2 == 1)
		{
			m = (len - 1) / 2;
        }
		else 
		{
            m = (len / 2) + 1; 
        }
        numbersArr[0] = numbersArr[m];
		numbersArr[m] = pivot_1;

        //allgemein muss noch Fehler behebt werden (pivot schauen)
        //1 ----> 
        for (int i = 0; i < m; i++)
		{
			if (numbersArr[i] > pivot_1)
			{
                int more = numbersArr[i];
				numbersArr[i] = numbersArr[m + 1];
                numbersArr[m + 1] = more;
            }
		}
		//1 <----
		for (int j = len - 1; j > m; j--)
		{
			if (numbersArr[j] < pivot_1)
			{
                int less = numbersArr[j];
                numbersArr[j] = numbersArr[m - 1];
                numbersArr[m - 1] = less;
            }
		}

		//2 <----
		//int pivot_2 = 
        foreach (int num in numbersArr)
        {
            Console.Write($"{num} ");
        }
    }
}
