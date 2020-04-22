using System.Collections.Generic;

namespace myapp
{
    class MergeSortArray
    {
        public void mergeSortArray(Person[] arr, int l, int r) 
        { 
            if (l < r) 
            { 
                // Same as (l+r)/2, but avoids overflow for 
                // large l and h 
                int m = l+(r-l)/2; 
        
                // Sort first and second halves 
                mergeSortArray(arr, l, m); 
                mergeSortArray(arr, m+1, r); 
        
                mergeArray(arr, l, m, r); 
            } 
        } 
        public void mergeArray(Person[] arr, int l, int m, int r) 
            { 
                int i, j, k; 
                int n1 = m - l + 1; 
                int n2 =  r - m; 
            
                /* create temp arrays */
                Person[] L = new Person [n1];
                Person[] R = new Person [n2];
                //L[n1], R[n2]; 
            
                /* Copy data to temp arrays L[] and R[] */
                for (i = 0; i < n1; i++) 
                    L[i] = arr[l + i]; 
                for (j = 0; j < n2; j++) 
                    R[j] = arr[m + 1+ j]; 
            
                /* Merge the temp arrays back into arr[l..r]*/
                i = 0; // Initial index of first subarray 
                j = 0; // Initial index of second subarray 
                k = l; // Initial index of merged subarray 
                while (i < n1 && j < n2) 
                { 
                    if (L[i] != null)
                    {
                        if (R[j] != null)
                        {
                            if(L[i].BMI <= R[j].BMI)
                            { 
                                arr[k] = L[i]; 
                                i++; 
                            } 
                            else
                            { 
                                arr[k] = R[j]; 
                                j++; 
                            } 
                            k++;
                        }
                        else j++;
                    }
                    else i++;
                } 
            
                /* Copy the remaining elements of L[], if there 
                are any */
                while (i < n1) 
                { 
                    arr[k] = L[i]; 
                    i++; 
                    k++; 
                } 
            
                /* Copy the remaining elements of R[], if there 
                are any */
                while (j < n2) 
                { 
                    arr[k] = R[j]; 
                    j++; 
                    k++; 
                } 
            }
        
    }
}