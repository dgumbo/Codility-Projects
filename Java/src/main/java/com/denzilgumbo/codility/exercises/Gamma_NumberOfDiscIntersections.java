/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.denzilgumbo.codility.exercises; 
/**
 *
 * @author denzil
 */
public class Gamma_NumberOfDiscIntersections {

    public static void main(String[] args) {
        Gamma_NumberOfDiscIntersections ps = new Gamma_NumberOfDiscIntersections();

        //int[] A = new int[]{1,1,1,2,5,7,5,6,0};
        //int[] A = new int[]{2,2,1,0,1};
        //int[] A = new int[]{88,66};
        //int[] A = new int[]{99};
        //int[] A = new int[]{2,1};
        //int[] A = new int[]{0,1};
        //int[] A = new int[]{19, 6, 19, 6, 19, 6, 19, 6, 19, 6, 19, 6};
        // int[] A = new int[]{73, 7, 4, 7, 2, 6, 7, 2, 7, 73, 9, 17, 7, 7};
        int[] A = new int[]{1, 5, 2, 1, 4, 0};

        System.out.println("Integer.MAX_VALUE : " + Integer.MAX_VALUE);
        System.out.println(": " + ps.solution(A));
    }

    public int solution(int[] A) {
        // write your code in Java SE 8

        int m = 0;
        long l = A.length;        

        if (l < 2) return 0;        
        if (l > Integer.MAX_VALUE) return 0;

        for (int i = 0; i < l - 1; i++) {
            for (int j = i + 1; j < l; j++) {
                if ((i + A[i] >= j - A[j])) {
                    m++;
                }
                if (m > 10000000)  return -1;                
            }
        }

        return (int) m;
    }
}
