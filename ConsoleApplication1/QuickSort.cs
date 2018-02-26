using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class QuickSort
    {


        public void Quick(int[] a,int low,int high)
        {
            if (low < high)
            {
                int pindex = partition(a, low, high);
                Quick(a, low, pindex - 1);
                Quick(a, pindex + 1, high);
            }
        }

        public static int partition(int[] a,int start,int end)
        {
            int pIndex = start;
            int pivot = a[end];

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < pivot)
                {

                    //swap a[i] and a[pindex]
                    int temp2 = a[i];
                    a[i] = a[pIndex];
                    a[pIndex] = temp2;

                    pIndex = pIndex + 1;
                }

            }
            //swap a[end] and a[pindex]
            int temp = a[end];
            a[end] = a[pIndex];
            a[pIndex] = temp;

            return pIndex;
        }
    }
    
}
