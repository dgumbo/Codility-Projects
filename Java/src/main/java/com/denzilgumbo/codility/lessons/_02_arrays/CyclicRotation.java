package com.denzilgumbo.codility.lessons._02_arrays;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class CyclicRotation {

    public static void main(String[] args) {
        CyclicRotation ps = new CyclicRotation();

       //  int[] A = new int[]{73, 7, 4, 7, 2, 6, 7, 2, 7, 73, 9, 7, 7}; 
       // int[] A = new int[]{9, 7, 7};
        //int[] A = new int[]{3, 8, 9, 7, 6 };
        int[] A = new int[]{1, 2, 3, 4 };

      //  int[] result = ps.solution(A, 4); 
         int[] result = ps.solution(A, 3); 
        
        System.out.println(Arrays.toString(result));
    }

    public int[] solution(int[] A, int K) {
        // write your code in Java SE 8  
        if (A.length <= 1)  return A ; 
 
        int l = A.length ;
        
        int  B [] = new int[l] ; 
           // System.out.println( "A.length - " + l);
        
        int iPush = K % l ;
        //int iPush = K   ;

        for (int i = 0; i < l; i++) { 
           // int ipos = i - iPull + 1 < 0 ?  l - K + i + 1 : i - iPull + 1  ;
            int ipos =  i - iPush  ;            
            ipos = ipos < 0 ? l + ipos : ipos ;
            
            //System.out.println(i + "  <-  " + ipos);
            B[i] = A[ipos] ; 
        }

        return B;
    }
}
