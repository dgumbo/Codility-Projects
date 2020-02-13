/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.denzilgumbo.codility.lessons._03_time_complexity;
 
import java.util.Arrays;


/**
 *
 * @author denzil
 */
public class PermMissingElem {
        public static void main(String[] args) {
        PermMissingElem ps = new PermMissingElem(); 
        
        int[] A = new int[]{2, 3, 1, 5};

        System.out.println("TapeEquilibrium : " + ps.solution(A));
    }   
        
    public int solution(int[] A) {
        // write your code in Java SE 8
        
        int iLength = A.length; 
        if (iLength==0) return 1;
        
        Arrays.sort(A); 
        
        if (A[0] == 2) return 1; 
        
        for(int i = 0 ; i < iLength - 1; i++){
            if (A[i] + 1 != A[i + 1]) return A[i] + 1 ;
        }
        
        return A[iLength-1] + 1;
    }
}
