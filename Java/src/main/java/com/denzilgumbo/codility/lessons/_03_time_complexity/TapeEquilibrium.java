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
public class TapeEquilibrium {
        public static void main(String[] args) {
        TapeEquilibrium ps = new TapeEquilibrium();

        //int[] A = new int[]{73, 7, 4, 7, 2, 6, 7, 2, 7, 73, 9, 7, 7};
       // int[] A = new int[]{9, 7, 7};
       // int[] A = new int[]{9, 3, 9, 3, 9, 7, 9};
        int[] A = new int[]{3, 1, 2, 4, 3};
        //int[] A = new int[]{};

        System.out.println("TapeEquilibrium : " + ps.solution(A));
    }   
       
       //    int iLeftSum; 
       //     int iRightSum;
    public int solution(int[] A) {
        // write your code in Java SE 8
        
        int iLength = A.length;
        if (iLength == 0) return 0;
        if (iLength == 1) return A[0]; 
        
        int iMin = Integer.MAX_VALUE;
        int iLeftSum = 0 ;//A[0]; 
        
        int iRightSum=0;            
        for (int j = 0; j < iLength; j++) 
              iRightSum   += A[j];      
        
        
        for (int i = 1; i < iLength; i++){
             iLeftSum += A[i-1];               
             iRightSum -=   A[i-1]; 
            
            int iSum = Math.abs(iLeftSum-iRightSum);
            if( iSum < iMin ) iMin = iSum ;

            //System.out.print("i : " + i + ", (iLength - 1) : " + (iLength - 1));
             
//            Arrays.stream( C, i , iLength - 1 ).forEach( action -> {
//                iRightSum += action;
//            }); 
//            
            System.out.println ("iLeftSum : " + iLeftSum + ", iRightSum : " + iRightSum); 
        }
        
        return iMin;
    }
}
