using System;

namespace InsertionSort
{
    public class InsertionSort
    {
        void sort(int[] array) 
        { 
            int arrayLength = array.Length; 
            for (int i = 1; i < arrayLength; ++i) { 
                int key = array[i]; 
                int j = i - 1; 
                
                while (j >= 0 && array[j] > key) { 
                    array[j + 1] = array[j]; 
                    j = j - 1; 
                } 
                array[j + 1] = key; 
            } 
        } 
        
        static void printArray(int[] array) 
        { 
            int arrayLength = array.Length; 
            for (int i = 0; i < arrayLength; ++i) 
                Console.Write(array[i] + " "); 
  
            Console.Write("\n"); 
        } 
        
        public static void Main() 
        { 
            int[] array = { 0, 4, 1, 3, 2 }; 
            InsertionSort insertionSort = new InsertionSort(); 
            insertionSort.sort(array); 
            printArray(array); 
        } 
    }
}