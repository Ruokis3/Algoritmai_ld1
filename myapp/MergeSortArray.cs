using System.Collections.Generic;
using System.Timers;

namespace myapp
{
    class MergeSortArray
    {
        public long arrOperations = 0;
        public void mergeSortArray(Person[] arr, int l, int r) 
        { 
            arrOperations++;
            if (l < r) 
            { 
                int m = l+(r-l)/2; 

                mergeSortArray(arr, l, m); 
                mergeSortArray(arr, m+1, r); 
        
                mergeArray(arr, l, m, r); 
            }
        }
        public void mergeArray(Person[] arr, int l, int m, int r) 
            { 
                arrOperations++;
                int i, j, k; 
                int n1 = m - l + 1; 
                int n2 =  r - m; 
            
                Person[] L = new Person [n1];
                Person[] R = new Person [n2];

                for (i = 0; i < n1; i++) {
                    L[i] = arr[l + i]; 
                    arrOperations++;
                }
                for (j = 0; j < n2; j++) {
                    R[j] = arr[m + 1+ j]; 
                    arrOperations++;
                }
            
                i = 0; // Initial index of first subarray 
                j = 0; // Initial index of second subarray 
                k = l; // Initial index of merged subarray 
                while (i < n1 && j < n2) 
                { 
                    arrOperations++;
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
        
                while (i < n1) 
                { 
                    arr[k] = L[i]; 
                    i++; 
                    k++; 
                    arrOperations++;
                } 

                while (j < n2) 
                { 
                    arr[k] = R[j]; 
                    j++; 
                    k++; 
                    arrOperations++;
                } 
            }
        
    }
}