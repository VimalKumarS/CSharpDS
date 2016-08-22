using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static int BubbleSort()
        {
            Console.Write("\nProgram for Ascending order of Numeric Values using BUBBLE SORT");
            Console.Write("\n\nEnter the total number of elements: ");
            int max = Convert.ToInt32(Console.ReadLine());

            int[] numarray = new int[max];

            for (int i = 0; i < max; i++)
            {
                Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
                numarray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Before Sorting   : ");
            for (int k = 0; k < max; k++)
                Console.Write(numarray[k] + " ");
            Console.Write("\n");

            for (int i = 1; i < max; i++)
            {
                for (int j = 0; j < max - i; j++)
                {
                    if (numarray[j] > numarray[j + 1])
                    {
                        int temp = numarray[j];
                        numarray[j] = numarray[j + 1];
                        numarray[j + 1] = temp;
                    }
                }
                Console.Write("After iteration " + i.ToString() + ": ");
                for (int k = 0; k < max; k++)
                    Console.Write(numarray[k] + " ");
                Console.Write("/*** " + (i + 1).ToString() + " biggest number(s) is(are) pushed to the end of the array ***/\n");
            }

            Console.Write("\n\nThe numbers in ascending orders are given below:\n\n");
            for (int i = 0; i < max; i++)
            {
                Console.Write("Sorted [" + (i + 1).ToString() + "] element: ");
                Console.Write(numarray[i]);
                Console.Write("\n");
            }
            return 0;
        }

        static int InsertionSort()
        {
            Console.Write("\nProgram for Ascending order of Numeric Values using INSERTION SORT");
            Console.Write("\n\nEnter the total number of elements: ");
            int max = Convert.ToInt32(Console.ReadLine());

            int[] numarray = new int[max];

            for (int i = 0; i < max; i++)
            {
                Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
                numarray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Before Sorting   : ");
            for (int k = 0; k < max; k++)
                Console.Write(numarray[k] + " ");
            Console.Write("\n");

            for (int i = 1; i < max; i++)
            {
                int j = i;
                while (j > 0)
                {
                    if (numarray[j - 1] > numarray[j])
                    {
                        int temp = numarray[j - 1];
                        numarray[j - 1] = numarray[j];
                        numarray[j] = temp;
                        j--;
                    }
                    else
                        break;
                }
                Console.Write("After iteration " + i.ToString() + ": ");
                for (int k = 0; k < max; k++)
                    Console.Write(numarray[k] + " ");
                Console.Write("/*** " + (i + 1).ToString() + " numbers from the begining of the array are input and they are sorted ***/\n");
            }

            Console.Write("\n\nThe numbers in ascending orders are given below:\n\n");
            for (int i = 0; i < max; i++)
            {
                Console.Write("Sorted [" + (i + 1).ToString() + "] element: ");
                Console.Write(numarray[i]);
                Console.Write("\n");
            }
            return 0;
        }
        static public void DoMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];

            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];

            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        static public void MergeSort_Recursive(int[] numbers, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort_Recursive(numbers, left, mid);
                MergeSort_Recursive(numbers, (mid + 1), right);

                DoMerge(numbers, left, (mid + 1), right);
            }
        }

        static public int Partition(int[] numbers, int left, int right)
        {
            int pivot = numbers[left];
            while (true)
            {
                while (numbers[left] < pivot)
                    left++;

                while (numbers[right] > pivot)
                    right--;

                if (left < right)
                {
                    int temp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        static public void QuickSort_Recursive(int[] arr, int left, int right)
        {
            // For Recusrion
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                    QuickSort_Recursive(arr, left, pivot - 1);

                if (pivot + 1 < right)
                    QuickSort_Recursive(arr, pivot + 1, right);
            }
        }
    }
}

//http://www.softwareandfinance.com/CSharp/QuickSort_Recursive.html