using System;
using System.Collections.Generic;

namespace HackerRank.Library 
{
    public static class ArrayExtensions 
    {
        public static bool Swap<T>(this T[] array, long index1, long index2)
        {
            if(array.Length <= index1 || array.Length <= index2) return false;

            T temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;

            return true;
        }

        #region Sorting
        public static void BubbleSort<T>(this T[] array)
        {
            array.BubbleSort<T>(Comparer<T>.Default.Compare);
        }

        public static void BubbleSort<T>(this T[] array, Comparison<T> comparison)
        {
            if (comparison == null) throw new ArgumentException("Null", nameof(comparison));

            bool isSorted = false;
            int lastUnsorted = array.Length -1 ;
            while(!isSorted) {
                isSorted = true;
                for (int i = 0; i < lastUnsorted; i++){
                    if (comparison(array[i], array[i + 1]) > 0){
                        array.Swap(i, i + 1);
                        isSorted = false;
                    }
                }
                lastUnsorted--;
            }
        }

        public static void QuickSort<T>(this T[] array) 
        {
            array.QuickSort<T>(Comparer<T>.Default.Compare);
        }

        public static void QuickSort<T>(this T[] array, Comparison<T> comparison) 
        {
            array.QuickSort<T>(0, array.Length - 1, comparison);
        }

        private static void QuickSort<T>(this T[] array, int left, int right, Comparison<T> comparison) 
        {
            if (left >= right) return;

            int index = Partition(array, left, right, comparison);
            if (left < index - 1) { //sort left half
                QuickSort(array, left, index - 1, comparison);
            }
            if (index < right){ //sort right half
                QuickSort(array, index, right, comparison);
            }
        }

        private static int Partition<T>(T[] array, int left, int right, Comparison<T> comparison)
        {
            T pivot = array[(left + right)/2]; //pick pivot point

            while(left <= right){
                //find element on left that should be on right
                while(comparison(array[left],pivot)<0){
                    left++;
                }
                
                //find element on right that should be on left
                while(comparison(array[right],pivot)>0){
                    right--;
                }     

                //swap elements, and move left and right indices
                if (left <= right) {
                    array.Swap(left, right);
                    left++;
                    right--;
                }
            }

            return left;
        }

        public static void MergeSort<T>(this T[] array)
        {
             MergeSort(array, new T[array.Length], 0, array.Length - 1, Comparer<T>.Default.Compare);
        }

        public static void MergeSort<T>(this T[] array,Comparison<T> comparison)
        {
             MergeSort(array, new T[array.Length], 0, array.Length - 1, comparison);
        }

        private static void MergeSort<T>(T[] array, T[] helper, int leftStart, int rightEnd, Comparison<T> comparison){
            if (leftStart >= rightEnd) return;

            int leftEnd = (leftStart + rightEnd) / 2;
            MergeSort(array, helper, leftStart, leftEnd, comparison); //Sort left half
            MergeSort(array, helper, leftEnd + 1, rightEnd, comparison); //Sort right half
            MergeHalves(array, helper, leftStart, leftEnd, rightEnd, comparison);
        }

        private static void MergeHalves<T>(T[] array, T[] helper, int leftStart, int leftEnd, int rightEnd, Comparison<T> comparison){
            //Copy both halves into a helper array
            for (int i = leftStart; i <= rightEnd; i++)
                helper[i] = array[i];

            int left = leftStart;
            int right = leftEnd + 1;
            int current = leftStart;

            //Iterate through helper array. Compare the left and right half, copying back 
            //the smaller element from the two halves into the original array
            while(left <= leftEnd && right <= rightEnd){
                if (comparison(helper[left],helper[right]) <= 0){
                    array[current] = helper[left];
                    left++;
                } else { //If right element is smaller than left 
                    array[current] = helper[right];
                    right++;
                }
                current++;
            }

            //Copy the rest of the left side of the array into the target array
            int remaining = leftEnd - left;
            for (int i = 0; i <= remaining; i++)
                array[current + i] = helper[left + i];
        }
        
        #endregion

        #region Searching

        public static int BinarySearch<T>(this T[] array, T x)
        {
            return array.BinarySearch(x, Comparer<T>.Default.Compare);
        }

        public static int BinarySearch<T>(this T[] array, T x, Comparison<T> comparison)
        {
            return BinarySearch(array, x, 0, array.Length, comparison);
        }

        private static int BinarySearch<T>(T[] array, T x, int left, int right, Comparison<T> comparison) {
            if (left > right) return -1;
            
            int mid = (left + right) / 2;
            if (comparison(x,array[mid]) < 0) {
                return BinarySearch(array, x, left, mid - 1, comparison);
            } else if(comparison(x,array[mid]) > 0){
                return BinarySearch(array, x, mid + 1, right, comparison);
            } else {
                return mid;
            }
        }

        #endregion
    }
}
