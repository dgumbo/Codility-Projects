/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.denzilgumbo.codility.lessons._04_counting_elements;

import java.util.Arrays;

/**
 *
 * @author denzil
 */
public class FrogRiverOne {

    public static void main(String[] args) {
        FrogRiverOne ps = new FrogRiverOne();

        //int[] A = new int[]{2, 3, 1, 5};
        //int[] A = new int[]{4, 1, 3};
        int[] A = new int[]{7, 1, 3, 1, 4, 2, 3, 5, 4, 9, 3, 8, 5, 6, 9, 10};

        System.out.println("PermCheck : " + ps.solution(10, A));
    }

    public int solution(int X, int[] A) {
        // write your code in Java SE 8

        int iLength = A.length;
        if ( X > iLength )  return -1; 
        if ( iLength == 0 )  return -1; 
        if ( iLength == 1 && A[0] == 1 )  return  0; 
        if ( iLength == 1 && A[0] == 1 && X == 1 )  return  1; 

        int[] B = A.clone();
        Arrays.sort(B);
        for (int i = 0; i < X - 1; i++) {
            if (B[i] == B[i + 1]) {
            } else {
                if (B[i] + 1 != B[i + 1])  return -1; 
            }
        }

        int iCnt = 0;
        int[] C = new int[X];
        for (int i = 0; i < iLength  ; i++) {
            int v = A[i];
            if (v <= X) { 
                if (C[v-1] == 0) { 
                    C[v-1] = v;
                    iCnt += 1;
                }
            }
            if (iCnt == X)   return i; 
        }
         
        return -1;
    }
}
