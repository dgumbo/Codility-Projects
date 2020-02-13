package com.denzilgumbo.codility.exercises;

import java.util.ArrayList;
import java.util.List;

public class Epsilon_Minfuds {
    
    public static void main(String[] args) {
        Epsilon_Minfuds ps = new Epsilon_Minfuds();
        
        //int[] A = new int[]{1,1,1,2,5,7,5,6,0};
        //int[] A = new int[]{2,2,1,0,1};
        //int[] A = new int[]{88,66};
        //int[] A = new int[]{99};
        //int[] A = new int[]{2,1};
        //int[] A = new int[]{0,1};
        //int[] A = new int[]{19, 6, 19, 6, 19, 6, 19, 6, 19, 6, 19, 6};
         int[] A = new int[]{-1, 1, 0};
         int[] B = new int[]{3, 0, 2};
        
        System.out.println(": " + ps.solution(A, B));
    }

    public double solution(int[] A, int[] B) {
        // write your code in Java SE 8  
        if (A.length != B.length) return 0;
         
        double X =  ((double)  A.length ) / 2     ;
       // System.out.println("X : " + X);
       
        double u_x = maxF(A, B, X);
        double d_x = minF(A, B, X);
        double s_x = u_x - d_x ;
                
        return s_x;
    }
    
    private double maxF (int[] A, int[] B, double X){
        int iSize = A.length;
        double dMaxNum = Double.MIN_VALUE;
        
        for (int i =0; i < iSize; i++){
            double dTest = A[i] * X + B[i] ;
            
            dMaxNum = dMaxNum > dTest ? dMaxNum : dTest;
        }
        
        return dMaxNum;
    } 
    
    private double minF (int[] A, int[] B, double X){
        int iSize = A.length;
        double dMaxNum = Double.MAX_VALUE;
        
        for (int i =0; i < iSize; i++){
            double dTest = A[i] * X + B[i] ;
            
            dMaxNum = dMaxNum < dTest ? dMaxNum : dTest;
        }
        
        return dMaxNum;
    }  
}
