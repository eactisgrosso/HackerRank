using System;
using System.Collections.Generic;

namespace HackerRank.Library 
{
    public static class ArrayExtensions 
    {
        const int IntroSortSizeThreshold = 16;

        public static bool Swap<T>(this T[] array, long index1, long index2)
        {
            if (index1 == index2) return false;
            if(array.Length <= index1 || array.Length <= index2) return false;

            T temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;

            return true;
        }

        public static void Fill<T>(this T[] array, T value ) {
            for ( int i = 0; i < array.Length;i++ ) {
                array[i] = value;
            }
        }

        public static void Reverse<T>(this T[] array){
            array.Reverse(0, array.Length - 1);
        }

        public static void Reverse<T>(this T[] array, int from, int to){
            while (from < to) {
                array.Swap(to,from);
                from++;
                to--;
            }
        }
                
        public static T Median<T>(this T[] array) where T : IComparable<T>
        {
            return array.QuickSelect((array.Length - 1)/2, Comparer<T>.Default.Compare);
        }

        public static double Median(this int[] array)
        {
            var oddMiddle = (array.Length - 1)/2;
            var oddMedian = array.QuickSelect(oddMiddle, Comparer<int>.Default.Compare);

            if (array.Length % 2 == 0) //even
                return (oddMedian + array[oddMiddle + 1]) / 2.0;

            return oddMedian;
        }

         public static double FrequencyMedian(this int[] array, int length) 
         {
            int sum = 0;
            for (int i = 0; i < array.Length; i++) {
                sum += array[i];
                if (2 * sum < length)
                    continue;
                else if (2 * sum == length)
                    return (2 * i + 1) / 2.0;
                else
                    return i * 1.0;
            }
            return -1.0;
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

        private static void QuickSort<T>(this T[] array, int start, int end, Comparison<T> comparison) 
        {
            if (start >= end) return;

            int pivotIndex = Partition(array, start, end, (start + end)/2, comparison);
            if (start < pivotIndex - 1) { //sort left half
                QuickSort(array, start, pivotIndex - 1, comparison);
            }
            if (pivotIndex < end){ //sort right half
                QuickSort(array, pivotIndex, end, comparison);
            }
        }

        public static T QuickSelect<T>(this T[] array, int i, Comparison<T> comparison) where T : IComparable<T>
        {
            return array.QuickSelect(i, 0, array.Length - 1, comparison);
        }

        private static T QuickSelect<T>(this T[] array, int k, int start, int end, Comparison<T> comparison) where T : IComparable<T>
        {
            if (start == end) return array[start];

            var pivotIndex = Partition<T>(array, start, end, (start + end)/2, comparison);
            if (start == end) 
                return array[pivotIndex];
            else if (k < pivotIndex)
                return array.QuickSelect(k, start, pivotIndex - 1, comparison);
            else
                return array.QuickSelect(k, pivotIndex, end, comparison);
        }

        private static int Partition<T>(T[] array, int start, int end, int pivotIndex, Comparison<T> comparison)
        {
            T pivot = array[pivotIndex]; 

            while(start <= end){
                //find element on left that should be on right
                while(comparison(array[start],pivot)<0){
                    start++;
                }
                
                //find element on right that should be on left
                while(comparison(array[end],pivot)>0){
                    end--;
                }     

                //swap elements, and move left and right indices
                if (start <= end) {
                    array.Swap(start,end);
                    start++;
                    end--;
                }
            }
       
            return start;
        }

        public static void MergeSort<T>(this T[] array)
        {
             array.MergeSort(Comparer<T>.Default.Compare);
        }

        public static void MergeSort<T>(this T[] array,Comparison<T> comparison)
        {
             MergeSort(array, new T[array.Length], 0, array.Length - 1, comparison);
        }

        private static void MergeSort<T>(T[] array, T[] helper, int start, int end, Comparison<T> comparison){
            if (start >= end) return;

            int pivot = (start + end) / 2;
            MergeSort(array, helper, start, pivot, comparison); //Sort left half
            MergeSort(array, helper, pivot + 1, end, comparison); //Sort right half
            MergeHalves(array, helper, start, pivot, end, comparison);
        }

        private static void MergeHalves<T>(T[] array, T[] helper, int start, int pivot, int end, Comparison<T> comparison){
            //Copy both halves into a helper array
            for (int i = start; i <= end; i++)
                helper[i] = array[i];

            int left = start;
            int right = pivot + 1;
            int current = start;

            //Iterate through helper array. Compare the left and right half, copying back 
            //the smaller element from the two halves into the original array
            while(left <= pivot && right <= end){
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

        private static void HeapSort<T>(this T[] array, int start, int end, Comparison<T> comparison)
        {
            int n = end - start + 1;
            for (int i = n/2; i >= 1; i--)
                DownHeap(array, i, n, start, comparison);
           
            for (int i = n; i > 1; i--)
            {
                array.Swap(start, start + i - 1);
                DownHeap(array, 1, i - 1, start, comparison);
            }
        }

        private static void DownHeap<T>(T[] array, int i, int n, int start, Comparison<T> comparison)
        {
            T current = array[start + i - 1];
            T parent;
            int child;
            while (i <= n / 2)
            {
                child = 2 * i;
                parent = array[start + child - 1];
                if (child < n && (parent == null || comparison(array[start + child],parent) > 0))
                    child++;
                parent = array[start + child - 1];
                if (parent == null || comparison(current, parent) > 0)
                    break;
                array[start + i - 1] = parent;
                i = child;
            }
            array[start + i - 1] = current;
        }

        public static void InsertionSort<T>(this T[] array)
        {
           array.InsertionSort(Comparer<T>.Default.Compare);
        }

        public static void InsertionSort<T>(this T[] array, Comparison<T> comparison)
        {
            array.InsertionSort(0, array.Length - 1, comparison);
        }

        private static void InsertionSort<T>(this T[] array, int start, int end, Comparison<T> comparison)
        {
            int i, j;
            T unsorted;
            for (i = start; i < end; i++)
            {
                unsorted = array[i + 1];
                j = i;
                while (j >= start && comparison(array[j],unsorted) > 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = unsorted;
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
        
        private static void IntroSort<T>(this T[] array, int start, int end, int depth, Comparison<T> comparison)
        {
            if (start >= end) return;

            int partitionSize = end - start + 1;
            if (partitionSize == 1) return;
            
            if (partitionSize <= IntroSortSizeThreshold)
            {
                array.InsertionSort(start, end, comparison);
                return;
            }

            if (depth == 0)
            {
                array.HeapSort(start, end, comparison);
                return;
            }

            int index = Partition(array, start, end, (start + end)/2, comparison);
            if (start < index - 1) {
                IntroSort(array, start, index - 1, --depth, comparison);
            }
            if (index < end){
                IntroSort(array, index, end, --depth, comparison);
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
