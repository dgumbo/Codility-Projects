package com.denzilgumbo.codility.exercises;

import java.util.ArrayList;
import java.util.List;

public class Delta_MinAbsSum {
    
    public static void main(String[] args) {
        Delta_MinAbsSum ps = new Delta_MinAbsSum();
        
        //int[] A = new int[]{1,1,1,2,5,7,5,6,0};
        int[] A = new int[]{1, 5, 2, -2};
        
        System.out.println(": " + ps.solution(A));
    }

    public int solution(int[] A) {
        // write your code in Java SE 8  
        int sum = 0;  
        int max = 0;
        
        if (A.length == 0) return 0; 
        
        for (int i = 0; i < A.length; i++){
            A[i] = A[i] < 0 ? -A[i] : A[i];
            sum +=  A[i]  ;  
            max = max < A[i] ? A[i] : max;
            
        //    sum += A[i] * (i % 2 == 0 ? -1 : 1) ;            
            
            System.out.println(i + " : " + A[i] + " : " + max);
        }
            System.out.println("\n");
                
        final int[] counts = new int[max + 1];
        for (int value: A) {
            counts[value]++;
            System.out.println(counts[value]);
        }

            
        return  sum < 0 ? -sum : sum;
    }
}
