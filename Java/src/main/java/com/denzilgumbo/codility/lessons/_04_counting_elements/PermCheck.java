/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.denzilgumbo.codility.lessons._04_counting_elements ;
  
import java.util.Arrays;


/**
 *
 * @author denzil
 */
public class PermCheck {
        public static void main(String[] args) {
        PermCheck ps = new PermCheck(); 
        
        //int[] A = new int[]{2, 3, 1, 5};
        //int[] A = new int[]{4, 1, 3};
        int[] A = new int[]{4, 1, 3, 2};

        System.out.println("PermCheck : " + ps.solution(A));
    }   
        
    public int solution(int[] A) {
        // write your code in Java SE 8
        
        int iLength = A.length; 
        if (iLength==0) return 0;
        
        Arrays.sort(A); 
        
        if (A[0] >= 2) return 0; 
        
        for(int i = 0 ; i < iLength - 1; i++){
            if (A[i] + 1 != A[i + 1]) return 0 ;
        }
        
        return  1;
    }
}
