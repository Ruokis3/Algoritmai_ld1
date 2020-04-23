using System.Collections.Generic;
namespace myapp
{
    public class node { 
            public Person person; 
            public node next; 
        
            public node(Person person) 
            { 
                this.person = person; 
            } 
        }
    public class MergeSortList
    {
        public long listOperations = 0;
        node sortedMerge(node a, node b) 
        { 
            node result = null; 
            if (a == null) 
                return b; 
            if (b == null) 
                return a; 
    
            if (a.person.BMI <= b.person.BMI) { 
                result = a; 
                result.next = sortedMerge(a.next, b); 
            } 
            else { 
                result = b; 
                result.next = sortedMerge(a, b.next); 
            } 
            return result; 
        } 
    
        public node mergeSort(node h) 
        { 
            if (h == null || h.next == null) { 
                return h; 
            } 
    
            node middle = getMiddle(h); 
            node nextofmiddle = middle.next; 
    
            middle.next = null; 
    
            node left = mergeSort(h); 
    
            node right = mergeSort(nextofmiddle); 
    
            node sortedlist = sortedMerge(left, right); 
            return sortedlist; 
        } 
    
        node getMiddle(node h) 
        { 
            if (h == null) 
                return h; 
            node fastptr = h.next; 
            node slowptr = h; 

            while (fastptr != null) { 
                fastptr = fastptr.next; 
                if (fastptr != null) { 
                    slowptr = slowptr.next; 
                    fastptr = fastptr.next; 
                } 
            } 
            return slowptr; 
        } 
    }
}