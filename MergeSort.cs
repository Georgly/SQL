using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathLang
{
    class MergeSort
    {
        public static void mergeSort<T>(ref List<T> inputData)
            where T : IComparable<T>
        {
            mergeSort(ref inputData, 0, inputData.Count - 1);
        }

        private static void mergeSort<T>(ref List<T> inputData, int firstIndex, int lastIndex)
            where T : IComparable<T>
        {
            // If the firstIndex is greater than the lastIndex then the recursion 
            // has divided the problem into a single item. Return back up the call 
            // stack.
            if (firstIndex >= lastIndex)
                return;

            int midIndex = (firstIndex + lastIndex) / 2;

            // Recursively divide the first and second halves of the inputData into
            // its two seperate parts.
            mergeSort(ref inputData, firstIndex, midIndex);
            mergeSort(ref inputData, midIndex + 1, lastIndex);

            // Merge the two remaining halves after dividing them in half.
            merge(ref inputData, firstIndex, midIndex, lastIndex);
        }

        private static void merge<T>(ref List<T> inputData, int firstIndex, int midIndex, int lastIndex)
            where T : IComparable<T>
        {
            int currentLeft = firstIndex;
            int currentRight = midIndex + 1;

            T[] tempData = new T[(lastIndex - firstIndex) + 1];
            int tempPos = 0;

            // Check the items at the left most index of the two havles and compare
            // them. Add the items in ascending order into the tempData array.
            while (currentLeft <= midIndex && currentRight <= lastIndex)
                if (inputData.ElementAt(currentLeft).CompareTo(inputData.ElementAt(currentRight)) < 0)
                {
                    tempData[tempPos++] = inputData.ElementAt(currentLeft++);
                }
                else
                {
                    tempData[tempPos++] = inputData.ElementAt(currentRight++);
                }

            // If there are any remaining items to be added to the tempData array,
            // add them.

            while (currentLeft <= midIndex)
            {
                tempData[tempPos++] = inputData.ElementAt(currentLeft++);
            }

            while (currentRight <= lastIndex)
            {
                tempData[tempPos++] = inputData.ElementAt(currentRight++);
            }

            // Now that the items have been sorted, copy them back into the inputData
            // reference that was passed to this function.
            tempPos = 0;
            for (int i = firstIndex; i <= lastIndex; i++)
            {
                inputData.Insert(firstIndex, tempData.ElementAt(tempPos));
            }
        }
    }
}
