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
public class FrogJmp {
        public static void main(String[] args) {
        FrogJmp ps = new FrogJmp();

        //int[] A = new int[]{73, 7, 4, 7, 2, 6, 7, 2, 7, 73, 9, 7, 7};
       // int[] A = new int[]{9, 7, 7};
       // int[] A = new int[]{9, 3, 9, 3, 9, 7, 9};
        int[] A = new int[]{3, 1, 2, 4, 3};
        //int[] A = new int[]{};

        System.out.println("TapeEquilibrium : " + ps.solution(10,85,30));
    }   
       
    public int solution(int X, int Y, int D) {
        // write your code in Java SE 8
        
        int iFullJumps = (Y-X) / D ;
        int iRemainder = (Y-X) % D ;
        
        if (iRemainder > 0) iFullJumps += 1 ; 
        
        return iFullJumps;
    }
}
