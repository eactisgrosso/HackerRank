using System;
using System.Collections.Generic;

namespace HackerRank.Library 
{
    public static class ArrayExtensions 
    {
        const int IntroSortSizeThreshold = 16;

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

        private static void QuickSort<T>(this T[] array, int lo, int hi, Comparison<T> comparison) 
        {
            if (lo >= hi) return;

            int index = Partition(array, lo, hi, comparison);
            if (lo < index - 1) { //sort left half
                QuickSort(array, lo, index - 1, comparison);
            }
            if (index < hi){ //sort right half
                QuickSort(array, index, hi, comparison);
            }
        }

        private static int Partition<T>(T[] array, int lo, int hi, Comparison<T> comparison)
        {
            T pivot = array[(lo + hi)/2]; //pick pivot point

            while(lo <= hi){
                //find element on left that should be on right
                while(comparison(array[lo],pivot)<0){
                    lo++;
                }
                
                //find element on right that should be on left
                while(comparison(array[hi],pivot)>0){
                    hi--;
                }     

                //swap elements, and move left and right indices
                if (lo <= hi) {
                    array.Swap(lo, hi);
                    lo++;
                    hi--;
                }
            }

            return lo;
        }

        public static void MergeSort<T>(this T[] array)
        {
             array.MergeSort(Comparer<T>.Default.Compare);
        }

        public static void MergeSort<T>(this T[] array,Comparison<T> comparison)
        {
             MergeSort(array, new T[array.Length], 0, array.Length - 1, comparison);
        }

        private static void MergeSort<T>(T[] array, T[] helper, int lo, int hi, Comparison<T> comparison){
            if (lo >= hi) return;

            int pivot = (lo + hi) / 2;
            MergeSort(array, helper, lo, pivot, comparison); //Sort left half
            MergeSort(array, helper, pivot + 1, hi, comparison); //Sort right half
            MergeHalves(array, helper, lo, pivot, hi, comparison);
        }

        private static void MergeHalves<T>(T[] array, T[] helper, int lo, int pivot, int hi, Comparison<T> comparison){
            //Copy both halves into a helper array
            for (int i = lo; i <= hi; i++)
                helper[i] = array[i];

            int left = lo;
            int right = pivot + 1;
            int current = lo;

            //Iterate through helper array. Compare the left and right half, copying back 
            //the smaller element from the two halves into the original array
            while(left <= pivot && right <= hi){
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
            int remaining = pivot - left;
            for (int i = 0; i <= remaining; i++)
                array[current + i] = helper[left + i];
        }

        public static void HeapSort<T>(this T[] array)
        {
            array.HeapSort(Comparer<T>.Default.Compare);
        }

        public static void HeapSort<T>(this T[] array, Comparison<T> comparison)
        {
            array.HeapSort(0, array.Length - 1,comparison);
        }

        private static void HeapSort<T>(this T[] array, int lo, int hi, Comparison<T> comparison)
        {
            int n = hi - lo + 1;
            for (int i = n/2; i >= 1; i--)
                DownHeap(array, i, n, lo, comparison);
           
            for (int i = n; i > 1; i--)
            {
                array.Swap(lo, lo + i - 1);
                DownHeap(array, 1, i - 1, lo, comparison);
            }
        }

        private static void DownHeap<T>(T[] array, int i, int n, int lo, Comparison<T> comparison)
        {
            T current = array[lo + i - 1];
            T parent;
            int child;
            while (i <= n / 2)
            {
                child = 2 * i;
                parent = array[lo + child - 1];
                if (child < n && (parent == null || comparison(array[lo + child],parent) > 0))
                    child++;
                parent = array[lo + child - 1];
                if (parent == null || comparison(current, parent) > 0)
                    break;
                array[lo + i - 1] = parent;
                i = child;
            }
            array[lo + i - 1] = current;
        }

        public static void InsertionSort<T>(this T[] array)
        {
           array.InsertionSort(Comparer<T>.Default.Compare);
        }

        public static void InsertionSort<T>(this T[] array, Comparison<T> comparison)
        {
            array.InsertionSort(0, array.Length - 1, comparison);
        }

        private static void InsertionSort<T>(this T[] array, int lo, int hi, Comparison<T> comparison)
        {
            int i, j;
            T t;
            for (i = lo; i < hi; i++)
            {
                j = i;
                t = array[i + 1];
                while (j >= lo && comparison(t, array[j]) < 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = t;
            }
        }
        public static void IntroSort<T>(this T[] array) 
        {
            array.IntroSort<T>(Comparer<T>.Default.Compare);
        }

        public static void IntroSort<T>(this T[] array, Comparison<T> comparison) 
        {
            array.IntroSort<T>(0, array.Length - 1, 2 * array.Length.FloorLog2(), comparison);
        }
        
        private static void IntroSort<T>(this T[] array, int lo, int hi, int depth, Comparison<T> comparison)
        {
            if (lo >= hi) return;

            int partitionSize = hi - lo + 1;
            if (partitionSize == 1) return;
            
            if (partitionSize <= IntroSortSizeThreshold)
            {
                array.InsertionSort(lo, hi, comparison);
                return;
            }

            if (depth == 0)
            {
                array.HeapSort(lo, hi, comparison);
                return;
            }

            int index = Partition(array, lo, hi, comparison);
            if (lo < index - 1) {
                IntroSort(array, lo, index - 1, --depth, comparison);
            }
            if (index < hi){
                IntroSort(array, index, hi, --depth, comparison);
            }
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
