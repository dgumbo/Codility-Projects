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
public class Beta_CountPalindromicSlices {

    public static void main(String[] args) {
        Beta_CountPalindromicSlices ps = new Beta_CountPalindromicSlices(); 
        
        //String A = "abbacada";
        String A = "baababa";

        //System.out.println("Integer.MAX_VALUE : " + Integer.MAX_VALUE);
        System.out.println(": " + ps.solution(A));
    }

    public int solution(String S) {
        // write your code in Java SE 8
        int s = 0;           
        int l = S.length();
        
        for (int i = 0 ; i <= l ; i++ ){
            for (int j = 2; j < l - i + 1; j++){
                if (i + j > l) break;
                String testString = S.substring(i, i + j);                
                String reverse = new StringBuilder(testString).reverse().toString();
                if (testString.equals(reverse)) s++;
                if (s>100000000) return -1;
                
                System.out.println("testString:" + testString);
                System.out.println("reverse:" + reverse + (testString.equals(reverse) ? "\nMatch Found" : "") + "\n"); 
            }
        }
        
        return s;
    }
    
}
