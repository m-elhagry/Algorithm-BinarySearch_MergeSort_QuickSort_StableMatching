using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, search, first, last, middle;
            int[] arr = new int[50];
            Console.WriteLine("Enter total number of elements :");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter " + n + " number :");
            for (i=0; i<n; i++)
	            arr[i] = Convert.ToInt32(Console.ReadLine());
	        Console.WriteLine("Enter a number to find :");
            search = Convert.ToInt32(Console.ReadLine());
            first = 0;
            last = n-1;
            middle = (first+last)/2;
            while (first <= last)
            {
	            if(arr[middle] < search)
	            {
		            first = middle + 1;

	            }
	            else if(arr[middle] == search)
	            {
                    Console.WriteLine("location " + (middle + 1)); 
			        break;
		        }
		        else
		        {
			        last = middle - 1;
		        }
		            middle = (first + last)/2;
	        }
	        if(first > last)
	        {
                Console.WriteLine("Not found!");
	        }
        }
    }
}
