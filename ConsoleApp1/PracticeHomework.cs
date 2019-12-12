using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class PracticeHomework
    {
        static int BinarySeek<T>(int[] numbers, int target)
        {
            int min = 0;
            int max = numbers.Length - 1;
            int mid = 0;
            while (min <= max)
            {
                mid = (min + max) / 2;
                if (numbers[mid] > target)
                {
                    max = mid - 1;
                }
                else if (numbers[mid] < target)
                {
                    min = mid + 1;
                }
                else if (numbers[mid] == target)
                {
                    return mid;
                }
            }
            return -1;
        }

        static T GetMax<T>(T[] array) where T: IComparable<T>
        {
            T max = array[0];
            foreach (T Max in array)
            {
                if (Max.CompareTo(max)>0)
                {
                    max = Max;
                }
            }
            return max;
        }
    }
}
