using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quick_sort
{
    class Program
    {
        static void quicksort(int[] x,int first,int last)
        {
            int pivot,j,temp,i;
            if(first<last)
	        {
                 pivot=first;
                 i=first;
                 j=last;
                 while(i<j)
		         {
                     while(x[i]<=x[pivot]&&i<last)
                         i++;
                     while(x[j]>x[pivot])
                         j--;
                     if(i<j)
                     {
                         temp=x[i];
                          x[i]=x[j];
                          x[j]=temp;
                     }
                }
                temp=x[pivot];
                x[pivot]=x[j];
                x[j]=temp;
                quicksort(x,first,j-1);
                quicksort(x,j+1,last);
            }
        }
        static void Main(string[] args)
        {
            int[] x = new int[30];int size,i;
            Console.WriteLine("Enter size of the array: ");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter elements: "+size);
            for(i=0;i<size;i++)
                x[i]=Convert.ToInt32(Console.ReadLine());
            quicksort(x,0,size-1);
            Console.WriteLine("Sorted elements: ");
            for(i=0;i<size;i++)
                Console.WriteLine(x[i]);
        }
    }
}
