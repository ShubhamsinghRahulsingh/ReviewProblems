using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession
{
    public class MergeTwoSortedArrays
    {
        int[] firstArray = { 18, 23, 25, 35, 45, 50 };
        int[] secondArray = { 10, 23, 57, 69, 70, 87, 95 };
        public void MergeSortedArrays()
        {
            int n1 = firstArray.Length;
            int n2 = secondArray.Length;
            int[] finalArray =new int[firstArray.Length + secondArray.Length];
            int i = 0, j = 0, k = 0;
            while (i < n1 && j < n2)
            {
                if(firstArray[i] < secondArray[j])
                {
                    finalArray[k]=firstArray[i];
                    i++;
                }
                else
                {
                    finalArray[k] = secondArray[j];
                    j++;
                }
                k++;
            }
            while(i<n1)
            {
                finalArray[k++]=firstArray[i++];
            }
            while (j < n2)
            {
                finalArray[k++] = secondArray[j++];
            }
            foreach(var data in finalArray)
            {
                Console.Write(data+ " ");
            }
        }
    }
}
